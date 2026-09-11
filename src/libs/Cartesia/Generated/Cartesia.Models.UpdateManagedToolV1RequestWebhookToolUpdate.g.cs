
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedToolV1RequestWebhookToolUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? ApiSchema { get; set; }

        /// <summary>
        /// What the tool does and when the agent should use it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller. `async` lets the turn finish while the tool runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateExecutionModeJsonConverter))]
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeechJsonConverter))]
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? PreToolSpeech { get; set; }

        /// <summary>
        /// Maximum time to wait for the endpoint to respond. Defaults to 20 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedToolV1RequestWebhookToolUpdate" /> class.
        /// </summary>
        /// <param name="apiSchema"></param>
        /// <param name="description">
        /// What the tool does and when the agent should use it.
        /// </param>
        /// <param name="executionMode">
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller. `async` lets the turn finish while the tool runs.
        /// </param>
        /// <param name="name">
        /// Name the agent uses to call the tool. Names are case-sensitive.
        /// </param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// Maximum time to wait for the endpoint to respond. Defaults to 20 seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedToolV1RequestWebhookToolUpdate(
            global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? apiSchema,
            string? description,
            global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? executionMode,
            string? name,
            global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? preToolSpeech,
            int? responseTimeoutSecs)
        {
            this.ApiSchema = apiSchema;
            this.Description = description;
            this.ExecutionMode = executionMode;
            this.Name = name;
            this.PreToolSpeech = preToolSpeech;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedToolV1RequestWebhookToolUpdate" /> class.
        /// </summary>
        public UpdateManagedToolV1RequestWebhookToolUpdate()
        {
        }

    }
}