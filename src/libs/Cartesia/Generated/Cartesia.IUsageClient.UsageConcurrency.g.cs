#nullable enable

namespace Cartesia
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Concurrency History<br/>
        /// Returns your peak concurrency in five-minute buckets.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="startTs">
        /// Example: 2026-11-09T17:00:00Z
        /// </param>
        /// <param name="endTs">
        /// Example: 2026-11-09T17:15:00Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.UsageConcurrencyHistoryResponse> UsageConcurrencyAsync(
            global::System.DateTime startTs,
            global::System.DateTime endTs,
            global::Cartesia.UsageConcurrencyCartesiaVersion cartesiaVersion = global::Cartesia.UsageConcurrencyCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Concurrency History<br/>
        /// Returns your peak concurrency in five-minute buckets.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="startTs">
        /// Example: 2026-11-09T17:00:00Z
        /// </param>
        /// <param name="endTs">
        /// Example: 2026-11-09T17:15:00Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.UsageConcurrencyHistoryResponse>> UsageConcurrencyAsResponseAsync(
            global::System.DateTime startTs,
            global::System.DateTime endTs,
            global::Cartesia.UsageConcurrencyCartesiaVersion cartesiaVersion = global::Cartesia.UsageConcurrencyCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}