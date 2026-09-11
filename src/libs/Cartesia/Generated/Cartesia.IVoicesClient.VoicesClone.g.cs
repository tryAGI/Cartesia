#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Clone Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesCloneAsync(

            global::Cartesia.VoicesCloneRequest request,
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion = global::Cartesia.VoicesCloneCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.VoiceMetadata>> VoicesCloneAsResponseAsync(

            global::Cartesia.VoicesCloneRequest request,
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion = global::Cartesia.VoicesCloneCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="clip">
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="clipname">
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
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
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </param>
        /// <param name="accent">
        /// Metadata for labeling the accent of the voice you're cloning, and a prerequisite for [Add Voice Accents](/api-reference/voices/add-accents). See [GET /accents](/api-reference/accents/list) for values valid for each language.
        /// </param>
        /// <param name="baseVoiceId">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="access">
        /// Who can use the cloned voice. Prefer `"public"` | `"private"`. Deprecated form field `access[type]` is still accepted.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesCloneAsync(
            byte[] clip,
            string clipname,
            string name,
            global::Cartesia.SupportedLanguage language,
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion = global::Cartesia.VoicesCloneCartesiaVersion.x20260814,
            string? tagline = default,
            string? description = default,
            global::Cartesia.VoiceAccent? accent = default,
            string? baseVoiceId = default,
            global::Cartesia.VoicesCloneRequestAccess? access = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="clip">
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="clipname">
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
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
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </param>
        /// <param name="accent">
        /// Metadata for labeling the accent of the voice you're cloning, and a prerequisite for [Add Voice Accents](/api-reference/voices/add-accents). See [GET /accents](/api-reference/accents/list) for values valid for each language.
        /// </param>
        /// <param name="baseVoiceId">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="access">
        /// Who can use the cloned voice. Prefer `"public"` | `"private"`. Deprecated form field `access[type]` is still accepted.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesCloneAsync(
            global::System.IO.Stream clip,
            string clipname,
            string name,
            global::Cartesia.SupportedLanguage language,
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion = global::Cartesia.VoicesCloneCartesiaVersion.x20260814,
            string? tagline = default,
            string? description = default,
            global::Cartesia.VoiceAccent? accent = default,
            string? baseVoiceId = default,
            global::Cartesia.VoicesCloneRequestAccess? access = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="clip">
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="clipname">
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
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
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </param>
        /// <param name="accent">
        /// Metadata for labeling the accent of the voice you're cloning, and a prerequisite for [Add Voice Accents](/api-reference/voices/add-accents). See [GET /accents](/api-reference/accents/list) for values valid for each language.
        /// </param>
        /// <param name="baseVoiceId">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="access">
        /// Who can use the cloned voice. Prefer `"public"` | `"private"`. Deprecated form field `access[type]` is still accepted.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.VoiceMetadata>> VoicesCloneAsResponseAsync(
            global::System.IO.Stream clip,
            string clipname,
            string name,
            global::Cartesia.SupportedLanguage language,
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion = global::Cartesia.VoicesCloneCartesiaVersion.x20260814,
            string? tagline = default,
            string? description = default,
            global::Cartesia.VoiceAccent? accent = default,
            string? baseVoiceId = default,
            global::Cartesia.VoicesCloneRequestAccess? access = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}