
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Outbound SIP configuration for creating a trunk.
    /// </summary>
    public sealed partial class OutboundSIPTrunkConfig
    {
        /// <summary>
        /// SIP server hostname or address used for outbound signaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Transport for outbound SIP signaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPTrunkTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.SIPTrunkTransport Transport { get; set; }

        /// <summary>
        /// Two-letter country code for the country the call terminates in (e.g. `US`, `GB`, `DE`). See [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_country")]
        public string? DestinationCountry { get; set; }

        /// <summary>
        /// Media encryption policy. Defaults to `disabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter))]
        public global::Cartesia.SIPMediaEncryption? MediaEncryption { get; set; }

        /// <summary>
        /// SIP digest authentication credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Cartesia.SIPCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundSIPTrunkConfig" /> class.
        /// </summary>
        /// <param name="address">
        /// SIP server hostname or address used for outbound signaling.
        /// </param>
        /// <param name="transport">
        /// Transport for outbound SIP signaling.
        /// </param>
        /// <param name="destinationCountry">
        /// Two-letter country code for the country the call terminates in (e.g. `US`, `GB`, `DE`). See [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
        /// </param>
        /// <param name="mediaEncryption">
        /// Media encryption policy. Defaults to `disabled`.
        /// </param>
        /// <param name="credentials">
        /// SIP digest authentication credentials.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutboundSIPTrunkConfig(
            string address,
            global::Cartesia.SIPTrunkTransport transport,
            string? destinationCountry,
            global::Cartesia.SIPMediaEncryption? mediaEncryption,
            global::Cartesia.SIPCredentials? credentials)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Transport = transport;
            this.DestinationCountry = destinationCountry;
            this.MediaEncryption = mediaEncryption;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundSIPTrunkConfig" /> class.
        /// </summary>
        public OutboundSIPTrunkConfig()
        {
        }

    }
}