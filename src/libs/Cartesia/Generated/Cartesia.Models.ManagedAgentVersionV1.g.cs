
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An immutable snapshot of an agent's configuration.
    /// </summary>
    public sealed partial class ManagedAgentVersionV1
    {
        /// <summary>
        /// Complete configuration for the agent's model, language, audio, and tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentConfigV1 Config { get; set; }

        /// <summary>
        /// Time when this version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ID of the user or API key that created this version. `null` when no creator was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Description supplied when this version was created. `null` if none was provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier for an immutable agent configuration version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentVersionV1" /> class.
        /// </summary>
        /// <param name="config">
        /// Complete configuration for the agent's model, language, audio, and tools.
        /// </param>
        /// <param name="createdAt">
        /// Time when this version was created.
        /// </param>
        /// <param name="id">
        /// Unique identifier for an immutable agent configuration version.
        /// </param>
        /// <param name="createdBy">
        /// ID of the user or API key that created this version. `null` when no creator was recorded.
        /// </param>
        /// <param name="description">
        /// Description supplied when this version was created. `null` if none was provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentVersionV1(
            global::Cartesia.ManagedAgentConfigV1 config,
            global::System.DateTime createdAt,
            string id,
            string? createdBy,
            string? description)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentVersionV1" /> class.
        /// </summary>
        public ManagedAgentVersionV1()
        {
        }

    }
}