
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A linked Twilio account. The `api_key_sid` field is partially masked in responses.
    /// </summary>
    public sealed partial class TwilioProviderResponse
    {
        /// <summary>
        /// Always `"twilio"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TwilioProviderResponseTypeJsonConverter))]
        public global::Cartesia.TwilioProviderResponseType Type { get; set; }

        /// <summary>
        /// Unique identifier for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Twilio account SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// The Twilio API key SID (partially masked).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeySid { get; set; }

        /// <summary>
        /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
        /// Default Value: us1
        /// </summary>
        /// <default>global::Cartesia.TelephonyRegion.Us1</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TelephonyRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.TelephonyRegion Region { get; set; } = global::Cartesia.TelephonyRegion.Us1;

        /// <summary>
        /// A human-readable label for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioProviderResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the provider.
        /// </param>
        /// <param name="accountSid">
        /// The Twilio account SID.
        /// </param>
        /// <param name="apiKeySid">
        /// The Twilio API key SID (partially masked).
        /// </param>
        /// <param name="region">
        /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
        /// Default Value: us1
        /// </param>
        /// <param name="type">
        /// Always `"twilio"`.
        /// </param>
        /// <param name="label">
        /// A human-readable label for the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioProviderResponse(
            string id,
            string accountSid,
            string apiKeySid,
            global::Cartesia.TelephonyRegion region,
            global::Cartesia.TwilioProviderResponseType type,
            string? label)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.ApiKeySid = apiKeySid ?? throw new global::System.ArgumentNullException(nameof(apiKeySid));
            this.Region = region;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioProviderResponse" /> class.
        /// </summary>
        public TwilioProviderResponse()
        {
        }

    }
}