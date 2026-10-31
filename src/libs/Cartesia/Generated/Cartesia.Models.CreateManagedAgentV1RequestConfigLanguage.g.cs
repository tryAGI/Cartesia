
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigLanguage
    {
        /// <summary>
        /// The language the agent starts each call in. Use a language code such as `en`, or a locale such as `en-US` for a regional accent. Write `initial_message` in this language. Omit or set to `null` to use `en`. See [supported languages and locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.NullableLanguageOrLocaleJsonConverter))]
        public global::Cartesia.NullableLanguageOrLocale? Primary { get; set; }

        /// <summary>
        /// Additional languages, each as `{ code, presets }`. Each code is a language, such as `fr`, or a locale, such as `es-MX`. Omit or send `[]` for a single-language agent.<br/>
        /// - When this list is nonempty, the primary and additional languages must be English (`en`), Spanish (`es`), French (`fr`), Hindi (`hi`), or Japanese (`ja`), or supported locales of these languages.<br/>
        /// - Each base language may appear only once, including the primary. For example, `en-US` and `en-GB` cannot be configured together.<br/>
        /// Speech recognition listens for all configured languages. The agent switches when the caller asks and keeps using that language until another requested switch. A short phrase in another language does not trigger a switch.<br/>
        /// Example: [{"code":"es-MX","presets":{"voice_id":"\u003Cspanish_voice_id\u003E"}}, {"code":"fr"}]
        /// </summary>
        /// <example>[{"code":"es-MX","presets":{"voice_id":"\u003Cspanish_voice_id\u003E"}}, {"code":"fr"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional")]
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentAdditionalLanguageInputV1>? Additional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigLanguage" /> class.
        /// </summary>
        /// <param name="primary">
        /// The language the agent starts each call in. Use a language code such as `en`, or a locale such as `en-US` for a regional accent. Write `initial_message` in this language. Omit or set to `null` to use `en`. See [supported languages and locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </param>
        /// <param name="additional">
        /// Additional languages, each as `{ code, presets }`. Each code is a language, such as `fr`, or a locale, such as `es-MX`. Omit or send `[]` for a single-language agent.<br/>
        /// - When this list is nonempty, the primary and additional languages must be English (`en`), Spanish (`es`), French (`fr`), Hindi (`hi`), or Japanese (`ja`), or supported locales of these languages.<br/>
        /// - Each base language may appear only once, including the primary. For example, `en-US` and `en-GB` cannot be configured together.<br/>
        /// Speech recognition listens for all configured languages. The agent switches when the caller asks and keeps using that language until another requested switch. A short phrase in another language does not trigger a switch.<br/>
        /// Example: [{"code":"es-MX","presets":{"voice_id":"\u003Cspanish_voice_id\u003E"}}, {"code":"fr"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigLanguage(
            global::Cartesia.NullableLanguageOrLocale? primary,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentAdditionalLanguageInputV1>? additional)
        {
            this.Primary = primary;
            this.Additional = additional;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigLanguage" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigLanguage()
        {
        }

    }
}