#nullable enable

using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Cartesia;

/// <summary>
/// Convenience helpers for consuming Cartesia text-to-speech SSE streams.
/// </summary>
public static class CartesiaTtsSseExtensions
{
    /// <summary>
    /// Default Cartesia API version for text-to-speech SSE endpoints.
    /// </summary>
    public const TtsSseCartesiaVersion DefaultTtsSseCartesiaVersion = TtsSseCartesiaVersion.x20251104;

    /// <summary>
    /// Streams text-to-speech SSE events and decodes audio chunks as they arrive.
    /// </summary>
    /// <param name="client">The Cartesia client.</param>
    /// <param name="request">The TTS SSE request.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public static IAsyncEnumerable<CartesiaTtsSseEvent> StreamTtsSseAsync(
        this ICartesiaClient client,
        TTSSSERequest request,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        return client.Tts.StreamTtsSseAsync(
            request,
            requestOptions,
            cancellationToken);
    }

    /// <summary>
    /// Streams text-to-speech SSE events and decodes audio chunks as they arrive.
    /// </summary>
    /// <param name="client">The Cartesia client.</param>
    /// <param name="cartesiaVersion">The Cartesia API version.</param>
    /// <param name="request">The TTS SSE request.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public static IAsyncEnumerable<CartesiaTtsSseEvent> StreamTtsSseAsync(
        this ICartesiaClient client,
        TtsSseCartesiaVersion cartesiaVersion,
        TTSSSERequest request,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        return client.Tts.StreamTtsSseAsync(
            cartesiaVersion,
            request,
            requestOptions,
            cancellationToken);
    }

    /// <summary>
    /// Streams text-to-speech SSE events and decodes audio chunks as they arrive.
    /// </summary>
    /// <param name="client">The TTS client.</param>
    /// <param name="request">The TTS SSE request.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public static IAsyncEnumerable<CartesiaTtsSseEvent> StreamTtsSseAsync(
        this ITtsClient client,
        TTSSSERequest request,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        return StreamTtsSseAsync(
            client,
            DefaultTtsSseCartesiaVersion,
            request,
            requestOptions,
            cancellationToken);
    }

    /// <summary>
    /// Streams text-to-speech SSE events and decodes audio chunks as they arrive.
    /// </summary>
    /// <param name="client">The TTS client.</param>
    /// <param name="cartesiaVersion">The Cartesia API version.</param>
    /// <param name="request">The TTS SSE request.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public static async IAsyncEnumerable<CartesiaTtsSseEvent> StreamTtsSseAsync(
        this ITtsClient client,
        TtsSseCartesiaVersion cartesiaVersion,
        TTSSSERequest request,
        AutoSDKRequestOptions? requestOptions = default,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(request);

        await foreach (var @event in client.TtsSseAsync(
            cartesiaVersion,
            request,
            requestOptions,
            cancellationToken).ConfigureAwait(false))
        {
            yield return CartesiaTtsSseEvent.FromEvent(@event);
        }
    }
}

/// <summary>
/// A normalized Cartesia text-to-speech SSE event with decoded audio bytes for chunk events.
/// </summary>
public sealed class CartesiaTtsSseEvent
{
    /// <summary>
    /// The generated SDK event returned by the underlying SSE parser.
    /// </summary>
    public required TTSSSEEvent RawEvent { get; init; }

    /// <summary>
    /// The Cartesia SSE event type.
    /// </summary>
    public required TTSSSEEventDiscriminatorType Type { get; init; }

    /// <summary>
    /// Decoded audio bytes for chunk events; otherwise empty.
    /// </summary>
    public ReadOnlyMemory<byte> Audio { get; init; }

    /// <summary>
    /// The generated chunk event when <see cref="Type"/> is <see cref="TTSSSEEventDiscriminatorType.Chunk"/>.
    /// </summary>
    public TTSSSEChunkEvent? Chunk { get; init; }

    /// <summary>
    /// The generated word timestamp event when <see cref="Type"/> is <see cref="TTSSSEEventDiscriminatorType.Timestamps"/>.
    /// </summary>
    public TTSSSETimestampsEvent? Timestamps { get; init; }

    /// <summary>
    /// The generated phoneme timestamp event when <see cref="Type"/> is <see cref="TTSSSEEventDiscriminatorType.PhonemeTimestamps"/>.
    /// </summary>
    public TTSSSEPhonemeTimestampsEvent? PhonemeTimestamps { get; init; }

    /// <summary>
    /// The generated done event when <see cref="Type"/> is <see cref="TTSSSEEventDiscriminatorType.Done"/>.
    /// </summary>
    public TTSSSEDoneEvent? Done { get; init; }

    /// <summary>
    /// The generated error event when <see cref="Type"/> is <see cref="TTSSSEEventDiscriminatorType.Error"/>.
    /// </summary>
    public TTSSSEErrorEvent? Error { get; init; }

    /// <summary>
    /// The Cartesia context identifier when present.
    /// </summary>
    public string? ContextId { get; init; }

    /// <summary>
    /// The event status code when present.
    /// </summary>
    public int? StatusCode { get; init; }

    /// <summary>
    /// Server-side processing time for chunk events, in milliseconds.
    /// </summary>
    public double? StepTime { get; init; }

    /// <summary>
    /// The time this event was materialized by the SDK.
    /// </summary>
    public DateTimeOffset ReceivedAt { get; init; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Whether this event carries decoded audio bytes.
    /// </summary>
    public bool IsAudioChunk => Chunk is not null;

    /// <summary>
    /// Whether this event is the terminal done event.
    /// </summary>
    public bool IsDone => Done is not null;

    /// <summary>
    /// Whether this event is a provider error event.
    /// </summary>
    public bool IsError => Error is not null;

    internal static CartesiaTtsSseEvent FromEvent(TTSSSEEvent @event)
    {
        var receivedAt = DateTimeOffset.UtcNow;

        if (@event.TryPickChunk(out var chunk))
        {
            return new CartesiaTtsSseEvent
            {
                RawEvent = @event,
                Type = TTSSSEEventDiscriminatorType.Chunk,
                Audio = Convert.FromBase64String(chunk.Data),
                Chunk = chunk,
                ContextId = chunk.ContextId ?? GetString(chunk.AdditionalProperties, "context_id"),
                StatusCode = chunk.StatusCode,
                StepTime = chunk.StepTime,
                ReceivedAt = receivedAt,
            };
        }

        if (@event.TryPickTimestamps(out var timestamps))
        {
            return new CartesiaTtsSseEvent
            {
                RawEvent = @event,
                Type = TTSSSEEventDiscriminatorType.Timestamps,
                Timestamps = timestamps,
                ContextId = timestamps.ContextId ?? GetString(timestamps.AdditionalProperties, "context_id"),
                StatusCode = timestamps.StatusCode,
                ReceivedAt = receivedAt,
            };
        }

        if (@event.TryPickPhonemeTimestamps(out var phonemeTimestamps))
        {
            return new CartesiaTtsSseEvent
            {
                RawEvent = @event,
                Type = TTSSSEEventDiscriminatorType.PhonemeTimestamps,
                PhonemeTimestamps = phonemeTimestamps,
                ContextId = phonemeTimestamps.ContextId ?? GetString(phonemeTimestamps.AdditionalProperties, "context_id"),
                StatusCode = phonemeTimestamps.StatusCode,
                ReceivedAt = receivedAt,
            };
        }

        if (@event.TryPickDone(out var done))
        {
            return new CartesiaTtsSseEvent
            {
                RawEvent = @event,
                Type = TTSSSEEventDiscriminatorType.Done,
                Done = done,
                ContextId = done.ContextId ?? GetString(done.AdditionalProperties, "context_id"),
                StatusCode = done.StatusCode,
                ReceivedAt = receivedAt,
            };
        }

        if (@event.TryPickError(out var error))
        {
            return new CartesiaTtsSseEvent
            {
                RawEvent = @event,
                Type = TTSSSEEventDiscriminatorType.Error,
                Error = error,
                ContextId = GetString(error.AdditionalProperties, "context_id"),
                StatusCode = error.StatusCode,
                ReceivedAt = receivedAt,
            };
        }

        throw new InvalidOperationException($"Unknown Cartesia TTS SSE event: {@event}");
    }

    private static string? GetString(IDictionary<string, object> additionalProperties, string name)
    {
        if (!additionalProperties.TryGetValue(name, out var value))
        {
            return null;
        }

        return value switch
        {
            string text => text,
            JsonElement { ValueKind: JsonValueKind.String } json => json.GetString(),
            JsonElement { ValueKind: JsonValueKind.Number } json => json.ToString(),
            _ => value.ToString(),
        };
    }
}
