
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentConfigV1LanguagePresets2
    {
        /// <summary>
        /// ID of the voice the agent speaks this language with, instead of `audio.output.voice_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The locale, such as `en-IN`, whose [text normalization](/build-with-cartesia/capability-guides/text-normalization) conventions the agent uses to read numbers, dates, times, and currency in this language, returned as saved. Absent when not set. The agent then uses this language's conventions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalization")]
        public string? Normalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1LanguagePresets2" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// ID of the voice the agent speaks this language with, instead of `audio.output.voice_id`.
        /// </param>
        /// <param name="normalization">
        /// The locale, such as `en-IN`, whose [text normalization](/build-with-cartesia/capability-guides/text-normalization) conventions the agent uses to read numbers, dates, times, and currency in this language, returned as saved. Absent when not set. The agent then uses this language's conventions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1LanguagePresets2(
            string? voiceId,
            string? normalization)
        {
            this.VoiceId = voiceId;
            this.Normalization = normalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1LanguagePresets2" /> class.
        /// </summary>
        public ManagedAgentConfigV1LanguagePresets2()
        {
        }

    }
}