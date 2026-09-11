#nullable enable

namespace Cartesia
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Import Phone Number
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PhoneNumberResponse> PhoneNumbersImportAsync(

            global::Cartesia.ImportPhoneNumberBody request,
            global::Cartesia.PhoneNumbersImportCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersImportCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PhoneNumberResponse>> PhoneNumbersImportAsResponseAsync(

            global::Cartesia.ImportPhoneNumberBody request,
            global::Cartesia.PhoneNumbersImportCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersImportCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="label">
        /// A human-readable name for the phone number.
        /// </param>
        /// <param name="number">
        /// The phone number in E.164 format.
        /// </param>
        /// <param name="provider">
        /// Reference to the provider. Pass `{ "id": "..." }` for an existing provider, or `{ "type": "twilio", "account_sid": "...", "region": "..." }` to look up by account.
        /// </param>
        /// <param name="agentId">
        /// Optionally assign an agent to answer inbound calls to this number. Omit to keep the number outbound-only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PhoneNumberResponse> PhoneNumbersImportAsync(
            string label,
            string number,
            global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount> provider,
            global::Cartesia.PhoneNumbersImportCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersImportCartesiaVersion.x20260814,
            string? agentId = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}