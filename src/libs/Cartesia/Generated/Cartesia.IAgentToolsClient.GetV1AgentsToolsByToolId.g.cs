#nullable enable

namespace Cartesia
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Get a tool<br/>
        /// Returns one shared tool. Expand `agents` to include agents that currently reference it.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="expand"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ManagedToolV1> GetV1AgentsToolsByToolIdAsync(
            string toolId,
            global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? expand = default,
            global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a tool<br/>
        /// Returns one shared tool. Expand `agents` to include agents that currently reference it.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="expand"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ManagedToolV1>> GetV1AgentsToolsByToolIdAsResponseAsync(
            string toolId,
            global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? expand = default,
            global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}