#nullable enable

namespace Cartesia
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Cancel Invite<br/>
        /// Cancels a pending invite. If it has already been accepted, [remove the user](/api-reference/organizations/remove-user) instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOrganizationsInvitesByIdAsync(
            string id,
            global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Invite<br/>
        /// Cancels a pending invite. If it has already been accepted, [remove the user](/api-reference/organizations/remove-user) instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse> DeleteOrganizationsInvitesByIdAsResponseAsync(
            string id,
            global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}