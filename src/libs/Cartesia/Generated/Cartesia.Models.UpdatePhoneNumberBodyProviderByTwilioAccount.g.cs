
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePhoneNumberBodyProviderByTwilioAccount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdatePhoneNumberBodyProviderByTwilioAccountTypeJsonConverter))]
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberBodyProviderByTwilioAccount" /> class.
        /// </summary>
        /// <param name="accountSid"></param>
        /// <param name="type"></param>
        /// <param name="region">
        /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
        /// Default Value: us1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePhoneNumberBodyProviderByTwilioAccount(
            string accountSid,
            global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType type,
            global::Cartesia.TelephonyRegion? region)
        {
            this.Type = type;
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberBodyProviderByTwilioAccount" /> class.
        /// </summary>
        public UpdatePhoneNumberBodyProviderByTwilioAccount()
        {
        }

    }
}