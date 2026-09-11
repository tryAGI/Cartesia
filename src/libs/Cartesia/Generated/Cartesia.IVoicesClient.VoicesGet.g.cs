#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Voice> VoicesGetAsync(
            string id,
            global::Cartesia.VoicesGetCartesiaVersion cartesiaVersion = global::Cartesia.VoicesGetCartesiaVersion.x20260814,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? expand = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.Voice>> VoicesGetAsResponseAsync(
            string id,
            global::Cartesia.VoicesGetCartesiaVersion cartesiaVersion = global::Cartesia.VoicesGetCartesiaVersion.x20260814,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? expand = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}