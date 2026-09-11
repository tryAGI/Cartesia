#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update Voice<br/>
        /// Update the name, description, gender, and accent of a voice. To set the gender back to the default, set the gender to `null`. If gender is not specified, the gender will not be updated.
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
        global::System.Threading.Tasks.Task<global::Cartesia.Voice> VoicesUpdateAsync(
            string id,

            global::Cartesia.UpdateVoiceRequest request,
            global::Cartesia.VoicesUpdateCartesiaVersion cartesiaVersion = global::Cartesia.VoicesUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Voice<br/>
        /// Update the name, description, gender, and accent of a voice. To set the gender back to the default, set the gender to `null`. If gender is not specified, the gender will not be updated.
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
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.Voice>> VoicesUpdateAsResponseAsync(
            string id,

            global::Cartesia.UpdateVoiceRequest request,
            global::Cartesia.VoicesUpdateCartesiaVersion cartesiaVersion = global::Cartesia.VoicesUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Voice<br/>
        /// Update the name, description, gender, and accent of a voice. To set the gender back to the default, set the gender to `null`. If gender is not specified, the gender will not be updated.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="tagline">
        /// A few words describing the voice. At most 32 characters.
        /// </param>
        /// <param name="description">
        /// A description for the voice, typically longer than the tagline if both are provided.
        /// </param>
        /// <param name="gender"></param>
        /// <param name="accent">
        /// Metadata for labeling the accent of this voice, and a prerequisite for [Add Voice Accents](/api-reference/voices/add-accents). See [GET /accents](/api-reference/accents/list) for values valid for each language.
        /// </param>
        /// <param name="access">
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Voice> VoicesUpdateAsync(
            string id,
            global::Cartesia.VoicesUpdateCartesiaVersion cartesiaVersion = global::Cartesia.VoicesUpdateCartesiaVersion.x20260814,
            string? name = default,
            string? tagline = default,
            string? description = default,
            global::Cartesia.GenderPresentation? gender = default,
            global::Cartesia.VoiceAccent? accent = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? access = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}