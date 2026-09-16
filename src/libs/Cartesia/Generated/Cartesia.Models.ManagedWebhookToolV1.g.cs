
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedWebhookToolV1
    {
        /// <summary>
        /// Agents that currently use this tool. Included when `expand[]=agents` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? Agents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookApiSchemaV1Response ApiSchema { get; set; }

        /// <summary>
        /// Response fields to save as dynamic variables after a successful JSON response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment> Assignments { get; set; }

        /// <summary>
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookToolV1ExecutionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookToolV1ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Unique identifier for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookToolV1PreToolSpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookToolV1PreToolSpeech PreToolSpeech { get; set; }

        /// <summary>
        /// Maximum time to wait for the endpoint to respond. Defaults to 20 seconds.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Runs an HTTP request from Cartesia's servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookToolV1TypeJsonConverter))]
        public global::Cartesia.ManagedWebhookToolV1Type Type { get; set; }

        /// <summary>
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedWebhookToolV1" /> class.
        /// </summary>
        /// <param name="apiSchema"></param>
        /// <param name="assignments">
        /// Response fields to save as dynamic variables after a successful JSON response
        /// </param>
        /// <param name="createdAt">
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </param>
        /// <param name="description">
        /// What the tool does and when the agent should use it.
        /// </param>
        /// <param name="executionMode">
        /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller, while `async` lets the turn finish while the tool runs.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the tool.
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
        /// <param name="updatedAt">
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </param>
        /// <param name="agents">
        /// Agents that currently use this tool. Included when `expand[]=agents` is requested.
        /// </param>
        /// <param name="type">
        /// Runs an HTTP request from Cartesia's servers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedWebhookToolV1(
            global::Cartesia.ManagedWebhookApiSchemaV1Response apiSchema,
            global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment> assignments,
            global::System.DateTime createdAt,
            string description,
            global::Cartesia.ManagedWebhookToolV1ExecutionMode executionMode,
            string id,
            string name,
            global::Cartesia.ManagedWebhookToolV1PreToolSpeech preToolSpeech,
            int responseTimeoutSecs,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? agents,
            global::Cartesia.ManagedWebhookToolV1Type type)
        {
            this.Agents = agents;
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
            this.Assignments = assignments ?? throw new global::System.ArgumentNullException(nameof(assignments));
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ExecutionMode = executionMode;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreToolSpeech = preToolSpeech;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedWebhookToolV1" /> class.
        /// </summary>
        public ManagedWebhookToolV1()
        {
        }

    }
}