#nullable enable

namespace Cartesia
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// List Phone Numbers
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="providerId"></param>
        /// <param name="type"></param>
        /// <param name="q"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        /// <remarks>
        /// curl -G "https://api.cartesia.ai/agents/phone-numbers" \<br/>
        ///   -H "Authorization: Bearer $CARTESIA_API_KEY" \<br/>
        ///   -H "Cartesia-Version: 2026-08-14" \<br/>
        ///   -d q="support" \<br/>
        ///   -d limit=10
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Cartesia.PhoneNumbersListResponse> PhoneNumbersListAsync(
            global::Cartesia.PhoneNumbersListCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersListCartesiaVersion.x20260814,
            string? agentId = default,
            string? providerId = default,
            global::Cartesia.PhoneNumbersListType? type = default,
            string? q = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Phone Numbers
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="providerId"></param>
        /// <param name="type"></param>
        /// <param name="q"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        /// <remarks>
        /// curl -G "https://api.cartesia.ai/agents/phone-numbers" \<br/>
        ///   -H "Authorization: Bearer $CARTESIA_API_KEY" \<br/>
        ///   -H "Cartesia-Version: 2026-08-14" \<br/>
        ///   -d q="support" \<br/>
        ///   -d limit=10
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PhoneNumbersListResponse>> PhoneNumbersListAsResponseAsync(
            global::Cartesia.PhoneNumbersListCartesiaVersion cartesiaVersion = global::Cartesia.PhoneNumbersListCartesiaVersion.x20260814,
            string? agentId = default,
            string? providerId = default,
            global::Cartesia.PhoneNumbersListType? type = default,
            string? q = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}