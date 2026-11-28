#nullable enable

namespace Cartesia
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Get Phone Number Provisioning Usage<br/>
        /// Returns Cartesia-managed phone number provisioning usage for the current month. Active numbers and numbers deleted during the current month count toward usage.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PhoneNumberProvisioningUsageResponse> PhoneNumbersProvisioningUsageAsync(
            global::Cartesia.PhoneNumbersProvisioningUsageCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersProvisioningUsageCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Phone Number Provisioning Usage<br/>
        /// Returns Cartesia-managed phone number provisioning usage for the current month. Active numbers and numbers deleted during the current month count toward usage.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PhoneNumberProvisioningUsageResponse>> PhoneNumbersProvisioningUsageAsResponseAsync(
            global::Cartesia.PhoneNumbersProvisioningUsageCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersProvisioningUsageCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}