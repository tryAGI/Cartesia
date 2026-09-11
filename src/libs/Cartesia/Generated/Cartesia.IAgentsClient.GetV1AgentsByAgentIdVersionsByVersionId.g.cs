#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get an agent version<br/>
        /// Returns one immutable configuration snapshot. To restore it, pass its `config` to `PATCH /v1/agents/{agent_id}`. Restoring creates a new version and does not change existing history.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="versionId">
        /// Unique identifier for an immutable agent configuration version.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedAgentVersionV1> GetV1AgentsByAgentIdVersionsByVersionIdAsync(
            string agentId,
            string versionId,
            global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent version<br/>
        /// Returns one immutable configuration snapshot. To restore it, pass its `config` to `PATCH /v1/agents/{agent_id}`. Restoring creates a new version and does not change existing history.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="versionId">
        /// Unique identifier for an immutable agent configuration version.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedAgentVersionV1>> GetV1AgentsByAgentIdVersionsByVersionIdAsResponseAsync(
            string agentId,
            string versionId,
            global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}