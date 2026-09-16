
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Reports a problem with the session or an event you sent. When `fatal` is `false`, the server ignores that event and keeps the connection open. When `fatal` is `true`, it closes the connection with code 1008 for client or protocol errors, or 1011 if the agent fails.
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
        /// `invalid_event` means a client event was rejected; `agent_failed` means the agent failed. The following errors prevent the session from starting:<br/>
        /// - `missing_dynamic_variables`: a value needed by the welcome message is missing.<br/>
        /// - `invalid_dynamic_variables`: the supplied names or values are invalid.<br/>
        /// - `dynamic_variables_not_allowed`: a browser access token was used to supply custom values.
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
        /// `invalid_event` means a client event was rejected; `agent_failed` means the agent failed. The following errors prevent the session from starting:<br/>
        /// - `missing_dynamic_variables`: a value needed by the welcome message is missing.<br/>
        /// - `invalid_dynamic_variables`: the supplied names or values are invalid.<br/>
        /// - `dynamic_variables_not_allowed`: a browser access token was used to supply custom values.
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