
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// One accent returned by [GET /accents](/api-reference/accents/list).
    /// </summary>
    public sealed partial class Accent
    {
        /// <summary>
        /// ID of the accent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceAccentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceAccent Id { get; set; }

        /// <summary>
        /// Human-readable display name (for example `General American English`).<br/>
        /// Example: General American English
        /// </summary>
        /// <example>General American English</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ISO 639-1 language subtag (for example `en`).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Canonical locale for this accent (BCP-47, for example `en-US`).<br/>
        /// Example: en-US
        /// </summary>
        /// <example>en-US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Whether this accent is the default for its `locale`. Exactly one accent per locale is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_locale_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLocaleDefault { get; set; }

        /// <summary>
        /// Whether POST /voices/localize can target this accent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_localizable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLocalizable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Accent" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the accent.
        /// </param>
        /// <param name="name">
        /// Human-readable display name (for example `General American English`).<br/>
        /// Example: General American English
        /// </param>
        /// <param name="language">
        /// ISO 639-1 language subtag (for example `en`).<br/>
        /// Example: en
        /// </param>
        /// <param name="locale">
        /// Canonical locale for this accent (BCP-47, for example `en-US`).<br/>
        /// Example: en-US
        /// </param>
        /// <param name="isLocaleDefault">
        /// Whether this accent is the default for its `locale`. Exactly one accent per locale is true.
        /// </param>
        /// <param name="isLocalizable">
        /// Whether POST /voices/localize can target this accent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Accent(
            global::Cartesia.VoiceAccent id,
            string name,
            string language,
            string locale,
            bool isLocaleDefault,
            bool isLocalizable)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.IsLocaleDefault = isLocaleDefault;
            this.IsLocalizable = isLocalizable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Accent" /> class.
        /// </summary>
        public Accent()
        {
        }

    }
}