#nullable enable

namespace Cartesia
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Balance<br/>
        /// Returns your remaining model credits and voice agent balance, the same balances as the Subscription page in the playground. For credits used over time, see Get Credit Usage.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.BalanceResponse> BalanceGetAsync(
            global::Cartesia.BalanceGetCartesiaVersion cartesiaVersion = global::Cartesia.BalanceGetCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Balance<br/>
        /// Returns your remaining model credits and voice agent balance, the same balances as the Subscription page in the playground. For credits used over time, see Get Credit Usage.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.BalanceResponse>> BalanceGetAsResponseAsync(
            global::Cartesia.BalanceGetCartesiaVersion cartesiaVersion = global::Cartesia.BalanceGetCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}