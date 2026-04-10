#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Calls<br/>
        /// Lists calls sorted by start time in descending order for a specific agent. `agent_id` is required and if you want to include `transcript` in the response, add `expand=transcript` to the request. This endpoint is paginated.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="expand"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetCallsResponse> AgentsListCallsAsync(
            global::Cartesia.AgentsListCallsCartesiaVersion cartesiaVersion,
            string agentId,
            string? expand = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}