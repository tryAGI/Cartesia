#nullable enable

namespace Cartesia
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Provision Cartesia Number<br/>
        /// Provision a new Cartesia-managed US phone number
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ProvisionPhoneNumberResponse> PhoneNumbersProvisionAsync(

            global::Cartesia.ProvisionPhoneNumberBody request,
            global::Cartesia.PhoneNumbersProvisionCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersProvisionCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Provision Cartesia Number<br/>
        /// Provision a new Cartesia-managed US phone number
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ProvisionPhoneNumberResponse>> PhoneNumbersProvisionAsResponseAsync(

            global::Cartesia.ProvisionPhoneNumberBody request,
            global::Cartesia.PhoneNumbersProvisionCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersProvisionCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Provision Cartesia Number<br/>
        /// Provision a new Cartesia-managed US phone number
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="label">
        /// A human-readable name for the phone number.
        /// </param>
        /// <param name="agentId">
        /// Optionally assign an agent to answer inbound calls to this number. Omit to keep the number outbound-only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ProvisionPhoneNumberResponse> PhoneNumbersProvisionAsync(
            string label,
            global::Cartesia.PhoneNumbersProvisionCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersProvisionCartesiaVersion.x20260814,
            string? agentId = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}