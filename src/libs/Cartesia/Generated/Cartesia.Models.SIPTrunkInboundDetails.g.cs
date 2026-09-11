
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Inbound SIP configuration. Passwords are never returned; only the configured username is exposed as `auth_username`.
    /// </summary>
    public sealed partial class SIPTrunkInboundDetails
    {
        /// <summary>
        /// Source IP addresses or CIDR ranges allowed to send SIP traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedAddresses { get; set; }

        /// <summary>
        /// Caller numbers allowed on inbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedNumbers { get; set; }

        /// <summary>
        /// SIP username returned without the password.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthUsername { get; set; }

        /// <summary>
        /// Media encryption policy. Defaults to `allowed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.SIPMediaEncryption MediaEncryption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkInboundDetails" /> class.
        /// </summary>
        /// <param name="allowedAddresses">
        /// Source IP addresses or CIDR ranges allowed to send SIP traffic.
        /// </param>
        /// <param name="allowedNumbers">
        /// Caller numbers allowed on inbound calls.
        /// </param>
        /// <param name="authUsername">
        /// SIP username returned without the password.
        /// </param>
        /// <param name="mediaEncryption">
        /// Media encryption policy. Defaults to `allowed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPTrunkInboundDetails(
            global::System.Collections.Generic.IList<string> allowedAddresses,
            global::System.Collections.Generic.IList<string> allowedNumbers,
            string authUsername,
            global::Cartesia.SIPMediaEncryption mediaEncryption)
        {
            this.AllowedAddresses = allowedAddresses ?? throw new global::System.ArgumentNullException(nameof(allowedAddresses));
            this.AllowedNumbers = allowedNumbers ?? throw new global::System.ArgumentNullException(nameof(allowedNumbers));
            this.AuthUsername = authUsername ?? throw new global::System.ArgumentNullException(nameof(authUsername));
            this.MediaEncryption = mediaEncryption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkInboundDetails" /> class.
        /// </summary>
        public SIPTrunkInboundDetails()
        {
        }

    }
}