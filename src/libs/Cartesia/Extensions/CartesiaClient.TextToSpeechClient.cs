#nullable enable
#pragma warning disable MEAI001
#pragma warning disable CS0618

using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;

namespace Cartesia;

public sealed partial class CartesiaClient : ITextToSpeechClient
{
    private const TTSModelID DefaultTtsModel = TTSModelID.Sonic36;
    private const TtsBytesCartesiaVersion DefaultTtsBytesVersion = TtsBytesCartesiaVersion.x20260814;
    private const TtsSseCartesiaVersion DefaultTtsSseVersion = TtsSseCartesiaVersion.x20260814;
    private const int DefaultSampleRate = 44100;
    private const int DefaultBitRate = 128000;
    private TextToSpeechClientMetadata? _textToSpeechMetadata;

    object? ITextToSpeechClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return serviceKey is not null ? null :
            serviceType == typeof(TextToSpeechClientMetadata) ? (_textToSpeechMetadata ??= new("cartesia", new Uri(DefaultBaseUrl), DefaultTtsModel.ToValueString())) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<TextToSpeechResponse> ITextToSpeechClient.GetAudioAsync(
        string text,
        TextToSpeechOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var request = CreateTtsRequest(text, options);
        var audio = await Tts.TtsBytesAsync(
            cartesiaVersion: DefaultTtsBytesVersion,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return new TextToSpeechResponse([
            new DataContent(audio, GetMediaType(request.OutputFormat)),
        ])
        {
            ModelId = request.ModelId.ToValueString(),
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(
                modelId: request.ModelId.ToValueString(),
                voiceId: GetVoiceId(request.Voice),
                language: request.Locale ?? request.Language,
                mediaType: GetMediaType(request.OutputFormat)),
        };
    }

    async IAsyncEnumerable<TextToSpeechResponseUpdate> ITextToSpeechClient.GetStreamingAudioAsync(
        string text,
        TextToSpeechOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var request = CreateTtsSseRequest(text, options);
        var responseId = request.ContextId ?? Guid.NewGuid().ToString("N");
        var modelId = request.ModelId.ToValueString();
        var mediaType = GetMediaType(request.OutputFormat);

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionOpen,
            ResponseId = responseId,
            ModelId = modelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(
                modelId: modelId,
                voiceId: GetVoiceId(request.Voice),
                language: request.Locale ?? request.Language,
                mediaType: mediaType,
                contextId: request.ContextId),
        };

        await foreach (var @event in Tts.TtsSseAsync(
            cartesiaVersion: DefaultTtsSseVersion,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            if (@event.TryPickChunk(out var chunk))
            {
                yield return new TextToSpeechResponseUpdate([
                    new DataContent(Convert.FromBase64String(chunk.Data), mediaType),
                ])
                {
                    Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                    ResponseId = chunk.ContextId ?? responseId,
                    ModelId = modelId,
                    RawRepresentation = chunk,
                    AdditionalProperties = CreateResponseProperties(
                        modelId: modelId,
                        voiceId: GetVoiceId(request.Voice),
                        language: request.Locale ?? request.Language,
                        mediaType: mediaType,
                        contextId: chunk.ContextId ?? request.ContextId,
                        statusCode: chunk.StatusCode,
                        stepTime: chunk.StepTime),
                };

                continue;
            }

            if (@event.TryPickTimestamps(out var timestamps))
            {
                yield return new TextToSpeechResponseUpdate
                {
                    Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                    ResponseId = timestamps.ContextId ?? responseId,
                    ModelId = modelId,
                    RawRepresentation = timestamps,
                    AdditionalProperties = CreateResponseProperties(
                        modelId: modelId,
                        voiceId: GetVoiceId(request.Voice),
                        language: request.Locale ?? request.Language,
                        mediaType: mediaType,
                        contextId: timestamps.ContextId ?? request.ContextId,
                        statusCode: timestamps.StatusCode),
                };

                continue;
            }

            if (@event.TryPickPhonemeTimestamps(out var phonemeTimestamps))
            {
                yield return new TextToSpeechResponseUpdate
                {
                    Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                    ResponseId = phonemeTimestamps.ContextId ?? responseId,
                    ModelId = modelId,
                    RawRepresentation = phonemeTimestamps,
                    AdditionalProperties = CreateResponseProperties(
                        modelId: modelId,
                        voiceId: GetVoiceId(request.Voice),
                        language: request.Locale ?? request.Language,
                        mediaType: mediaType,
                        contextId: phonemeTimestamps.ContextId ?? request.ContextId,
                        statusCode: phonemeTimestamps.StatusCode),
                };

                continue;
            }

            if (@event.TryPickError(out var error))
            {
                yield return new TextToSpeechResponseUpdate
                {
                    Kind = TextToSpeechResponseUpdateKind.Error,
                    ResponseId = responseId,
                    ModelId = modelId,
                    RawRepresentation = error,
                    AdditionalProperties = CreateResponseProperties(
                        modelId: modelId,
                        voiceId: GetVoiceId(request.Voice),
                        language: request.Locale ?? request.Language,
                        mediaType: mediaType,
                        statusCode: error.StatusCode),
                };

                continue;
            }

            if (@event.TryPickDone(out var done))
            {
                yield return new TextToSpeechResponseUpdate
                {
                    Kind = TextToSpeechResponseUpdateKind.AudioUpdated,
                    ResponseId = done.ContextId ?? responseId,
                    ModelId = modelId,
                    RawRepresentation = done,
                    AdditionalProperties = CreateResponseProperties(
                        modelId: modelId,
                        voiceId: GetVoiceId(request.Voice),
                        language: request.Locale ?? request.Language,
                        mediaType: mediaType,
                        contextId: done.ContextId ?? request.ContextId,
                        statusCode: done.StatusCode),
                };
            }
        }

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionClose,
            ResponseId = responseId,
            ModelId = modelId,
        };
    }

    private TTSRequest CreateTtsRequest(string text, TextToSpeechOptions? options)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as TTSRequest;
        if (request is null)
        {
            request = new TTSRequest
            {
                ModelId = ResolveModel(options?.ModelId),
                Transcript = text,
                Voice = CreateVoice(options),
                OutputFormat = CreateOutputFormat(options),
            };
        }

        if (string.IsNullOrWhiteSpace(request.Transcript))
        {
            request.Transcript = text;
        }

        ApplyCommonOptions(request, options);

        return request;
    }

    private TTSSSERequest CreateTtsSseRequest(string text, TextToSpeechOptions? options)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as TTSSSERequest;
        if (request is null)
        {
            request = new TTSSSERequest
            {
                ModelId = ResolveModel(options?.ModelId),
                Transcript = text,
                Voice = CreateVoice(options),
                OutputFormat = CreateSseOutputFormat(options),
            };
        }

        if (string.IsNullOrWhiteSpace(request.Transcript))
        {
            request.Transcript = text;
        }

        ApplyCommonOptions(request, options);
        request.ContextId ??= options.GetString(CartesiaTextToSpeechPropertyNames.ContextId);
        request.AddTimestamps ??= options.GetBool(CartesiaTextToSpeechPropertyNames.AddTimestamps);
        request.AddPhonemeTimestamps ??= options.GetBool(CartesiaTextToSpeechPropertyNames.AddPhonemeTimestamps);
        request.UseNormalizedTimestamps ??= options.GetBool(CartesiaTextToSpeechPropertyNames.UseNormalizedTimestamps);

        return request;
    }

    private static void ApplyCommonOptions(TTSRequest request, TextToSpeechOptions? options)
    {
        request.ModelId = ResolveModel(options?.ModelId, request.ModelId);
        request.Voice = options?.VoiceId is { Length: > 0 } || !request.Voice.Validate()
            ? CreateVoice(options)
            : request.Voice;
        ApplyLocaleAndVoiceControls(request, options);
        request.GenerationConfig = CreateGenerationConfig(options, request.GenerationConfig);
        request.OutputFormat = request.OutputFormat.Object is null || options?.AudioFormat is { Length: > 0 }
            ? CreateOutputFormat(options)
            : request.OutputFormat;
        request.PronunciationDictId ??= options.GetString(CartesiaTextToSpeechPropertyNames.PronunciationDictionaryId);
    }

    private static void ApplyCommonOptions(TTSSSERequest request, TextToSpeechOptions? options)
    {
        request.ModelId = ResolveModel(options?.ModelId, request.ModelId);
        request.Voice = options?.VoiceId is { Length: > 0 } || !request.Voice.Validate()
            ? CreateVoice(options)
            : request.Voice;
        ApplyLocaleAndVoiceControls(request, options);
        request.GenerationConfig = CreateGenerationConfig(options, request.GenerationConfig);
        request.OutputFormat ??= CreateSseOutputFormat(options);
        request.PronunciationDictId ??= options.GetString(CartesiaTextToSpeechPropertyNames.PronunciationDictionaryId);
    }

    private static TTSRequestVoiceSpecifier CreateVoice(TextToSpeechOptions? options)
    {
        if (options?.VoiceId is not { Length: > 0 } voiceId)
        {
            throw new ArgumentException("Cartesia TTS requires TextToSpeechOptions.VoiceId to be set.", nameof(options));
        }

        return voiceId;
    }

    private static TTSModelID ResolveModel(string? modelId, TTSModelID defaultModel = DefaultTtsModel)
    {
        if (modelId is not { Length: > 0 })
        {
            return defaultModel;
        }

        return TTSModelIDExtensions.ToEnum(modelId)
            ?? throw new ArgumentException($"Unknown Cartesia TTS model '{modelId}'.", nameof(modelId));
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Globalization",
        "CA1308:Normalize strings to uppercase",
        Justification = "BCP-47 language subtags are conventionally lowercase.")]
    private static string? NormalizeLocale(string? locale)
    {
        if (locale is not { Length: > 0 })
        {
            return null;
        }

        var parts = locale.Replace('_', '-').Split('-', StringSplitOptions.RemoveEmptyEntries);
        return parts.Length switch
        {
            0 => null,
            1 => parts[0].ToLowerInvariant(),
            _ => $"{parts[0].ToLowerInvariant()}-{parts[1].ToUpperInvariant()}",
        };
    }

    private static void ApplyLocaleAndVoiceControls(TTSRequest request, TextToSpeechOptions? options)
    {
        var locale = options.GetString(CartesiaTextToSpeechPropertyNames.Locale) ?? options?.Language;
        if (locale is { Length: > 0 })
        {
            request.Locale = NormalizeLocale(locale);
            request.Language = null;
        }

        request.Accent ??= options.GetString(CartesiaTextToSpeechPropertyNames.Accent);
        request.Normalization ??= options.GetString(CartesiaTextToSpeechPropertyNames.Normalization);
        EnsureLanguageAndLocaleAreExclusive(request.Language, request.Locale, options);
    }

    private static void ApplyLocaleAndVoiceControls(TTSSSERequest request, TextToSpeechOptions? options)
    {
        var locale = options.GetString(CartesiaTextToSpeechPropertyNames.Locale) ?? options?.Language;
        if (locale is { Length: > 0 })
        {
            request.Locale = NormalizeLocale(locale);
            request.Language = null;
        }

        request.Accent ??= options.GetString(CartesiaTextToSpeechPropertyNames.Accent);
        request.Normalization ??= options.GetString(CartesiaTextToSpeechPropertyNames.Normalization);
        EnsureLanguageAndLocaleAreExclusive(request.Language, request.Locale, options);
    }

    private static void EnsureLanguageAndLocaleAreExclusive(
        string? language,
        string? locale,
        TextToSpeechOptions? options)
    {
        if (language is { Length: > 0 } && locale is { Length: > 0 })
        {
            throw new ArgumentException("Cartesia TTS accepts either language or locale, never both.", nameof(options));
        }
    }

    private static string GetVoiceId(TTSRequestVoiceSpecifier voice)
    {
        if (voice.TryPickTTSRequestVoiceId(out var voiceId))
        {
            return voiceId;
        }

        return voice.PickTTSRequestVoiceObject().Id;
    }

    private static GenerationConfig? CreateGenerationConfig(
        TextToSpeechOptions? options,
        GenerationConfig? generationConfig)
    {
        if (options is null)
        {
            return generationConfig;
        }

        generationConfig ??= new GenerationConfig();
        generationConfig.Speed ??= options.Speed;
        generationConfig.Volume ??= options.Volume;

        if (generationConfig.Emotion is null
            && options.GetString(CartesiaTextToSpeechPropertyNames.Emotion) is { } emotion)
        {
            generationConfig.Emotion = EmotionExtensions.ToEnum(emotion)
                ?? throw new ArgumentException($"Unknown Cartesia TTS emotion '{emotion}'.", nameof(options));
        }

        return generationConfig.Speed is null
            && generationConfig.Volume is null
            && generationConfig.Emotion is null
            && generationConfig.AdditionalProperties.Count == 0
                ? null
                : generationConfig;
    }

    private static OutputFormat CreateOutputFormat(TextToSpeechOptions? options)
    {
        var sampleRate = options.GetInt(CartesiaTextToSpeechPropertyNames.SampleRate) ?? DefaultSampleRate;
        var format = NormalizeAudioFormat(options?.AudioFormat);

        return format switch
        {
            "mp3" => new MP3OutputFormat
            {
                SampleRate = sampleRate,
                BitRate = options.GetInt(CartesiaTextToSpeechPropertyNames.BitRate) ?? DefaultBitRate,
            },
            "wav" => new WAVOutputFormat
            {
                Encoding = RawEncoding.PcmS16le,
                SampleRate = sampleRate,
            },
            "raw" or "pcm_s16le" => new RawOutputFormat
            {
                Encoding = RawEncoding.PcmS16le,
                SampleRate = sampleRate,
            },
            _ => throw new NotSupportedException($"Unsupported Cartesia TTS audio format '{options?.AudioFormat}'. Use 'mp3', 'wav', or 'pcm_s16le'."),
        };
    }

    private static SSEOutputFormat CreateSseOutputFormat(TextToSpeechOptions? options)
    {
        var sampleRate = options.GetInt(CartesiaTextToSpeechPropertyNames.SampleRate) ?? DefaultSampleRate;
        var format = NormalizeAudioFormat(options?.AudioFormat);
        if (format is not ("raw" or "pcm_s16le"))
        {
            throw new NotSupportedException("Cartesia TTS streaming uses raw PCM audio. Set TextToSpeechOptions.AudioFormat to 'pcm_s16le' or leave it unset.");
        }

        return new SSEOutputFormat
        {
            Container = SSEOutputFormatContainer.Raw,
            Encoding = RawEncoding.PcmS16le,
            SampleRate = sampleRate,
        };
    }

    private static string NormalizeAudioFormat(string? audioFormat)
    {
        if (audioFormat is not { Length: > 0 })
        {
            return "pcm_s16le";
        }

        if (string.Equals(audioFormat, "audio/mpeg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(audioFormat, "audio/mp3", StringComparison.OrdinalIgnoreCase)
            || string.Equals(audioFormat, "mpeg", StringComparison.OrdinalIgnoreCase))
        {
            return "mp3";
        }

        if (string.Equals(audioFormat, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(audioFormat, "audio/wave", StringComparison.OrdinalIgnoreCase)
            || string.Equals(audioFormat, "wave", StringComparison.OrdinalIgnoreCase))
        {
            return "wav";
        }

        if (string.Equals(audioFormat, "audio/pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(audioFormat, "pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(audioFormat, "s16le", StringComparison.OrdinalIgnoreCase))
        {
            return "pcm_s16le";
        }

        return audioFormat switch
        {
            "mp3" or "wav" or "raw" or "pcm_s16le" => audioFormat,
            var value => value,
        };
    }

    private static string GetMediaType(OutputFormat outputFormat)
    {
        if (outputFormat.TryPickMP3OutputFormat(out _))
        {
            return "audio/mpeg";
        }

        if (outputFormat.TryPickWAVOutputFormat(out _))
        {
            return "audio/wav";
        }

        var raw = outputFormat.PickRawOutputFormat();
        return GetRawMediaType(raw.Encoding, raw.SampleRate);
    }

    private static string GetMediaType(SSEOutputFormat outputFormat) =>
        GetRawMediaType(outputFormat.Encoding, outputFormat.SampleRate);

    private static string GetRawMediaType(RawEncoding encoding, int sampleRate) =>
        encoding switch
        {
            RawEncoding.PcmS16le => $"audio/pcm;codec=s16le;rate={sampleRate};channels=1",
            RawEncoding.PcmF32le => $"audio/pcm;codec=f32le;rate={sampleRate};channels=1",
            RawEncoding.PcmMulaw => $"audio/basic;rate={sampleRate};channels=1",
            RawEncoding.PcmAlaw => $"audio/pcma;rate={sampleRate};channels=1",
            _ => $"application/octet-stream;rate={sampleRate}",
        };

    private static AdditionalPropertiesDictionary CreateResponseProperties(
        string modelId,
        string voiceId,
        string? language,
        string mediaType,
        string? contextId = null,
        int? statusCode = null,
        double? stepTime = null)
    {
        AdditionalPropertiesDictionary properties = new()
        {
            ["model_id"] = modelId,
            ["voice_id"] = voiceId,
            ["media_type"] = mediaType,
        };

        if (language is { Length: > 0 })
        {
            properties["language"] = language;
        }

        if (contextId is { Length: > 0 })
        {
            properties[CartesiaTextToSpeechPropertyNames.ContextId] = contextId;
        }

        if (statusCode is not null)
        {
            properties[CartesiaTextToSpeechPropertyNames.StatusCode] = statusCode.Value;
        }

        if (stepTime is not null)
        {
            properties[CartesiaTextToSpeechPropertyNames.StepTime] = stepTime.Value;
        }

        return properties;
    }
}

internal static class CartesiaTextToSpeechOptionsExtensions
{
    public static bool? GetBool(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            bool boolValue => boolValue,
            string text when bool.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static int? GetInt(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            int intValue => intValue,
            long longValue when longValue is >= int.MinValue and <= int.MaxValue => (int)longValue,
            string text when int.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static string? GetString(this TextToSpeechOptions? options, string key)
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
            && value is string text
            && text.Length > 0
                ? text
                : null;
    }
}
