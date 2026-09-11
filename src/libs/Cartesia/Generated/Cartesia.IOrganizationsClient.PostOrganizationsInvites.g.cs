#nullable enable

namespace Cartesia
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create Invites<br/>
        /// Invites email addresses to the organization as members. If any email is rejected, the whole request fails and no invites are created. Rate limited to 10 requests per hour.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>> PostOrganizationsInvitesAsync(

            global::Cartesia.CreateOrganizationInvitesRequest request,
            global::Cartesia.PostOrganizationsInvitesCartesiaVersion cartesiaVersion = global::Cartesia.PostOrganizationsInvitesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Invites<br/>
        /// Invites email addresses to the organization as members. If any email is rejected, the whole request fails and no invites are created. Rate limited to 10 requests per hour.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>>> PostOrganizationsInvitesAsResponseAsync(

            global::Cartesia.CreateOrganizationInvitesRequest request,
            global::Cartesia.PostOrganizationsInvitesCartesiaVersion cartesiaVersion = global::Cartesia.PostOrganizationsInvitesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Invites<br/>
        /// Invites email addresses to the organization as members. If any email is rejected, the whole request fails and no invites are created. Rate limited to 10 requests per hour.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="emails">
        /// Email addresses to invite, up to 10 per request. Each address receives a `member` invite.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>> PostOrganizationsInvitesAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::Cartesia.PostOrganizationsInvitesCartesiaVersion cartesiaVersion = global::Cartesia.PostOrganizationsInvitesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}