
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Configuration for detecting voicemail. Set to `null` to disable this tool.
    /// </summary>
    public sealed partial class ManagedAgentSystemToolsV1VoicemailDetection
    {
        /// <summary>
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech PreToolSpeech { get; set; }

        /// <summary>
        /// Message spoken without interruption before hangup, even when `pre_tool_speech` is `off`. Set to `null` for no message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1VoicemailDetection" /> class.
        /// </summary>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
        /// </param>
        /// <param name="description">
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </param>
        /// <param name="message">
        /// Message spoken without interruption before hangup, even when `pre_tool_speech` is `off`. Set to `null` for no message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentSystemToolsV1VoicemailDetection(
            global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech preToolSpeech,
            string? description,
            string? message)
        {
            this.Description = description;
            this.PreToolSpeech = preToolSpeech;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1VoicemailDetection" /> class.
        /// </summary>
        public ManagedAgentSystemToolsV1VoicemailDetection()
        {
        }

    }
}