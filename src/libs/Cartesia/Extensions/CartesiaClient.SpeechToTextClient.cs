#nullable enable

using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

namespace Cartesia;

public sealed partial class CartesiaClient : ISpeechToTextClient
{
    private const SttTranscribeCartesiaVersion DefaultSttVersion = SttTranscribeCartesiaVersion.x20251104;

    private SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_speechMetadata ??= new("cartesia", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        var request = options?.RawRepresentationFactory?.Invoke(this) as SttTranscribeRequest;
        if (request is null)
        {
            request = new SttTranscribeRequest
            {
                File = await ReadAudioBytesAsync(audioSpeechStream, cancellationToken).ConfigureAwait(false),
                Filename = "audio.wav",
                Model = ResolveSttBatchModel(options?.ModelId),
            };
        }

        if (request.File is null)
        {
            request.File = await ReadAudioBytesAsync(audioSpeechStream, cancellationToken).ConfigureAwait(false);
        }

        request.Filename ??= "audio.wav";

        // Map MEAI options
        if (options?.SpeechLanguage is { Length: > 0 } language
            && SttTranscribeRequestLanguageExtensions.ToEnum(language) is { } languageCode)
        {
            request.Language ??= languageCode;
        }

        if (options?.ModelId is { Length: > 0 } modelId)
        {
            request.Model = ResolveSttBatchModel(modelId);
        }

        // Request word-level timestamps for timing info
        request.TimestampGranularities ??= [TimestampGranularity.Word];

        var response = await Stt.SttTranscribeAsync(
            cartesiaVersion: DefaultSttVersion,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        TimeSpan? startTime = null;
        TimeSpan? endTime = null;
        if (response.Words is { Count: > 0 } words)
        {
            startTime = TimeSpan.FromSeconds(words[0].Start);
            endTime = TimeSpan.FromSeconds(words[^1].End);
        }
        else if (response.Duration is double duration)
        {
            startTime = TimeSpan.Zero;
            endTime = TimeSpan.FromSeconds(duration);
        }

        return new SpeechToTextResponse(response.Text)
        {
            RawRepresentation = response,
            ModelId = request.Model.ToValueString(),
            StartTime = startTime,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((ISpeechToTextClient)this)
            .GetTextAsync(audioSpeechStream, options, cancellationToken)
            .ConfigureAwait(false);

        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }

    private static async Task<byte[]> ReadAudioBytesAsync(
        Stream audioSpeechStream,
        CancellationToken cancellationToken)
    {
        MemoryStream? ms = audioSpeechStream as MemoryStream;
        if (ms is null || ms.Position != 0)
        {
            ms = new MemoryStream();
            await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
        }

        return ms.TryGetBuffer(out ArraySegment<byte> buffer)
            && buffer.Array is not null && buffer.Offset == 0 && buffer.Count == ms.Length
                ? buffer.Array
                : ms.ToArray();
    }

    private static STTBatchModel ResolveSttBatchModel(string? modelId)
    {
        if (modelId is not { Length: > 0 })
        {
            return STTBatchModel.InkWhisper;
        }

        return STTBatchModelExtensions.ToEnum(modelId)
            ?? throw new ArgumentException($"Unknown Cartesia STT model '{modelId}'.", nameof(modelId));
    }
}
