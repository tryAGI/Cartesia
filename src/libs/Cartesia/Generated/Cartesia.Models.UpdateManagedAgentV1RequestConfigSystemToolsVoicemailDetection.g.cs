
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Configuration for detecting voicemail. Omit to keep the current setting or set to `null` to disable this tool.
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeechJsonConverter))]
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? PreToolSpeech { get; set; }

        /// <summary>
        /// Message spoken without interruption before hangup, even when `pre_tool_speech` is `off`. Omit to keep the current message or set to `null` to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection" /> class.
        /// </summary>
        /// <param name="description">
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
        /// </param>
        /// <param name="message">
        /// Message spoken without interruption before hangup, even when `pre_tool_speech` is `off`. Omit to keep the current message or set to `null` to clear it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection(
            string? description,
            global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? preToolSpeech,
            string? message)
        {
            this.Description = description;
            this.PreToolSpeech = preToolSpeech;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection()
        {
        }

    }
}