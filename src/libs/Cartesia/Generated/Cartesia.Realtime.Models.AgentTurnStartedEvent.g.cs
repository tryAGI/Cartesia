
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Sent when the user starts speaking or the agent starts responding. `turn` comes from a single counter shared by both roles, starting at 1 and strictly increasing over the call, so `turn` alone identifies a turn.
    /// </summary>
    public sealed partial class AgentTurnStartedEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnStartedEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentTurnStartedEventType Type { get; set; }

        /// <summary>
        /// Turn index, unique across the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turn { get; set; }

        /// <summary>
        /// Who is speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnStartedEventRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.AgentTurnStartedEventRole Role { get; set; }

        /// <summary>
        /// Seconds since the start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnStartedEvent" /> class.
        /// </summary>
        /// <param name="turn">
        /// Turn index, unique across the call.
        /// </param>
        /// <param name="role">
        /// Who is speaking.
        /// </param>
        /// <param name="startTime">
        /// Seconds since the start of the session.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnStartedEvent(
            int turn,
            global::Cartesia.Realtime.AgentTurnStartedEventRole role,
            double startTime,
            global::Cartesia.Realtime.AgentTurnStartedEventType type)
        {
            this.Type = type;
            this.Turn = turn;
            this.Role = role;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnStartedEvent" /> class.
        /// </summary>
        public AgentTurnStartedEvent()
        {
        }

    }
}