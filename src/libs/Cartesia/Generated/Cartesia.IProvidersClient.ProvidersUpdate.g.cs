#nullable enable

namespace Cartesia
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Update Provider<br/>
        /// Update a provider. To ensure assigned numbers are reachable, Twilio credentials are validated before saving. If the new credentials are invalid, the request fails and returns a list of unreachable numbers currently assigned to agents. For SIP trunks, omitted fields remain unchanged. Set `credentials` or `destination_country` to `null` to clear that field. Send `[]` to clear an inbound allowlist.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ProviderAccountResponse> ProvidersUpdateAsync(
            string id,

            global::Cartesia.UpdateProviderBody request,
            global::Cartesia.ProvidersUpdateCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Provider<br/>
        /// Update a provider. To ensure assigned numbers are reachable, Twilio credentials are validated before saving. If the new credentials are invalid, the request fails and returns a list of unreachable numbers currently assigned to agents. For SIP trunks, omitted fields remain unchanged. Set `credentials` or `destination_country` to `null` to clear that field. Send `[]` to clear an inbound allowlist.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ProviderAccountResponse>> ProvidersUpdateAsResponseAsync(
            string id,

            global::Cartesia.UpdateProviderBody request,
            global::Cartesia.ProvidersUpdateCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Provider<br/>
        /// Update a provider. To ensure assigned numbers are reachable, Twilio credentials are validated before saving. If the new credentials are invalid, the request fails and returns a list of unreachable numbers currently assigned to agents. For SIP trunks, omitted fields remain unchanged. Set `credentials` or `destination_country` to `null` to clear that field. Send `[]` to clear an inbound allowlist.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ProviderAccountResponse> ProvidersUpdateAsync(
            string id,
            global::Cartesia.ProvidersUpdateCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}