#nullable enable

namespace Cartesia
{
    public partial interface IWatermarkingClient
    {
        /// <summary>
        /// Detect watermark<br/>
        /// Check audio for a Cartesia watermark. Requires a paid plan.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.DetectWatermarkResponse> DetectWatermarkAsync(

            global::Cartesia.DetectWatermarkRequest request,
            global::Cartesia.DetectWatermarkCartesiaVersion cartesiaVersion = global::Cartesia.DetectWatermarkCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Check audio for a Cartesia watermark. Requires a paid plan.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.DetectWatermarkResponse>> DetectWatermarkAsResponseAsync(

            global::Cartesia.DetectWatermarkRequest request,
            global::Cartesia.DetectWatermarkCartesiaVersion cartesiaVersion = global::Cartesia.DetectWatermarkCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Check audio for a Cartesia watermark. Requires a paid plan.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="file">
        /// Audio file to check, between 5 seconds and 5 minutes long, up to 32 MiB. Supported formats are FLAC, M4A, MP3, MP4, MPEG, MPGA, OGA, OGG, WAV, and WebM.
        /// </param>
        /// <param name="filename">
        /// Audio file to check, between 5 seconds and 5 minutes long, up to 32 MiB. Supported formats are FLAC, M4A, MP3, MP4, MPEG, MPGA, OGA, OGG, WAV, and WebM.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.DetectWatermarkResponse> DetectWatermarkAsync(
            byte[] file,
            string filename,
            global::Cartesia.DetectWatermarkCartesiaVersion cartesiaVersion = global::Cartesia.DetectWatermarkCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Detect watermark<br/>
        /// Check audio for a Cartesia watermark. Requires a paid plan.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="file">
        /// Audio file to check, between 5 seconds and 5 minutes long, up to 32 MiB. Supported formats are FLAC, M4A, MP3, MP4, MPEG, MPGA, OGA, OGG, WAV, and WebM.
        /// </param>
        /// <param name="filename">
        /// Audio file to check, between 5 seconds and 5 minutes long, up to 32 MiB. Supported formats are FLAC, M4A, MP3, MP4, MPEG, MPGA, OGA, OGG, WAV, and WebM.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.DetectWatermarkResponse> DetectWatermarkAsync(
            global::System.IO.Stream file,
            string filename,
            global::Cartesia.DetectWatermarkCartesiaVersion cartesiaVersion = global::Cartesia.DetectWatermarkCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Check audio for a Cartesia watermark. Requires a paid plan.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="file">
        /// Audio file to check, between 5 seconds and 5 minutes long, up to 32 MiB. Supported formats are FLAC, M4A, MP3, MP4, MPEG, MPGA, OGA, OGG, WAV, and WebM.
        /// </param>
        /// <param name="filename">
        /// Audio file to check, between 5 seconds and 5 minutes long, up to 32 MiB. Supported formats are FLAC, M4A, MP3, MP4, MPEG, MPGA, OGA, OGG, WAV, and WebM.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.DetectWatermarkResponse>> DetectWatermarkAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Cartesia.DetectWatermarkCartesiaVersion cartesiaVersion = global::Cartesia.DetectWatermarkCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}