
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentConfigV1Language
    {
        /// <summary>
        /// The language the agent starts each call in: a language, such as `en`, or a locale, such as `en-US`. See [supported languages and locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.LanguageOrLocaleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.LanguageOrLocale Primary { get; set; }

        /// <summary>
        /// Other languages the caller can switch to, in order. Each is a language, such as `fr`, or a locale, such as `es-MX`. Returns `[]` when none are configured. Tags are returned as saved: a locale such as `es-MX` is not reduced to `es`.<br/>
        /// Example: [es-MX, fr]
        /// </summary>
        /// <example>[es-MX, fr]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Additional { get; set; }

        /// <summary>
        /// Settings per language, keyed by a language or locale such as `es-MX`. A preset applies only when the agent speaks that exact language or locale, including the primary language. Languages without a matching preset use the agent's own settings. Returns `{}` when none are configured.<br/>
        /// Example: {"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}
        /// </summary>
        /// <example>{"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Cartesia.ManagedAgentLanguagePresetsV1> Presets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Language" /> class.
        /// </summary>
        /// <param name="primary">
        /// The language the agent starts each call in: a language, such as `en`, or a locale, such as `en-US`. See [supported languages and locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </param>
        /// <param name="additional">
        /// Other languages the caller can switch to, in order. Each is a language, such as `fr`, or a locale, such as `es-MX`. Returns `[]` when none are configured. Tags are returned as saved: a locale such as `es-MX` is not reduced to `es`.<br/>
        /// Example: [es-MX, fr]
        /// </param>
        /// <param name="presets">
        /// Settings per language, keyed by a language or locale such as `es-MX`. A preset applies only when the agent speaks that exact language or locale, including the primary language. Languages without a matching preset use the agent's own settings. Returns `{}` when none are configured.<br/>
        /// Example: {"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1Language(
            global::Cartesia.LanguageOrLocale primary,
            global::System.Collections.Generic.IList<string> additional,
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.ManagedAgentLanguagePresetsV1> presets)
        {
            this.Primary = primary;
            this.Additional = additional ?? throw new global::System.ArgumentNullException(nameof(additional));
            this.Presets = presets ?? throw new global::System.ArgumentNullException(nameof(presets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Language" /> class.
        /// </summary>
        public ManagedAgentConfigV1Language()
        {
        }

    }
}