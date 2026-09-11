
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Configuration for ending the call. Omit or set to `null` to disable this tool.
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigSystemToolsEndCall
    {
        /// <summary>
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechJsonConverter))]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? PreToolSpeech { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemToolsEndCall" /> class.
        /// </summary>
        /// <param name="description">
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigSystemToolsEndCall(
            string? description,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? preToolSpeech)
        {
            this.Description = description;
            this.PreToolSpeech = preToolSpeech;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemToolsEndCall" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigSystemToolsEndCall()
        {
        }

    }
}