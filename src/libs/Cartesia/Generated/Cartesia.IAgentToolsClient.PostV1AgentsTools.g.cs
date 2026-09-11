#nullable enable

namespace Cartesia
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Create a tool<br/>
        /// Creates a shared webhook or client tool that can be attached to agents
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedToolV1> PostV1AgentsToolsAsync(

            global::Cartesia.ManagedToolDefinitionV1 request,
            global::Cartesia.PostV1AgentsToolsCartesiaVersion cartesiaVersion = global::Cartesia.PostV1AgentsToolsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a tool<br/>
        /// Creates a shared webhook or client tool that can be attached to agents
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedToolV1>> PostV1AgentsToolsAsResponseAsync(

            global::Cartesia.ManagedToolDefinitionV1 request,
            global::Cartesia.PostV1AgentsToolsCartesiaVersion cartesiaVersion = global::Cartesia.PostV1AgentsToolsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a tool<br/>
        /// Creates a shared webhook or client tool that can be attached to agents
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedToolV1> PostV1AgentsToolsAsync(
            global::Cartesia.PostV1AgentsToolsCartesiaVersion cartesiaVersion = global::Cartesia.PostV1AgentsToolsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}