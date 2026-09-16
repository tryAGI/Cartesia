
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Sent when a turn finishes, with the complete final text for the turn. This is the version to store and display. The events for a single turn always arrive in order: `turn_started`, then any `turn_output_text_delta` events, then `turn_ended`. If the agent hangs up mid-turn, the connection closes without a final `turn_ended`; treat the close as ending any open turn.
    /// </summary>
    public sealed partial class AgentTurnEndedEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnEndedEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentTurnEndedEventType Type { get; set; }

        /// <summary>
        /// Matches the `turn` of the corresponding `turn_started` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turn { get; set; }

        /// <summary>
        /// Who spoke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnEndedEventRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.AgentTurnEndedEventRole Role { get; set; }

        /// <summary>
        /// The finalized text of the turn. For a user turn, the transcribed speech. For an assistant turn, the text the agent actually spoke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// For assistant turns, `true` when the user interrupted the turn. For user turns, `true` only when the call ended mid-turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Interrupted { get; set; }

        /// <summary>
        /// Seconds since the start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// Seconds since the start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// Tools called during this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCall> ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnEndedEvent" /> class.
        /// </summary>
        /// <param name="turn">
        /// Matches the `turn` of the corresponding `turn_started` event.
        /// </param>
        /// <param name="role">
        /// Who spoke.
        /// </param>
        /// <param name="text">
        /// The finalized text of the turn. For a user turn, the transcribed speech. For an assistant turn, the text the agent actually spoke.
        /// </param>
        /// <param name="interrupted">
        /// For assistant turns, `true` when the user interrupted the turn. For user turns, `true` only when the call ended mid-turn.
        /// </param>
        /// <param name="startTime">
        /// Seconds since the start of the session.
        /// </param>
        /// <param name="endTime">
        /// Seconds since the start of the session.
        /// </param>
        /// <param name="toolCalls">
        /// Tools called during this turn.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnEndedEvent(
            int turn,
            global::Cartesia.Realtime.AgentTurnEndedEventRole role,
            string text,
            bool interrupted,
            double startTime,
            double endTime,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCall> toolCalls,
            global::Cartesia.Realtime.AgentTurnEndedEventType type)
        {
            this.Type = type;
            this.Turn = turn;
            this.Role = role;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Interrupted = interrupted;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnEndedEvent" /> class.
        /// </summary>
        public AgentTurnEndedEvent()
        {
        }

    }
}