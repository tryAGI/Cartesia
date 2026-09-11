
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Sent as the agent speaks, carrying the text spoken since the previous delta, typically one word at a time. Deltas include separator spaces, so build the running text by appending `text` verbatim. The user's speech is not streamed incrementally. It arrives as finalized text in `turn_ended`.
    /// </summary>
    public sealed partial class AgentTurnOutputTextDeltaEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnOutputTextDeltaEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventType Type { get; set; }

        /// <summary>
        /// Matches the `turn` of the turn the text belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turn { get; set; }

        /// <summary>
        /// Always `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnOutputTextDeltaEventRoleJsonConverter))]
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventRole Role { get; set; }

        /// <summary>
        /// The exact substring to append. Separator spaces are included, so build the running text with `buffer[turn] += text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnOutputTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="turn">
        /// Matches the `turn` of the turn the text belongs to.
        /// </param>
        /// <param name="text">
        /// The exact substring to append. Separator spaces are included, so build the running text with `buffer[turn] += text`.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="role">
        /// Always `assistant`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnOutputTextDeltaEvent(
            int turn,
            string text,
            global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventType type,
            global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventRole role)
        {
            this.Type = type;
            this.Turn = turn;
            this.Role = role;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnOutputTextDeltaEvent" /> class.
        /// </summary>
        public AgentTurnOutputTextDeltaEvent()
        {
        }

    }
}