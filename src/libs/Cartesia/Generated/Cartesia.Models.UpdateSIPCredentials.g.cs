
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// SIP digest authentication credentials for an update. The username is required when credentials are provided. Omit the password to keep the stored secret, or send `null` to clear the credentials.
    /// </summary>
    public sealed partial class UpdateSIPCredentials
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSIPCredentials" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSIPCredentials(
            string username,
            string? password)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSIPCredentials" /> class.
        /// </summary>
        public UpdateSIPCredentials()
        {
        }

    }
}