#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete an agent<br/>
        /// Deletes the agent. Future reads and new calls fail.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteV1AgentsByAgentIdAsync(
            string agentId,
            global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent<br/>
        /// Deletes the agent. Future reads and new calls fail.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse> DeleteV1AgentsByAgentIdAsResponseAsync(
            string agentId,
            global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}