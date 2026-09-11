#nullable enable

namespace Cartesia
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List Users<br/>
        /// Lists users in the organization, ordered by when they joined (newest first)
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetOrganizationsUsersResponse> GetOrganizationsUsersAsync(
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            global::Cartesia.GetOrganizationsUsersCartesiaVersion cartesiaVersion = global::Cartesia.GetOrganizationsUsersCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Users<br/>
        /// Lists users in the organization, ordered by when they joined (newest first)
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.GetOrganizationsUsersResponse>> GetOrganizationsUsersAsResponseAsync(
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            global::Cartesia.GetOrganizationsUsersCartesiaVersion cartesiaVersion = global::Cartesia.GetOrganizationsUsersCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}