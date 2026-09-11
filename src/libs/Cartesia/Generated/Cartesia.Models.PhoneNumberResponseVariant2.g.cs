
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneNumberResponseVariant2
    {
        /// <summary>
        /// The telephony provider associated with a phone number. One of `Twilio`, `Cartesia`, or `SIP Trunk`, determined by the `type` field. For SIP trunk numbers, `inbound` and `outbound` are not returned here — use `GET /agents/phone-numbers/providers/{id}` to retrieve them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ProviderResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ProviderResponse Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberResponseVariant2" /> class.
        /// </summary>
        /// <param name="provider">
        /// The telephony provider associated with a phone number. One of `Twilio`, `Cartesia`, or `SIP Trunk`, determined by the `type` field. For SIP trunk numbers, `inbound` and `outbound` are not returned here — use `GET /agents/phone-numbers/providers/{id}` to retrieve them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberResponseVariant2(
            global::Cartesia.ProviderResponse provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberResponseVariant2" /> class.
        /// </summary>
        public PhoneNumberResponseVariant2()
        {
        }

    }
}