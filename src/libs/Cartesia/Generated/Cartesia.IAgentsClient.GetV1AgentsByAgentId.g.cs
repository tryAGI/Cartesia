#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get an agent<br/>
        /// Returns the published agent with its complete normalized configuration
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
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedAgentV1> GetV1AgentsByAgentIdAsync(
            string agentId,
            global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent<br/>
        /// Returns the published agent with its complete normalized configuration
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
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedAgentV1>> GetV1AgentsByAgentIdAsResponseAsync(
            string agentId,
            global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}