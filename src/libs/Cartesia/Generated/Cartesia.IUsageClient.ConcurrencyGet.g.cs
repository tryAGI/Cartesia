#nullable enable

namespace Cartesia
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Concurrency<br/>
        /// Returns how many TTS, STT and agent sessions you have open right now, each with the limit it counts against. Readings are shared for up to 10 seconds. For peaks over time, see Get Concurrency History.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ConcurrencyResponse> ConcurrencyGetAsync(
            global::Cartesia.ConcurrencyGetCartesiaVersion cartesiaVersion = global::Cartesia.ConcurrencyGetCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Concurrency<br/>
        /// Returns how many TTS, STT and agent sessions you have open right now, each with the limit it counts against. Readings are shared for up to 10 seconds. For peaks over time, see Get Concurrency History.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ConcurrencyResponse>> ConcurrencyGetAsResponseAsync(
            global::Cartesia.ConcurrencyGetCartesiaVersion cartesiaVersion = global::Cartesia.ConcurrencyGetCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}