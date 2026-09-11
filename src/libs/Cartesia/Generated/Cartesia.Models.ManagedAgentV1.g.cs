
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentV1
    {
        /// <summary>
        /// Complete configuration for the agent's model, language, audio, and tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentConfigV1 Config { get; set; }

        /// <summary>
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name shown for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentV1Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentV1" /> class.
        /// </summary>
        /// <param name="config">
        /// Complete configuration for the agent's model, language, audio, and tools.
        /// </param>
        /// <param name="createdAt">
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </param>
        /// <param name="id">
        /// Unique identifier for the agent.
        /// </param>
        /// <param name="name">
        /// Name shown for the agent.
        /// </param>
        /// <param name="updatedAt">
        /// An RFC 3339 / ISO 8601 date-time string with timezone (e.g. `2025-04-16T12:34:56.789Z`).
        /// </param>
        /// <param name="version"></param>
        /// <param name="description">
        /// Description of the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentV1(
            global::Cartesia.ManagedAgentConfigV1 config,
            global::System.DateTime createdAt,
            string id,
            string name,
            global::System.DateTime updatedAt,
            global::Cartesia.ManagedAgentV1Version version,
            string? description)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAt = updatedAt;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentV1" /> class.
        /// </summary>
        public ManagedAgentV1()
        {
        }

    }
}