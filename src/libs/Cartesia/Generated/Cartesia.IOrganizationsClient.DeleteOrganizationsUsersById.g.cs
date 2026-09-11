#nullable enable

namespace Cartesia
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove User<br/>
        /// Removes a non-admin user from the organization without deleting their account
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOrganizationsUsersByIdAsync(
            string id,
            global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove User<br/>
        /// Removes a non-admin user from the organization without deleting their account
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse> DeleteOrganizationsUsersByIdAsResponseAsync(
            string id,
            global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion cartesiaVersion = global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}