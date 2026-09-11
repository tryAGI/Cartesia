#nullable enable

namespace Cartesia
{
    public partial interface IVoiceChangerClient
    {
        /// <summary>
        /// Voice Changer (SSE)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.VoiceChangerSSEEvent> VoiceChangerSseAsync(

            global::Cartesia.VoiceChangerSseRequest request,
            global::Cartesia.VoiceChangerSseCartesiaVersion cartesiaVersion = global::Cartesia.VoiceChangerSseCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice Changer (SSE)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="voiceId"></param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate"></param>
        /// <param name="outputFormatEncoding">
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.VoiceChangerSSEEvent> VoiceChangerSseAsync(
            global::Cartesia.VoiceChangerSseCartesiaVersion cartesiaVersion = global::Cartesia.VoiceChangerSseCartesiaVersion.x20260814,
            byte[]? clip = default,
            string? clipname = default,
            string? voiceId = default,
            global::Cartesia.OutputFormatContainer? outputFormatContainer = default,
            int? outputFormatSampleRate = default,
            global::Cartesia.RawEncoding? outputFormatEncoding = default,
            int? outputFormatBitRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}