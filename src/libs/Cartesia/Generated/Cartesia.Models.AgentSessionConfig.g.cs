
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Per-call overrides using the same field structure as agent configuration. Omitted fields use the agent's published configuration.
    /// </summary>
    public sealed partial class AgentSessionConfig
    {
        /// <summary>
        /// Instructions that define the agent's behavior for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Message spoken when the call begins. Set to `null` to wait for the caller to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_message")]
        public string? InitialMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::Cartesia.AgentSessionConfigLanguage? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::Cartesia.AgentSessionConfigAudio? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfig" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions that define the agent's behavior for this call.
        /// </param>
        /// <param name="initialMessage">
        /// Message spoken when the call begins. Set to `null` to wait for the caller to speak first.
        /// </param>
        /// <param name="language"></param>
        /// <param name="audio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionConfig(
            string? instructions,
            string? initialMessage,
            global::Cartesia.AgentSessionConfigLanguage? language,
            global::Cartesia.AgentSessionConfigAudio? audio)
        {
            this.Instructions = instructions;
            this.InitialMessage = initialMessage;
            this.Language = language;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfig" /> class.
        /// </summary>
        public AgentSessionConfig()
        {
        }

    }
}