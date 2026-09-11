
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An invite to join the organization
    /// </summary>
    public sealed partial class OrganizationInvite
    {
        /// <summary>
        /// When the invite was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Email address the invite was sent to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// When the invite expires, if it has an expiry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Unique identifier for the invite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Role the invited user will receive when they accept
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OrganizationInviteRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.OrganizationInviteRole Role { get; set; }

        /// <summary>
        /// Status of the invite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OrganizationInviteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.OrganizationInviteStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvite" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When the invite was created
        /// </param>
        /// <param name="email">
        /// Email address the invite was sent to
        /// </param>
        /// <param name="id">
        /// Unique identifier for the invite
        /// </param>
        /// <param name="role">
        /// Role the invited user will receive when they accept
        /// </param>
        /// <param name="status">
        /// Status of the invite
        /// </param>
        /// <param name="expiresAt">
        /// When the invite expires, if it has an expiry
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInvite(
            global::System.DateTime createdAt,
            string email,
            string id,
            global::Cartesia.OrganizationInviteRole role,
            global::Cartesia.OrganizationInviteStatus status,
            global::System.DateTime? expiresAt)
        {
            this.CreatedAt = createdAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvite" /> class.
        /// </summary>
        public OrganizationInvite()
        {
        }

    }
}