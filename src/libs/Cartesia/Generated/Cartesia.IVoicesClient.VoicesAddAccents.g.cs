#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Add Voice Accents<br/>
        /// Add accents to an instant voice clone you own so a single `voice_id` can speak multiple accents natively.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Voice> VoicesAddAccentsAsync(
            string id,

            global::Cartesia.AddVoiceAccentsRequest request,
            global::Cartesia.VoicesAddAccentsCartesiaVersion cartesiaVersion = global::Cartesia.VoicesAddAccentsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Voice Accents<br/>
        /// Add accents to an instant voice clone you own so a single `voice_id` can speak multiple accents natively.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.Voice>> VoicesAddAccentsAsResponseAsync(
            string id,

            global::Cartesia.AddVoiceAccentsRequest request,
            global::Cartesia.VoicesAddAccentsCartesiaVersion cartesiaVersion = global::Cartesia.VoicesAddAccentsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Voice Accents<br/>
        /// Add accents to an instant voice clone you own so a single `voice_id` can speak multiple accents natively.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="accents">
        /// Additional accents you want this voice to speak natively. The voice must already have an accent of its own: if [Get Voice](/api-reference/voices/get) returns no `accents` field, set one with [Update Voice](/api-reference/voices/update) first. A voice can support up to 10 accents in total.<br/>
        /// Example: [british, parisian]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Voice> VoicesAddAccentsAsync(
            string id,
            global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent> accents,
            global::Cartesia.VoicesAddAccentsCartesiaVersion cartesiaVersion = global::Cartesia.VoicesAddAccentsCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}