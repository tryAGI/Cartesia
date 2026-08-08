
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// One locale a voice can speak, as a BCP-47 language-region tag plus whether it is the voice's native/source locale.
    /// </summary>
    public sealed partial class VoiceLocale
    {
        /// <summary>
        /// The locale's BCP-47 language-region tag (for example, `en-US`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Whether this is the voice's native/source locale.
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
        /// Initializes a new instance of the <see cref="VoiceLocale" /> class.
        /// </summary>
        /// <param name="locale">
        /// The locale's BCP-47 language-region tag (for example, `en-US`).
        /// </param>
        /// <param name="isNative">
        /// Whether this is the voice's native/source locale.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceLocale(
            string locale,
            bool isNative)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.IsNative = isNative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLocale" /> class.
        /// </summary>
        public VoiceLocale()
        {
        }

    }
}