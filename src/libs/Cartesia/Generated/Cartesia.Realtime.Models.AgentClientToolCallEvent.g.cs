
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// The agent asks this client to run a client tool. When `expects_response` is `true`, answer with a `client_tool_result` carrying the same `tool_call_id`; the invocation stays open until a result, error, or timeout. When `false`, dispatching the action completes the invocation.
    /// </summary>
    public sealed partial class AgentClientToolCallEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentClientToolCallEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentClientToolCallEventType Type { get; set; }

        /// <summary>
        /// Identifies this invocation. Echo it in `client_tool_result`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Name of the client tool to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Arguments for the tool, matching the tool's parameter schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Whether the agent waits for a `client_tool_result`. Comes from the tool's definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExpectsResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentClientToolCallEvent" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Identifies this invocation. Echo it in `client_tool_result`.
        /// </param>
        /// <param name="toolName">
        /// Name of the client tool to run.
        /// </param>
        /// <param name="parameters">
        /// Arguments for the tool, matching the tool's parameter schema.
        /// </param>
        /// <param name="expectsResponse">
        /// Whether the agent waits for a `client_tool_result`. Comes from the tool's definition.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentClientToolCallEvent(
            string toolCallId,
            string toolName,
            object parameters,
            bool expectsResponse,
            global::Cartesia.Realtime.AgentClientToolCallEventType type)
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.ExpectsResponse = expectsResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentClientToolCallEvent" /> class.
        /// </summary>
        public AgentClientToolCallEvent()
        {
        }

    }
}