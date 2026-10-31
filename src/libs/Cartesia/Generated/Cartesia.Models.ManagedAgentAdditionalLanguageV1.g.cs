
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentAdditionalLanguageV1
    {
        /// <summary>
        /// A language code (`en`, `es`, `fr`, `hi`, or `ja`) or a supported locale of one of these languages, such as `es-MX`. A locale selects a regional accent. See [supported locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).<br/>
        /// Example: es-MX
        /// </summary>
        /// <example>es-MX</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.MultilingualAgentLanguageOrLocaleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.MultilingualAgentLanguageOrLocale Code { get; set; }

        /// <summary>
        /// Settings the agent uses while speaking this language. Absent when it uses the agent's own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presets")]
        public global::Cartesia.ManagedAgentLanguagePresetsV1? Presets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentAdditionalLanguageV1" /> class.
        /// </summary>
        /// <param name="code">
        /// A language code (`en`, `es`, `fr`, `hi`, or `ja`) or a supported locale of one of these languages, such as `es-MX`. A locale selects a regional accent. See [supported locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).<br/>
        /// Example: es-MX
        /// </param>
        /// <param name="presets">
        /// Settings the agent uses while speaking this language. Absent when it uses the agent's own.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentAdditionalLanguageV1(
            global::Cartesia.MultilingualAgentLanguageOrLocale code,
            global::Cartesia.ManagedAgentLanguagePresetsV1? presets)
        {
            this.Code = code;
            this.Presets = presets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentAdditionalLanguageV1" /> class.
        /// </summary>
        public ManagedAgentAdditionalLanguageV1()
        {
        }

    }
}