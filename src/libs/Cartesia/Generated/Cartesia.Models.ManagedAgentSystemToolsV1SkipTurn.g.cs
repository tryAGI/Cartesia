
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Configuration for skipping the agent's turn. Set to `null` to disable this tool.
    /// </summary>
    public sealed partial class ManagedAgentSystemToolsV1SkipTurn
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1SkipTurnPreToolSpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentSystemToolsV1SkipTurnPreToolSpeech PreToolSpeech { get; set; }

        /// <summary>
        /// Temporary check-in timeout in seconds after skipping a turn. Set a longer timeout to give the caller more time, `-1` to disable check-ins, or `null` to keep normal timing. User speech or DTMF restores the original timeout. Requires check-ins to be enabled. The inactivity end-call timer keeps running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_timeout_secs")]
        public int? WaitTimeoutSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1SkipTurn" /> class.
        /// </summary>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
        /// </param>
        /// <param name="description">
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </param>
        /// <param name="waitTimeoutSecs">
        /// Temporary check-in timeout in seconds after skipping a turn. Set a longer timeout to give the caller more time, `-1` to disable check-ins, or `null` to keep normal timing. User speech or DTMF restores the original timeout. Requires check-ins to be enabled. The inactivity end-call timer keeps running.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentSystemToolsV1SkipTurn(
            global::Cartesia.ManagedAgentSystemToolsV1SkipTurnPreToolSpeech preToolSpeech,
            string? description,
            int? waitTimeoutSecs)
        {
            this.Description = description;
            this.PreToolSpeech = preToolSpeech;
            this.WaitTimeoutSecs = waitTimeoutSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1SkipTurn" /> class.
        /// </summary>
        public ManagedAgentSystemToolsV1SkipTurn()
        {
        }

    }
}