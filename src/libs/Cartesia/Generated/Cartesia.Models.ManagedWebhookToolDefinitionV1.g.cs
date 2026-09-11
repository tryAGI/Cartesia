
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedWebhookToolDefinitionV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookApiSchemaV1 ApiSchema { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1ExecutionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1PreToolSpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech PreToolSpeech { get; set; }

        /// <summary>
        /// Maximum time to wait for the endpoint to respond. Defaults to 20 seconds.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Runs an HTTP request from Cartesia's servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1TypeJsonConverter))]
        public global::Cartesia.ManagedWebhookToolDefinitionV1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedWebhookToolDefinitionV1" /> class.
        /// </summary>
        /// <param name="apiSchema"></param>
        /// <param name="description">
        /// What the tool does and when the agent should use it.
        /// </param>
        /// <param name="executionMode">
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller, while `async` lets the turn finish while the tool runs.
        /// </param>
        /// <param name="name">
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// Maximum time to wait for the endpoint to respond. Defaults to 20 seconds.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="type">
        /// Runs an HTTP request from Cartesia's servers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedWebhookToolDefinitionV1(
            global::Cartesia.ManagedWebhookApiSchemaV1 apiSchema,
            string description,
            global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode executionMode,
            string name,
            global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech preToolSpeech,
            int? responseTimeoutSecs,
            global::Cartesia.ManagedWebhookToolDefinitionV1Type type)
        {
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ExecutionMode = executionMode;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreToolSpeech = preToolSpeech;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedWebhookToolDefinitionV1" /> class.
        /// </summary>
        public ManagedWebhookToolDefinitionV1()
        {
        }

    }
}