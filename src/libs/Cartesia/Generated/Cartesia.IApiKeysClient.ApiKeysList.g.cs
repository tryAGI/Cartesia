#nullable enable

namespace Cartesia
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List API Keys<br/>
        /// Returns a paginated list of standard API keys owned by the authenticating organization. Only metadata is returned, not the keys themselves. Admin API keys are not included.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ListApiKeysResponse> ApiKeysListAsync(
            global::Cartesia.ApiKeysListCartesiaVersion cartesiaVersion = global::Cartesia.ApiKeysListCartesiaVersion.x20260814,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List API Keys<br/>
        /// Returns a paginated list of standard API keys owned by the authenticating organization. Only metadata is returned, not the keys themselves. Admin API keys are not included.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ListApiKeysResponse>> ApiKeysListAsResponseAsync(
            global::Cartesia.ApiKeysListCartesiaVersion cartesiaVersion = global::Cartesia.ApiKeysListCartesiaVersion.x20260814,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}