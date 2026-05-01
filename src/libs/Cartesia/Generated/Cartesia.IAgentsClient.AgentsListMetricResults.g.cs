#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Metric Results<br/>
        /// Paginated list of metric results. Filter results using the query parameters,
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="callId"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ListMetricResultsResponse> AgentsListMetricResultsAsync(
            global::Cartesia.AgentsListMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? callId = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}