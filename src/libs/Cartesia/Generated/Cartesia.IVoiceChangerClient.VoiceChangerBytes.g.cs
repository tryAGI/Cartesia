#nullable enable

namespace Cartesia
{
    public partial interface IVoiceChangerClient
    {
        /// <summary>
        /// Voice Changer (Bytes)<br/>
        /// Voice Changer (Bytes).<br/>
        /// Takes an audio file of speech, and returns an audio file of speech spoken with the same intonation, but with a different voice.<br/>
        /// This endpoint is priced at 15 characters per second of input audio.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VoiceChangerBytesAsync(
            global::Cartesia.VoiceChangerBytesCartesiaVersion cartesiaVersion,

            global::Cartesia.VoiceChangerBytesRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice Changer (Bytes)<br/>
        /// Voice Changer (Bytes).<br/>
        /// Takes an audio file of speech, and returns an audio file of speech spoken with the same intonation, but with a different voice.<br/>
        /// This endpoint is priced at 15 characters per second of input audio.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="voiceId"></param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate"></param>
        /// <param name="outputFormatEncoding"></param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VoiceChangerBytesAsync(
            global::Cartesia.VoiceChangerBytesCartesiaVersion cartesiaVersion,
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