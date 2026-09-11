
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Outbound SIP configuration. Passwords are never returned; only the configured username is exposed as `auth_username`.
    /// </summary>
    public sealed partial class SIPTrunkOutboundDetails
    {
        /// <summary>
        /// SIP server hostname or address used for outbound signaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 alpha-2 destination country code, or an empty string if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_country")]
        public string? DestinationCountry { get; set; }

        /// <summary>
        /// Transport for outbound SIP signaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPTrunkTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.SIPTrunkTransport Transport { get; set; }

        /// <summary>
        /// Media encryption policy. Defaults to `disabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.SIPMediaEncryption MediaEncryption { get; set; }

        /// <summary>
        /// SIP username returned without the password.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkOutboundDetails" /> class.
        /// </summary>
        /// <param name="address">
        /// SIP server hostname or address used for outbound signaling.
        /// </param>
        /// <param name="transport">
        /// Transport for outbound SIP signaling.
        /// </param>
        /// <param name="mediaEncryption">
        /// Media encryption policy. Defaults to `disabled`.
        /// </param>
        /// <param name="authUsername">
        /// SIP username returned without the password.
        /// </param>
        /// <param name="destinationCountry">
        /// Two-letter ISO 3166-1 alpha-2 destination country code, or an empty string if not set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPTrunkOutboundDetails(
            string address,
            global::Cartesia.SIPTrunkTransport transport,
            global::Cartesia.SIPMediaEncryption mediaEncryption,
            string authUsername,
            string? destinationCountry)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.DestinationCountry = destinationCountry;
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.AuthUsername = authUsername ?? throw new global::System.ArgumentNullException(nameof(authUsername));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkOutboundDetails" /> class.
        /// </summary>
        public SIPTrunkOutboundDetails()
        {
        }

    }
}