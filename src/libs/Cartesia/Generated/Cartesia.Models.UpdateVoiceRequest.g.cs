
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateVoiceRequest
    {
        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.GenderPresentationJsonConverter))]
        public global::Cartesia.GenderPresentation? Gender { get; set; }

        /// <summary>
        /// Metadata for labeling the accent of this voice, and a prerequisite for [Add Voice Accents](/api-reference/voices/add-accents). See [GET /accents](/api-reference/accents/list) for values valid for each language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceAccentJsonConverter))]
        public global::Cartesia.VoiceAccent? Accent { get; set; }

        /// <summary>
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>))]
        public global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVoiceRequest(
            string? name,
            string? tagline,
            string? description,
            global::Cartesia.GenderPresentation? gender,
            global::Cartesia.VoiceAccent? accent,
            global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? access)
        {
            this.Name = name;
            this.Tagline = tagline;
            this.Description = description;
            this.Gender = gender;
            this.Accent = accent;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        public UpdateVoiceRequest()
        {
        }

    }
}