
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentSummaryV1
    {
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
        /// Unique identifier for an immutable agent configuration version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSummaryV1" /> class.
        /// </summary>
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
        /// <param name="versionId">
        /// Unique identifier for an immutable agent configuration version.
        /// </param>
        /// <param name="description">
        /// Description of the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentSummaryV1(
            global::System.DateTime createdAt,
            string id,
            string name,
            global::System.DateTime updatedAt,
            string versionId,
            string? description)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAt = updatedAt;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSummaryV1" /> class.
        /// </summary>
        public ManagedAgentSummaryV1()
        {
        }

    }
}