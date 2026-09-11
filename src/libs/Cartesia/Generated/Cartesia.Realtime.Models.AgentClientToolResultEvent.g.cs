
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Answers a `client_tool_call` whose `expects_response` is `true`. `tool_call_id` must match the call being answered. The decoded `result` may be at most 4 KiB; larger results are replaced with a `result_too_large` error result. Late, duplicate, or mismatched results are ignored.
    /// </summary>
    public sealed partial class AgentClientToolResultEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentClientToolResultEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentClientToolResultEventType Type { get; set; }

        /// <summary>
        /// The `tool_call_id` from the `client_tool_call` being answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The tool's result, as a string the model can read. At most 4 KiB decoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// Set to `true` when the tool failed. The agent sees the result as an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Optional machine-readable category for a failure, such as `timeout`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentClientToolResultEvent" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// The `tool_call_id` from the `client_tool_call` being answered.
        /// </param>
        /// <param name="result">
        /// The tool's result, as a string the model can read. At most 4 KiB decoded.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="isError">
        /// Set to `true` when the tool failed. The agent sees the result as an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="errorType">
        /// Optional machine-readable category for a failure, such as `timeout`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentClientToolResultEvent(
            string toolCallId,
            string result,
            global::Cartesia.Realtime.AgentClientToolResultEventType type,
            bool? isError,
            string? errorType)
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.IsError = isError;
            this.ErrorType = errorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentClientToolResultEvent" /> class.
        /// </summary>
        public AgentClientToolResultEvent()
        {
        }

    }
}