
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTwilioProviderBody
    {
        /// <summary>
        /// Must be `"twilio"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.CreateTwilioProviderBodyTypeJsonConverter))]
        public global::Cartesia.CreateTwilioProviderBodyType Type { get; set; }

        /// <summary>
        /// Your Twilio account SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// A Twilio API key SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeySid { get; set; }

        /// <summary>
        /// The corresponding API key secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeySecret { get; set; }

        /// <summary>
        /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
        /// Default Value: us1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TelephonyRegionJsonConverter))]
        public global::Cartesia.TelephonyRegion? Region { get; set; }

        /// <summary>
        /// An optional human-readable label for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioProviderBody" /> class.
        /// </summary>
        /// <param name="accountSid">
        /// Your Twilio account SID.
        /// </param>
        /// <param name="apiKeySid">
        /// A Twilio API key SID.
        /// </param>
        /// <param name="apiKeySecret">
        /// The corresponding API key secret.
        /// </param>
        /// <param name="type">
        /// Must be `"twilio"`.
        /// </param>
        /// <param name="region">
        /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
        /// Default Value: us1
        /// </param>
        /// <param name="label">
        /// An optional human-readable label for the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTwilioProviderBody(
            string accountSid,
            string apiKeySid,
            string apiKeySecret,
            global::Cartesia.CreateTwilioProviderBodyType type,
            global::Cartesia.TelephonyRegion? region,
            string? label)
        {
            this.Type = type;
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.ApiKeySid = apiKeySid ?? throw new global::System.ArgumentNullException(nameof(apiKeySid));
            this.ApiKeySecret = apiKeySecret;
            this.Region = region;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioProviderBody" /> class.
        /// </summary>
        public CreateTwilioProviderBody()
        {
        }

    }
}