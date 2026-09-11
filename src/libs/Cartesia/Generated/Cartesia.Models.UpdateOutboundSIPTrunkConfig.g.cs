
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Outbound SIP configuration for updating a trunk. `address` and `transport` are immutable on an existing outbound trunk, but required when adding outbound to an inbound-only provider.
    /// </summary>
    public sealed partial class UpdateOutboundSIPTrunkConfig
    {
        /// <summary>
        /// Required only when adding outbound to an inbound-only provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Required only when adding outbound to an inbound-only provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPTrunkTransportJsonConverter))]
        public global::Cartesia.SIPTrunkTransport? Transport { get; set; }

        /// <summary>
        /// Send `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_country")]
        public string? DestinationCountry { get; set; }

        /// <summary>
        /// Media encryption policy. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter))]
        public global::Cartesia.SIPMediaEncryption? MediaEncryption { get; set; }

        /// <summary>
        /// SIP digest authentication credentials for an update. The username is required when credentials are provided. Omit the password to keep the stored secret, or send `null` to clear the credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Cartesia.UpdateSIPCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOutboundSIPTrunkConfig" /> class.
        /// </summary>
        /// <param name="address">
        /// Required only when adding outbound to an inbound-only provider.
        /// </param>
        /// <param name="transport">
        /// Required only when adding outbound to an inbound-only provider.
        /// </param>
        /// <param name="destinationCountry">
        /// Send `null` to clear.
        /// </param>
        /// <param name="mediaEncryption">
        /// Media encryption policy. Omit to leave unchanged.
        /// </param>
        /// <param name="credentials">
        /// SIP digest authentication credentials for an update. The username is required when credentials are provided. Omit the password to keep the stored secret, or send `null` to clear the credentials.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOutboundSIPTrunkConfig(
            string? address,
            global::Cartesia.SIPTrunkTransport? transport,
            string? destinationCountry,
            global::Cartesia.SIPMediaEncryption? mediaEncryption,
            global::Cartesia.UpdateSIPCredentials? credentials)
        {
            this.Address = address;
            this.Transport = transport;
            this.DestinationCountry = destinationCountry;
            this.MediaEncryption = mediaEncryption;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOutboundSIPTrunkConfig" /> class.
        /// </summary>
        public UpdateOutboundSIPTrunkConfig()
        {
        }

    }
}