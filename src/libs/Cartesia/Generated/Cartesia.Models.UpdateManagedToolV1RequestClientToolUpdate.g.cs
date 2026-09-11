
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedToolV1RequestClientToolUpdate
    {
        /// <summary>
        /// What the tool does and when the agent should use it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller. `async` lets the turn finish while the tool runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdateExecutionModeJsonConverter))]
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Whether the client application must return a result. When `false`, the tool call is dispatched without waiting for a result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        public bool? ExpectsResponse { get; set; }

        /// <summary>
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::Cartesia.ManagedClientToolParametersV1? Parameters { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechJsonConverter))]
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? PreToolSpeech { get; set; }

        /// <summary>
        /// Maximum time to wait for the client application to return a result. Defaults to 20 seconds. Applies only when `expects_response` is `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedToolV1RequestClientToolUpdate" /> class.
        /// </summary>
        /// <param name="description">
        /// What the tool does and when the agent should use it.
        /// </param>
        /// <param name="executionMode">
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller. `async` lets the turn finish while the tool runs.
        /// </param>
        /// <param name="expectsResponse">
        /// Whether the client application must return a result. When `false`, the tool call is dispatched without waiting for a result.
        /// </param>
        /// <param name="name">
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// Maximum time to wait for the client application to return a result. Defaults to 20 seconds. Applies only when `expects_response` is `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedToolV1RequestClientToolUpdate(
            string? description,
            global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? executionMode,
            bool? expectsResponse,
            string? name,
            global::Cartesia.ManagedClientToolParametersV1? parameters,
            global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? preToolSpeech,
            int? responseTimeoutSecs)
        {
            this.Description = description;
            this.ExecutionMode = executionMode;
            this.ExpectsResponse = expectsResponse;
            this.Name = name;
            this.Parameters = parameters;
            this.PreToolSpeech = preToolSpeech;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedToolV1RequestClientToolUpdate" /> class.
        /// </summary>
        public UpdateManagedToolV1RequestClientToolUpdate()
        {
        }

    }
}