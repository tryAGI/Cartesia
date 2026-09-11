#nullable enable

namespace Cartesia
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Create Provider<br/>
        /// Link a telephony provider account. For Twilio, credentials are validated before the provider is created. Each account SID + region combination can only be linked once. For SIP trunks, configure a trunk with an inbound and/or outbound configuration.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ProviderAccountResponse> ProvidersCreateAsync(

            global::Cartesia.CreateProviderBody request,
            global::Cartesia.ProvidersCreateCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Provider<br/>
        /// Link a telephony provider account. For Twilio, credentials are validated before the provider is created. Each account SID + region combination can only be linked once. For SIP trunks, configure a trunk with an inbound and/or outbound configuration.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ProviderAccountResponse>> ProvidersCreateAsResponseAsync(

            global::Cartesia.CreateProviderBody request,
            global::Cartesia.ProvidersCreateCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Provider<br/>
        /// Link a telephony provider account. For Twilio, credentials are validated before the provider is created. Each account SID + region combination can only be linked once. For SIP trunks, configure a trunk with an inbound and/or outbound configuration.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ProviderAccountResponse> ProvidersCreateAsync(
            global::Cartesia.ProvidersCreateCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}