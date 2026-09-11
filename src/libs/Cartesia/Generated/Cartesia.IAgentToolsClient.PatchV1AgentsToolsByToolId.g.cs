#nullable enable

namespace Cartesia
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Update a tool<br/>
        /// Sparsely updates a tool.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedToolV1> PatchV1AgentsToolsByToolIdAsync(
            string toolId,

            global::Cartesia.UpdateManagedToolV1Request request,
            global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a tool<br/>
        /// Sparsely updates a tool.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedToolV1>> PatchV1AgentsToolsByToolIdAsResponseAsync(
            string toolId,

            global::Cartesia.UpdateManagedToolV1Request request,
            global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a tool<br/>
        /// Sparsely updates a tool.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedToolV1> PatchV1AgentsToolsByToolIdAsync(
            string toolId,
            global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}