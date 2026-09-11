
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Inbound SIP configuration for creating a trunk.
    /// </summary>
    public sealed partial class InboundSIPTrunkConfig
    {
        /// <summary>
        /// SIP digest authentication credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Cartesia.SIPCredentials? Credentials { get; set; }

        /// <summary>
        /// Source IP addresses or CIDR ranges allowed to send SIP traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_addresses")]
        public global::System.Collections.Generic.IList<string>? AllowedAddresses { get; set; }

        /// <summary>
        /// Caller numbers allowed on inbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_numbers")]
        public global::System.Collections.Generic.IList<string>? AllowedNumbers { get; set; }

        /// <summary>
        /// Media encryption policy. Defaults to `allowed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter))]
        public global::Cartesia.SIPMediaEncryption? MediaEncryption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundSIPTrunkConfig" /> class.
        /// </summary>
        /// <param name="credentials">
        /// SIP digest authentication credentials.
        /// </param>
        /// <param name="allowedAddresses">
        /// Source IP addresses or CIDR ranges allowed to send SIP traffic.
        /// </param>
        /// <param name="allowedNumbers">
        /// Caller numbers allowed on inbound calls.
        /// </param>
        /// <param name="mediaEncryption">
        /// Media encryption policy. Defaults to `allowed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboundSIPTrunkConfig(
            global::Cartesia.SIPCredentials? credentials,
            global::System.Collections.Generic.IList<string>? allowedAddresses,
            global::System.Collections.Generic.IList<string>? allowedNumbers,
            global::Cartesia.SIPMediaEncryption? mediaEncryption)
        {
            this.Credentials = credentials;
            this.AllowedAddresses = allowedAddresses;
            this.AllowedNumbers = allowedNumbers;
            this.MediaEncryption = mediaEncryption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundSIPTrunkConfig" /> class.
        /// </summary>
        public InboundSIPTrunkConfig()
        {
        }

    }
}