#nullable enable

namespace Cartesia
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Credit Usage<br/>
        /// Returns your credit usage over time, bucketed by the requested interval.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="startTs">
        /// Example: 2026-01-01T00:00:00Z
        /// </param>
        /// <param name="endTs">
        /// Example: 2026-01-03T00:00:00Z
        /// </param>
        /// <param name="interval">
        /// Groups usage data into buckets according to time.
        /// </param>
        /// <param name="apiKeyId"></param>
        /// <param name="groupBy">
        /// Dimension to break credit usage down by.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.UsageCreditsResponse> UsageCreditsAsync(
            global::Cartesia.UsageCreditsCartesiaVersion cartesiaVersion = global::Cartesia.UsageCreditsCartesiaVersion.x20260814,
            global::System.DateTime? startTs = default,
            global::System.DateTime? endTs = default,
            global::Cartesia.UsageInterval? interval = default,
            global::System.Guid? apiKeyId = default,
            global::Cartesia.UsageCreditsGroupBy? groupBy = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Credit Usage<br/>
        /// Returns your credit usage over time, bucketed by the requested interval.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="startTs">
        /// Example: 2026-01-01T00:00:00Z
        /// </param>
        /// <param name="endTs">
        /// Example: 2026-01-03T00:00:00Z
        /// </param>
        /// <param name="interval">
        /// Groups usage data into buckets according to time.
        /// </param>
        /// <param name="apiKeyId"></param>
        /// <param name="groupBy">
        /// Dimension to break credit usage down by.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.UsageCreditsResponse>> UsageCreditsAsResponseAsync(
            global::Cartesia.UsageCreditsCartesiaVersion cartesiaVersion = global::Cartesia.UsageCreditsCartesiaVersion.x20260814,
            global::System.DateTime? startTs = default,
            global::System.DateTime? endTs = default,
            global::Cartesia.UsageInterval? interval = default,
            global::System.Guid? apiKeyId = default,
            global::Cartesia.UsageCreditsGroupBy? groupBy = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}