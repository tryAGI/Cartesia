
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Settings for this language. Set `voice_id`, `normalization`, or both.
    /// </summary>
    public sealed partial class ManagedAgentLanguagePresetsV1
    {
        /// <summary>
        /// ID of the voice the agent speaks this language with, instead of `audio.output.voice_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// A locale, such as `en-IN`, whose [text normalization](/build-with-cartesia/capability-guides/text-normalization) conventions the agent uses to read numbers, dates, times, and currency in this language. Omit to use this language's conventions. Unlike the TTS API, it doesn't accept `auto`, `off`, or a bare language code such as `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentNormalizationJsonConverter))]
        public global::Cartesia.ManagedAgentNormalization? Normalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentLanguagePresetsV1" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// ID of the voice the agent speaks this language with, instead of `audio.output.voice_id`.
        /// </param>
        /// <param name="normalization">
        /// A locale, such as `en-IN`, whose [text normalization](/build-with-cartesia/capability-guides/text-normalization) conventions the agent uses to read numbers, dates, times, and currency in this language. Omit to use this language's conventions. Unlike the TTS API, it doesn't accept `auto`, `off`, or a bare language code such as `en`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentLanguagePresetsV1(
            string? voiceId,
            global::Cartesia.ManagedAgentNormalization? normalization)
        {
            this.VoiceId = voiceId;
            this.Normalization = normalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentLanguagePresetsV1" /> class.
        /// </summary>
        public ManagedAgentLanguagePresetsV1()
        {
        }

    }
}