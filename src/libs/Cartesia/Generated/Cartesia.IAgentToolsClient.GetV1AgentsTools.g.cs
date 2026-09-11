#nullable enable

namespace Cartesia
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// List tools<br/>
        /// Returns shared webhook and client tools for your account
        /// </summary>
        /// <param name="startingAfter">
        /// A cursor for pagination. Pass the ID of the last item from the previous page to fetch the next page.
        /// </param>
        /// <param name="endingBefore">
        /// A cursor for pagination. Pass the ID of the first item from the previous page to fetch the previous page.
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return, ranging between 1 and 100.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="type">
        /// Return only tools of this type.
        /// </param>
        /// <param name="agentId">
        /// Return only tools used by this agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ListManagedToolsV1Response> GetV1AgentsToolsAsync(
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.GetV1AgentsToolsType? type = default,
            string? agentId = default,
            global::Cartesia.GetV1AgentsToolsCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsToolsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tools<br/>
        /// Returns shared webhook and client tools for your account
        /// </summary>
        /// <param name="startingAfter">
        /// A cursor for pagination. Pass the ID of the last item from the previous page to fetch the next page.
        /// </param>
        /// <param name="endingBefore">
        /// A cursor for pagination. Pass the ID of the first item from the previous page to fetch the previous page.
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return, ranging between 1 and 100.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="type">
        /// Return only tools of this type.
        /// </param>
        /// <param name="agentId">
        /// Return only tools used by this agent.
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ListManagedToolsV1Response>> GetV1AgentsToolsAsResponseAsync(
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.GetV1AgentsToolsType? type = default,
            string? agentId = default,
            global::Cartesia.GetV1AgentsToolsCartesiaVersion cartesiaVersion = global::Cartesia.GetV1AgentsToolsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}