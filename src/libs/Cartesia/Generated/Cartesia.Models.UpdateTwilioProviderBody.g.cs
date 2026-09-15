
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Update Twilio API key credentials and optionally the region. Cartesia validates the credentials and rejects the update with a list of unreachable numbers assigned to agents.
    /// </summary>
    public sealed partial class UpdateTwilioProviderBody
    {
        /// <summary>
        /// Must be `"twilio"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateTwilioProviderBodyTypeJsonConverter))]
        public global::Cartesia.UpdateTwilioProviderBodyType Type { get; set; }

        /// <summary>
        /// New Twilio API key SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeySid { get; set; }

        /// <summary>
        /// New API key secret.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioProviderBody" /> class.
        /// </summary>
        /// <param name="apiKeySid">
        /// New Twilio API key SID.
        /// </param>
        /// <param name="apiKeySecret">
        /// New API key secret.
        /// </param>
        /// <param name="type">
        /// Must be `"twilio"`.
        /// </param>
        /// <param name="region">
        /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
        /// Default Value: us1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTwilioProviderBody(
            string apiKeySid,
            string apiKeySecret,
            global::Cartesia.UpdateTwilioProviderBodyType type,
            global::Cartesia.TelephonyRegion? region)
        {
            this.Type = type;
            this.ApiKeySid = apiKeySid ?? throw new global::System.ArgumentNullException(nameof(apiKeySid));
            this.ApiKeySecret = apiKeySecret;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioProviderBody" /> class.
        /// </summary>
        public UpdateTwilioProviderBody()
        {
        }

    }
}