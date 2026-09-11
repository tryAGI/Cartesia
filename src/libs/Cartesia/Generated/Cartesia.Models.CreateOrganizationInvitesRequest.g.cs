
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request to invite users to the organization
    /// </summary>
    public sealed partial class CreateOrganizationInvitesRequest
    {
        /// <summary>
        /// Email addresses to invite, up to 10 per request. Each address receives a `member` invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationInvitesRequest" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses to invite, up to 10 per request. Each address receives a `member` invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationInvitesRequest(
            global::System.Collections.Generic.IList<string> emails)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationInvitesRequest" /> class.
        /// </summary>
        public CreateOrganizationInvitesRequest()
        {
        }

    }
}