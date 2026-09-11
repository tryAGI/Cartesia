
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Metadata for a standard API key.
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// Stable identifier for the API key. Safe to expose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable description set when the key was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// When the API key was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Email of the user who created the key. `null` for older keys with no recorded creator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_email")]
        public string? CreatorEmail { get; set; }

        /// <summary>
        /// Whether the creator is still a member of the organization. `null` for older keys with no recorded creator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_still_in_org")]
        public bool? CreatorStillInOrg { get; set; }

        /// <summary>
        /// URL of the creator's avatar. Returned as `null` when the creator is no longer in the organization, and for older keys with no recorded creator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_image_url")]
        public string? CreatorImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier for the API key. Safe to expose.
        /// </param>
        /// <param name="description">
        /// Human-readable description set when the key was created.
        /// </param>
        /// <param name="createdAt">
        /// When the API key was created.
        /// </param>
        /// <param name="creatorEmail">
        /// Email of the user who created the key. `null` for older keys with no recorded creator.
        /// </param>
        /// <param name="creatorStillInOrg">
        /// Whether the creator is still a member of the organization. `null` for older keys with no recorded creator.
        /// </param>
        /// <param name="creatorImageUrl">
        /// URL of the creator's avatar. Returned as `null` when the creator is no longer in the organization, and for older keys with no recorded creator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKey(
            string id,
            string description,
            global::System.DateTime createdAt,
            string? creatorEmail,
            bool? creatorStillInOrg,
            string? creatorImageUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.CreatorEmail = creatorEmail;
            this.CreatorStillInOrg = creatorStillInOrg;
            this.CreatorImageUrl = creatorImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }

    }
}