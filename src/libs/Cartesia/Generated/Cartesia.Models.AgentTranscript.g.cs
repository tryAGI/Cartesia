
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTranscript
    {
        /// <summary>
        /// The role of the participant in the conversation. Roles are `user`, `assistant`, or `system`. `assistant` is the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The text content of the transcript. This is the text that was spoken by the user or the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The start timestamp in seconds relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartTimestamp { get; set; }

        /// <summary>
        /// The end timestamp in seconds relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndTimestamp { get; set; }

        /// <summary>
        /// The tool calls made during the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// The time to first byte in seconds for speech-to-text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_ttfb")]
        public float? SttTtfb { get; set; }

        /// <summary>
        /// The time to first byte in seconds from the agent for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_ttfb")]
        public float? TtsTtfb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTranscript" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the participant in the conversation. Roles are `user`, `assistant`, or `system`. `assistant` is the agent.
        /// </param>
        /// <param name="startTimestamp">
        /// The start timestamp in seconds relative to the start of the call.
        /// </param>
        /// <param name="endTimestamp">
        /// The end timestamp in seconds relative to the start of the call.
        /// </param>
        /// <param name="text">
        /// The text content of the transcript. This is the text that was spoken by the user or the agent.
        /// </param>
        /// <param name="toolCalls">
        /// The tool calls made during the turn.
        /// </param>
        /// <param name="sttTtfb">
        /// The time to first byte in seconds for speech-to-text.
        /// </param>
        /// <param name="ttsTtfb">
        /// The time to first byte in seconds from the agent for text-to-speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTranscript(
            string role,
            float startTimestamp,
            float endTimestamp,
            string? text,
            global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? toolCalls,
            float? sttTtfb,
            float? ttsTtfb)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Text = text;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.ToolCalls = toolCalls;
            this.SttTtfb = sttTtfb;
            this.TtsTtfb = ttsTtfb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTranscript" /> class.
        /// </summary>
        public AgentTranscript()
        {
        }

    }
}