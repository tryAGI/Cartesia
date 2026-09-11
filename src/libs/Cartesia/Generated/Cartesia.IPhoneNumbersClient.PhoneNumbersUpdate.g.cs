#nullable enable

namespace Cartesia
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's label, agent assignment, or provider
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
        global::System.Threading.Tasks.Task<global::Cartesia.PhoneNumberResponse> PhoneNumbersUpdateAsync(
            string id,

            global::Cartesia.UpdatePhoneNumberBody request,
            global::Cartesia.PhoneNumbersUpdateCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's label, agent assignment, or provider
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
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PhoneNumberResponse>> PhoneNumbersUpdateAsResponseAsync(
            string id,

            global::Cartesia.UpdatePhoneNumberBody request,
            global::Cartesia.PhoneNumbersUpdateCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's label, agent assignment, or provider
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="label">
        /// A new human-readable name.
        /// </param>
        /// <param name="agentId">
        /// Assign an agent to answer inbound calls to this number, or `null` to unassign.
        /// </param>
        /// <param name="provider">
        /// Change the provider. Pass `{ "id": "..." }` for an existing provider, or pass Twilio account fields for lookup convenience. For Twilio, the phone number must exist in the target provider account. For SIP trunk providers, Cartesia handles reassignment between SIP providers. Switching between provider types is not supported; delete and re-import the number instead.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PhoneNumberResponse> PhoneNumbersUpdateAsync(
            string id,
            global::Cartesia.PhoneNumbersUpdateCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersUpdateCartesiaVersion.x20260814,
            string? label = default,
            string? agentId = default,
            global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? provider = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}