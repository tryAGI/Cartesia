
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigLanguage
    {
        /// <summary>
        /// The language the agent starts each call in. Use a language code such as `en`, or a locale such as `en-US` for a regional accent. Write `initial_message` in this language. Omit to keep the current primary language; set to `null` to use `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.NullableManagedAgentLanguageOrLocaleJsonConverter))]
        public global::Cartesia.NullableManagedAgentLanguageOrLocale? Primary { get; set; }

        /// <summary>
        /// Other languages the caller can switch to, in order. Each is a language, such as `fr`, or a locale, such as `es-MX`. Omit to preserve the current list; `[]` clears it. A list you send replaces the current one; entries are not appended or merged.<br/>
        /// - When other languages are configured, the primary and additional languages must be English (`en`), Spanish (`es`), French (`fr`), Hindi (`hi`), or Japanese (`ja`), or supported locales of these languages.<br/>
        /// - Each base language may appear only once, including the primary. For example, `en-US` and `en-GB` cannot be configured together.<br/>
        /// Changes apply to new calls; calls in progress keep their starting configuration.<br/>
        /// The agent switches when the caller asks and keeps using that language until another requested switch. A short phrase in another language does not trigger a switch.<br/>
        /// Example: [es-MX, fr]
        /// </summary>
        /// <example>[es-MX, fr]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional")]
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentLanguageOrLocale>? Additional { get; set; }

        /// <summary>
        /// Settings per language, keyed by a language or locale such as `es-MX`. A preset applies only when the agent speaks that exact language or locale, including the primary language. Languages without a matching preset use the agent's own settings. Omit to keep the current presets. A map you send replaces them, and `{}` clears them.<br/>
        /// Example: {"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}
        /// </summary>
        /// <example>{"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presets")]
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ManagedAgentLanguagePresetsV1>? Presets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigLanguage" /> class.
        /// </summary>
        /// <param name="primary">
        /// The language the agent starts each call in. Use a language code such as `en`, or a locale such as `en-US` for a regional accent. Write `initial_message` in this language. Omit to keep the current primary language; set to `null` to use `en`.
        /// </param>
        /// <param name="additional">
        /// Other languages the caller can switch to, in order. Each is a language, such as `fr`, or a locale, such as `es-MX`. Omit to preserve the current list; `[]` clears it. A list you send replaces the current one; entries are not appended or merged.<br/>
        /// - When other languages are configured, the primary and additional languages must be English (`en`), Spanish (`es`), French (`fr`), Hindi (`hi`), or Japanese (`ja`), or supported locales of these languages.<br/>
        /// - Each base language may appear only once, including the primary. For example, `en-US` and `en-GB` cannot be configured together.<br/>
        /// Changes apply to new calls; calls in progress keep their starting configuration.<br/>
        /// The agent switches when the caller asks and keeps using that language until another requested switch. A short phrase in another language does not trigger a switch.<br/>
        /// Example: [es-MX, fr]
        /// </param>
        /// <param name="presets">
        /// Settings per language, keyed by a language or locale such as `es-MX`. A preset applies only when the agent speaks that exact language or locale, including the primary language. Languages without a matching preset use the agent's own settings. Omit to keep the current presets. A map you send replaces them, and `{}` clears them.<br/>
        /// Example: {"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1RequestConfigLanguage(
            global::Cartesia.NullableManagedAgentLanguageOrLocale? primary,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentLanguageOrLocale>? additional,
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.ManagedAgentLanguagePresetsV1>? presets)
        {
            this.Primary = primary;
            this.Additional = additional;
            this.Presets = presets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigLanguage" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigLanguage()
        {
        }

    }
}