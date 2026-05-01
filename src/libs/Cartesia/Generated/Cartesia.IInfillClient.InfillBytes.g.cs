#nullable enable

namespace Cartesia
{
    public partial interface IInfillClient
    {
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Infill (Bytes).<br/>
        /// Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.<br/>
        /// **The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:<br/>
        /// - Use longer infill transcripts<br/>
        ///   - This gives the model more flexibility to adapt to the rest of the audio<br/>
        /// - Target natural pauses in the audio when deciding where to clip<br/>
        ///   - This means you don't need word-level timestamps to be as precise<br/>
        /// - Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible<br/>
        ///   - This helps the model generate more natural transitions
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion,

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Infill (Bytes).<br/>
        /// Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.<br/>
        /// **The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:<br/>
        /// - Use longer infill transcripts<br/>
        ///   - This gives the model more flexibility to adapt to the rest of the audio<br/>
        /// - Target natural pauses in the audio when deciding where to clip<br/>
        ///   - This means you don't need word-level timestamps to be as precise<br/>
        /// - Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible<br/>
        ///   - This helps the model generate more natural transitions
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="leftAudio"></param>
        /// <param name="leftAudioname"></param>
        /// <param name="rightAudio"></param>
        /// <param name="rightAudioname"></param>
        /// <param name="modelId">
        /// The ID of the model to use for generating audio. Any model other than the first `"sonic"` model is supported.
        /// </param>
        /// <param name="language">
        /// The language of the transcript
        /// </param>
        /// <param name="transcript">
        /// The infill text to generate
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to use for generating audio
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion,
            byte[]? leftAudio = default,
            string? leftAudioname = default,
            byte[]? rightAudio = default,
            string? rightAudioname = default,
            string? modelId = default,
            string? language = default,
            string? transcript = default,
            string? voiceId = default,
            global::Cartesia.OutputFormat? outputFormat = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}