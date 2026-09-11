
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request to localize a voice into an accent.<br/>
    /// Example: {"voice_id":"0418348a-0ca2-4e90-9986-800fb8b3bbc0","name":"Skylar French","accent":"parisian","access":"private"}
    /// </summary>
    public sealed partial class LocalizeVoiceRequest
    {
        /// <summary>
        /// ID of the existing voice you want to localize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Name for the newly localized voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description for the newly localized voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Short tagline for the newly localized voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagline")]
        public string? Tagline { get; set; }

        /// <summary>
        /// The accent to localize into. Get ids from [GET /accents](/api-reference/accents/list) with `is_localizable=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.LocalizeVoiceAccentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.LocalizeVoiceAccent Accent { get; set; }

        /// <summary>
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>))]
        public global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizeVoiceRequest" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// ID of the existing voice you want to localize.
        /// </param>
        /// <param name="name">
        /// Name for the newly localized voice.
        /// </param>
        /// <param name="accent">
        /// The accent to localize into. Get ids from [GET /accents](/api-reference/accents/list) with `is_localizable=true`.
        /// </param>
        /// <param name="description">
        /// Description for the newly localized voice.
        /// </param>
        /// <param name="tagline">
        /// Short tagline for the newly localized voice.
        /// </param>
        /// <param name="access">
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalizeVoiceRequest(
            string voiceId,
            string name,
            global::Cartesia.LocalizeVoiceAccent accent,
            string? description,
            string? tagline,
            global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? access)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Tagline = tagline;
            this.Accent = accent;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizeVoiceRequest" /> class.
        /// </summary>
        public LocalizeVoiceRequest()
        {
        }

    }
}