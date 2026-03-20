#nullable enable

namespace Cartesia
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Generate a New Access Token<br/>
        /// Generates a new Access Token for the client. These tokens are short-lived and should be used to make requests to the API from authenticated clients.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TokenResponse> AuthAccessTokenAsync(
            global::Cartesia.AuthAccessTokenCartesiaVersion cartesiaVersion,

            global::Cartesia.TokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a New Access Token<br/>
        /// Generates a new Access Token for the client. These tokens are short-lived and should be used to make requests to the API from authenticated clients.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="grants"></param>
        /// <param name="expiresIn">
        /// The number of seconds the token will be valid for since the time of generation. The maximum is 1 hour (3600 seconds).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TokenResponse> AuthAccessTokenAsync(
            global::Cartesia.AuthAccessTokenCartesiaVersion cartesiaVersion,
            global::Cartesia.TokenGrant? grants = default,
            int? expiresIn = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}