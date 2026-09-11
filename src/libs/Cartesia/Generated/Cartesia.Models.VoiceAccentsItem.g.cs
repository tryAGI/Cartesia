
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// One accent this voice can speak. `accent` is an accent id from [GET /accents](/api-reference/accents/list).
    /// </summary>
    public sealed partial class VoiceAccentsItem
    {
        /// <summary>
        /// Accent id from [GET /accents](/api-reference/accents/list) (e.g. `southern-us`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceAccentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceAccent Accent { get; set; }

        /// <summary>
        /// The accent's BCP-47 language-region tag (e.g. `en-US`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Whether this is the voice's native/source accent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_native")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNative { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceAccentsItem" /> class.
        /// </summary>
        /// <param name="accent">
        /// Accent id from [GET /accents](/api-reference/accents/list) (e.g. `southern-us`).
        /// </param>
        /// <param name="locale">
        /// The accent's BCP-47 language-region tag (e.g. `en-US`).
        /// </param>
        /// <param name="isNative">
        /// Whether this is the voice's native/source accent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceAccentsItem(
            global::Cartesia.VoiceAccent accent,
            string locale,
            bool isNative)
        {
            this.Accent = accent;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.IsNative = isNative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceAccentsItem" /> class.
        /// </summary>
        public VoiceAccentsItem()
        {
        }

    }
}