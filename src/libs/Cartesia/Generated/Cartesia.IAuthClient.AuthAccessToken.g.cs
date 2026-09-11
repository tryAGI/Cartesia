#nullable enable

namespace Cartesia
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Generate a New Access Token<br/>
        /// Generates a short-lived access token to make API requests from authenticated clients.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TokenResponse> AuthAccessTokenAsync(

            global::Cartesia.TokenRequest request,
            global::Cartesia.AuthAccessTokenCartesiaVersion cartesiaVersion = global::Cartesia.AuthAccessTokenCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a New Access Token<br/>
        /// Generates a short-lived access token to make API requests from authenticated clients.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.TokenResponse>> AuthAccessTokenAsResponseAsync(

            global::Cartesia.TokenRequest request,
            global::Cartesia.AuthAccessTokenCartesiaVersion cartesiaVersion = global::Cartesia.AuthAccessTokenCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a New Access Token<br/>
        /// Generates a short-lived access token to make API requests from authenticated clients.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="grants"></param>
        /// <param name="expiresIn">
        /// The number of seconds the token will be valid for since the time of generation. The maximum is 1 hour (3600 seconds).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TokenResponse> AuthAccessTokenAsync(
            global::Cartesia.AuthAccessTokenCartesiaVersion cartesiaVersion = global::Cartesia.AuthAccessTokenCartesiaVersion.x20260814,
            global::Cartesia.TokenGrant? grants = default,
            int? expiresIn = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}