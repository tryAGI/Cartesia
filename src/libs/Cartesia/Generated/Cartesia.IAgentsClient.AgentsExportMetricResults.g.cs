#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Export Metric Results<br/>
        /// Exports metric results as a CSV file.<br/>
        /// By default, with no pagination parameters, the endpoint streams the entire matching result set as a single CSV. To page through results instead, pass `limit` and `starting_after` / `ending_before`. Paginated responses include the `X-Has-More` and `X-Next-Cursor` headers. Up to 100,000 rows can be exported per request in either mode; requests whose total matching set exceeds this cap return a `400` error.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="callId"></param>
        /// <param name="startDate">
        /// Example: 2024-04-01T00:00:00Z
        /// </param>
        /// <param name="endDate">
        /// Example: 2024-04-30T23:59:59Z
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AgentsExportMetricResultsAsync(
            global::Cartesia.AgentsExportMetricResultsCartesiaVersion cartesiaVersion = global::Cartesia.AgentsExportMetricResultsCartesiaVersion.x20260814,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            string? callId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Metric Results<br/>
        /// Exports metric results as a CSV file.<br/>
        /// By default, with no pagination parameters, the endpoint streams the entire matching result set as a single CSV. To page through results instead, pass `limit` and `starting_after` / `ending_before`. Paginated responses include the `X-Has-More` and `X-Next-Cursor` headers. Up to 100,000 rows can be exported per request in either mode; requests whose total matching set exceeds this cap return a `400` error.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="callId"></param>
        /// <param name="startDate">
        /// Example: 2024-04-01T00:00:00Z
        /// </param>
        /// <param name="endDate">
        /// Example: 2024-04-30T23:59:59Z
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> AgentsExportMetricResultsAsStreamAsync(
            global::Cartesia.AgentsExportMetricResultsCartesiaVersion cartesiaVersion = global::Cartesia.AgentsExportMetricResultsCartesiaVersion.x20260814,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            string? callId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Metric Results<br/>
        /// Exports metric results as a CSV file.<br/>
        /// By default, with no pagination parameters, the endpoint streams the entire matching result set as a single CSV. To page through results instead, pass `limit` and `starting_after` / `ending_before`. Paginated responses include the `X-Has-More` and `X-Next-Cursor` headers. Up to 100,000 rows can be exported per request in either mode; requests whose total matching set exceeds this cap return a `400` error.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="callId"></param>
        /// <param name="startDate">
        /// Example: 2024-04-01T00:00:00Z
        /// </param>
        /// <param name="endDate">
        /// Example: 2024-04-30T23:59:59Z
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<byte[]>> AgentsExportMetricResultsAsResponseAsync(
            global::Cartesia.AgentsExportMetricResultsCartesiaVersion cartesiaVersion = global::Cartesia.AgentsExportMetricResultsCartesiaVersion.x20260814,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            string? callId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}