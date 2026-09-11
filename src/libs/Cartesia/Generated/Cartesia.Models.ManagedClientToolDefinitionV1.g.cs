
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedClientToolDefinitionV1
    {
        /// <summary>
        /// What the tool does and when the agent should use it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller, while `async` lets the turn finish while the tool runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1ExecutionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Whether the client application must return a result. When `false`, the tool call is dispatched without waiting for a result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExpectsResponse { get; set; }

        /// <summary>
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedClientToolParametersV1 Parameters { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1PreToolSpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech PreToolSpeech { get; set; }

        /// <summary>
        /// Maximum time to wait for the client application to return a result. Defaults to 20 seconds. Applies only when `expects_response` is `true`.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Runs a function in the connected client application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1TypeJsonConverter))]
        public global::Cartesia.ManagedClientToolDefinitionV1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedClientToolDefinitionV1" /> class.
        /// </summary>
        /// <param name="description">
        /// What the tool does and when the agent should use it.
        /// </param>
        /// <param name="executionMode">
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller, while `async` lets the turn finish while the tool runs.
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
        /// Maximum time to wait for the client application to return a result. Defaults to 20 seconds. Applies only when `expects_response` is `true`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="type">
        /// Runs a function in the connected client application.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedClientToolDefinitionV1(
            string description,
            global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode executionMode,
            bool expectsResponse,
            string name,
            global::Cartesia.ManagedClientToolParametersV1 parameters,
            global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech preToolSpeech,
            int? responseTimeoutSecs,
            global::Cartesia.ManagedClientToolDefinitionV1Type type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ExecutionMode = executionMode;
            this.ExpectsResponse = expectsResponse;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.PreToolSpeech = preToolSpeech;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedClientToolDefinitionV1" /> class.
        /// </summary>
        public ManagedClientToolDefinitionV1()
        {
        }

    }
}