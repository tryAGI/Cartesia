#nullable enable

namespace Cartesia
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Delete a tool<br/>
        /// Deletes an unused tool. Detach the tool from current agent configurations first.
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
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteV1AgentsToolsByToolIdAsync(
            string toolId,
            global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a tool<br/>
        /// Deletes an unused tool. Detach the tool from current agent configurations first.
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
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse> DeleteV1AgentsToolsByToolIdAsResponseAsync(
            string toolId,
            global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}