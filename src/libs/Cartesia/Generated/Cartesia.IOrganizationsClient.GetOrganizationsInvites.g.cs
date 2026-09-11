#nullable enable

namespace Cartesia
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List Invites<br/>
        /// Lists organization invites, filtered by status
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetOrganizationsInvitesResponse> GetOrganizationsInvitesAsync(
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.GetOrganizationsInvitesStatus? status = default,
            global::Cartesia.GetOrganizationsInvitesCartesiaVersion cartesiaVersion = global::Cartesia.GetOrganizationsInvitesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Invites<br/>
        /// Lists organization invites, filtered by status
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.GetOrganizationsInvitesResponse>> GetOrganizationsInvitesAsResponseAsync(
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.GetOrganizationsInvitesStatus? status = default,
            global::Cartesia.GetOrganizationsInvitesCartesiaVersion cartesiaVersion = global::Cartesia.GetOrganizationsInvitesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}