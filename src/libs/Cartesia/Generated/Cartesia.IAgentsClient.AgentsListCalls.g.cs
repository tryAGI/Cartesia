#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Calls<br/>
        /// Lists an agent's calls, or the calls placed for one outbound call batch. One of `agent_id` or `batch_id` is required.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId">
        /// Example: agent_abc123
        /// </param>
        /// <param name="batchId">
        /// Example: acb_abc123
        /// </param>
        /// <param name="startTimeGte"></param>
        /// <param name="startTimeLte"></param>
        /// <param name="expand"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetCallsResponse> AgentsListCallsAsync(
            global::Cartesia.AgentsListCallsCartesiaVersion cartesiaVersion = global::Cartesia.AgentsListCallsCartesiaVersion.x20260814,
            string? agentId = default,
            string? batchId = default,
            global::System.DateTime? startTimeGte = default,
            global::System.DateTime? startTimeLte = default,
            string? expand = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Calls<br/>
        /// Lists an agent's calls, or the calls placed for one outbound call batch. One of `agent_id` or `batch_id` is required.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId">
        /// Example: agent_abc123
        /// </param>
        /// <param name="batchId">
        /// Example: acb_abc123
        /// </param>
        /// <param name="startTimeGte"></param>
        /// <param name="startTimeLte"></param>
        /// <param name="expand"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.GetCallsResponse>> AgentsListCallsAsResponseAsync(
            global::Cartesia.AgentsListCallsCartesiaVersion cartesiaVersion = global::Cartesia.AgentsListCallsCartesiaVersion.x20260814,
            string? agentId = default,
            string? batchId = default,
            global::System.DateTime? startTimeGte = default,
            global::System.DateTime? startTimeLte = default,
            string? expand = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}