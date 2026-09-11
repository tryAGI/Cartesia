
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentV1Version
    {
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
        /// Initializes a new instance of the <see cref="ManagedAgentV1Version" /> class.
        /// </summary>
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
        public ManagedAgentV1Version(
            global::System.DateTime createdAt,
            string id,
            string? createdBy,
            string? description)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentV1Version" /> class.
        /// </summary>
        public ManagedAgentV1Version()
        {
        }

    }
}