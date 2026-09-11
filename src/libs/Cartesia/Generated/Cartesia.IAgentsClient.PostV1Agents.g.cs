#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent<br/>
        /// Creates an agent and its initial configuration version
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedAgentV1> PostV1AgentsAsync(

            global::Cartesia.CreateManagedAgentV1Request request,
            global::Cartesia.PostV1AgentsCartesiaVersion cartesiaVersion = global::Cartesia.PostV1AgentsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Creates an agent and its initial configuration version
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedAgentV1>> PostV1AgentsAsResponseAsync(

            global::Cartesia.CreateManagedAgentV1Request request,
            global::Cartesia.PostV1AgentsCartesiaVersion cartesiaVersion = global::Cartesia.PostV1AgentsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Creates an agent and its initial configuration version
        /// </summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedAgentV1> PostV1AgentsAsync(
            global::Cartesia.PostV1AgentsCartesiaVersion cartesiaVersion = global::Cartesia.PostV1AgentsCartesiaVersion.x20260814,
            global::Cartesia.CreateManagedAgentV1RequestConfig? config = default,
            string? description = default,
            string? name = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}