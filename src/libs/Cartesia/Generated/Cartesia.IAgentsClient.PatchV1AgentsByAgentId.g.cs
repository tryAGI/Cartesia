#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an agent<br/>
        /// Sparsely updates agent metadata or configuration. Configuration changes create a new immutable version.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedAgentV1> PatchV1AgentsByAgentIdAsync(
            string agentId,

            global::Cartesia.UpdateManagedAgentV1Request request,
            global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent<br/>
        /// Sparsely updates agent metadata or configuration. Configuration changes create a new immutable version.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedAgentV1>> PatchV1AgentsByAgentIdAsResponseAsync(
            string agentId,

            global::Cartesia.UpdateManagedAgentV1Request request,
            global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent<br/>
        /// Sparsely updates agent metadata or configuration. Configuration changes create a new immutable version.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="config"></param>
        /// <param name="description">
        /// Description of the agent.
        /// </param>
        /// <param name="name">
        /// Name shown for the agent. It does not need to be unique.
        /// </param>
        /// <param name="versionDescription">
        /// Description to attach to the new configuration version. Allowed only when this request changes `config`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedAgentV1> PatchV1AgentsByAgentIdAsync(
            string agentId,
            global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion cartesiaVersion = global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion.x20260814,
            global::Cartesia.UpdateManagedAgentV1RequestConfig? config = default,
            string? description = default,
            string? name = default,
            string? versionDescription = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}