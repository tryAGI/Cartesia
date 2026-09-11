#nullable enable

namespace Cartesia
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// List Providers<br/>
        /// List telephony provider accounts linked to your account. Supports Twilio and SIP Trunk providers.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="type"></param>
        /// <param name="accountSid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>> ProvidersListAsync(
            global::Cartesia.ProvidersListCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersListCartesiaVersion.x20260814,
            global::Cartesia.ProvidersListType? type = default,
            string? accountSid = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Providers<br/>
        /// List telephony provider accounts linked to your account. Supports Twilio and SIP Trunk providers.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="type"></param>
        /// <param name="accountSid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>>> ProvidersListAsResponseAsync(
            global::Cartesia.ProvidersListCartesiaVersion cartesiaVersion = global::Cartesia.ProvidersListCartesiaVersion.x20260814,
            global::Cartesia.ProvidersListType? type = default,
            string? accountSid = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}