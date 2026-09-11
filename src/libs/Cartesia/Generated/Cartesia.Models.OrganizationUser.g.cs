
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A user in the organization
    /// </summary>
    public sealed partial class OrganizationUser
    {
        /// <summary>
        /// When the user joined the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Primary email address of the user, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Stable identifier for the user. Safe to pass to [Get User](/api-reference/organizations/get-user) and [Remove User](/api-reference/organizations/remove-user).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Profile image URL for the user, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Full name of the user, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Role of a user in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OrganizationUserRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.OrganizationUserRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUser" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When the user joined the organization
        /// </param>
        /// <param name="id">
        /// Stable identifier for the user. Safe to pass to [Get User](/api-reference/organizations/get-user) and [Remove User](/api-reference/organizations/remove-user).
        /// </param>
        /// <param name="role">
        /// Role of a user in the organization
        /// </param>
        /// <param name="email">
        /// Primary email address of the user, if available
        /// </param>
        /// <param name="imageUrl">
        /// Profile image URL for the user, if available
        /// </param>
        /// <param name="name">
        /// Full name of the user, if available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUser(
            global::System.DateTime createdAt,
            string id,
            global::Cartesia.OrganizationUserRole role,
            string? email,
            string? imageUrl,
            string? name)
        {
            this.CreatedAt = createdAt;
            this.Email = email;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ImageUrl = imageUrl;
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUser" /> class.
        /// </summary>
        public OrganizationUser()
        {
        }

    }
}