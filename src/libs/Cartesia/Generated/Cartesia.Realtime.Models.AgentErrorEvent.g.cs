
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Reports a problem with the session or an event you sent. When `fatal` is `false`, the offending event was dropped and the stream stays open. When `fatal` is `true`, the server closes the connection: code 1008 for client and protocol errors, 1011 for agent pipeline failures.
    /// </summary>
    public sealed partial class AgentErrorEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentErrorEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentErrorEventType Type { get; set; }

        /// <summary>
        /// `invalid_event` for a rejected client event, `agent_failed` for an agent pipeline failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentErrorEventCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.AgentErrorEventCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Whether the server closes the connection after this error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fatal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Fatal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorEvent" /> class.
        /// </summary>
        /// <param name="code">
        /// `invalid_event` for a rejected client event, `agent_failed` for an agent pipeline failure.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.
        /// </param>
        /// <param name="fatal">
        /// Whether the server closes the connection after this error.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentErrorEvent(
            global::Cartesia.Realtime.AgentErrorEventCode code,
            string message,
            bool fatal,
            global::Cartesia.Realtime.AgentErrorEventType type)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Fatal = fatal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorEvent" /> class.
        /// </summary>
        public AgentErrorEvent()
        {
        }

    }
}