#nullable enable

using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

namespace Cartesia;

public sealed partial class CartesiaClient : ISpeechToTextClient
{
    private const SttTranscribeCartesiaVersion DefaultSttVersion = SttTranscribeCartesiaVersion.x20250416;

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

        var request = options?.RawRepresentationFactory?.Invoke(this) as SttTranscribeRequest
            ?? new SttTranscribeRequest();

        if (request.File is null)
        {
            MemoryStream? ms = audioSpeechStream as MemoryStream;
            if (ms is null || ms.Position != 0)
            {
                ms = new MemoryStream();
                await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
            }

            request.File = ms.TryGetBuffer(out ArraySegment<byte> buffer)
                && buffer.Array is not null && buffer.Offset == 0 && buffer.Count == ms.Length
                    ? buffer.Array
                    : ms.ToArray();
        }

        // Map MEAI options
        if (options?.SpeechLanguage is { Length: > 0 } language
            && SttTranscribeRequestLanguageExtensions.ToEnum(language) is { } languageCode)
        {
            request.Language ??= languageCode;
        }

        request.Model ??= options?.ModelId;

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
            ModelId = request.Model,
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
}
