#nullable enable

namespace Cartesia
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Agent Usage<br/>
        /// Returns your agent usage over time, bucketed by the requested interval.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="startTs">
        /// Example: 2026-03-01T00:00:00Z
        /// </param>
        /// <param name="endTs">
        /// Example: 2026-03-08T00:00:00Z
        /// </param>
        /// <param name="interval">
        /// Groups usage data into buckets according to time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.UsageAgentsResponse> UsageAgentsAsync(
            global::Cartesia.UsageAgentsCartesiaVersion cartesiaVersion = global::Cartesia.UsageAgentsCartesiaVersion.x20260814,
            global::System.DateTime? startTs = default,
            global::System.DateTime? endTs = default,
            global::Cartesia.UsageInterval? interval = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Usage<br/>
        /// Returns your agent usage over time, bucketed by the requested interval.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="startTs">
        /// Example: 2026-03-01T00:00:00Z
        /// </param>
        /// <param name="endTs">
        /// Example: 2026-03-08T00:00:00Z
        /// </param>
        /// <param name="interval">
        /// Groups usage data into buckets according to time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.UsageAgentsResponse>> UsageAgentsAsResponseAsync(
            global::Cartesia.UsageAgentsCartesiaVersion cartesiaVersion = global::Cartesia.UsageAgentsCartesiaVersion.x20260814,
            global::System.DateTime? startTs = default,
            global::System.DateTime? endTs = default,
            global::Cartesia.UsageInterval? interval = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}