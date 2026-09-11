#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Localize Voice<br/>
        /// Localize a voice to sound native in another accent. This creates a new voice with its own voice ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesLocalizeAsync(

            global::Cartesia.LocalizeVoiceRequest request,
            global::Cartesia.VoicesLocalizeCartesiaVersion cartesiaVersion = global::Cartesia.VoicesLocalizeCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Localize Voice<br/>
        /// Localize a voice to sound native in another accent. This creates a new voice with its own voice ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.VoiceMetadata>> VoicesLocalizeAsResponseAsync(

            global::Cartesia.LocalizeVoiceRequest request,
            global::Cartesia.VoicesLocalizeCartesiaVersion cartesiaVersion = global::Cartesia.VoicesLocalizeCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Localize Voice<br/>
        /// Localize a voice to sound native in another accent. This creates a new voice with its own voice ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="voiceId">
        /// ID of the existing voice you want to localize.
        /// </param>
        /// <param name="name">
        /// Name for the newly localized voice.
        /// </param>
        /// <param name="description">
        /// Description for the newly localized voice.
        /// </param>
        /// <param name="tagline">
        /// Short tagline for the newly localized voice.
        /// </param>
        /// <param name="accent">
        /// The accent to localize into. Get ids from [GET /accents](/api-reference/accents/list) with `is_localizable=true`.
        /// </param>
        /// <param name="access">
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesLocalizeAsync(
            string voiceId,
            string name,
            global::Cartesia.LocalizeVoiceAccent accent,
            global::Cartesia.VoicesLocalizeCartesiaVersion cartesiaVersion = global::Cartesia.VoicesLocalizeCartesiaVersion.x20260814,
            string? description = default,
            string? tagline = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? access = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}