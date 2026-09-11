
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesCloneRequest
    {
        /// <summary>
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Clip { get; set; }

        /// <summary>
        /// See [Clone Voices](/build-with-cartesia/capability-guides/clone-voices) for guidance on choosing a clip.<br/>
        /// Maximum upload size: `16 MB`.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clipname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Clipname { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A few words describing the voice. At most 32 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagline")]
        public string? Tagline { get; set; }

        /// <summary>
        /// A description for the voice, typically longer than the tagline if both are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SupportedLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.SupportedLanguage Language { get; set; }

        /// <summary>
        /// Metadata for labeling the accent of the voice you're cloning, and a prerequisite for [Add Voice Accents](/api-reference/voices/add-accents). See [GET /accents](/api-reference/accents/list) for values valid for each language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceAccentJsonConverter))]
        public global::Cartesia.VoiceAccent? Accent { get; set; }

        /// <summary>
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_voice_id")]
        public string? BaseVoiceId { get; set; }

        /// <summary>
        /// Who can use the cloned voice. Prefer `"public"` | `"private"`. Deprecated form field `access[type]` is still accepted.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoicesCloneRequestAccessJsonConverter))]
        public global::Cartesia.VoicesCloneRequestAccess? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesCloneRequest" /> class.
        /// </summary>
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
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </param>
        /// <param name="tagline">
        /// A few words describing the voice. At most 32 characters.
        /// </param>
        /// <param name="description">
        /// A description for the voice, typically longer than the tagline if both are provided.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesCloneRequest(
            byte[] clip,
            string clipname,
            string name,
            global::Cartesia.SupportedLanguage language,
            string? tagline,
            string? description,
            global::Cartesia.VoiceAccent? accent,
            string? baseVoiceId,
            global::Cartesia.VoicesCloneRequestAccess? access)
        {
            this.Clip = clip ?? throw new global::System.ArgumentNullException(nameof(clip));
            this.Clipname = clipname ?? throw new global::System.ArgumentNullException(nameof(clipname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tagline = tagline;
            this.Description = description;
            this.Language = language;
            this.Accent = accent;
            this.BaseVoiceId = baseVoiceId;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesCloneRequest" /> class.
        /// </summary>
        public VoicesCloneRequest()
        {
        }

    }
}