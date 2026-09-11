
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request body for importing a phone number from an existing provider.<br/>
    /// The number of Cartesia phone numbers is limited by your subscription plan.
    /// </summary>
    public sealed partial class ImportPhoneNumberBody
    {
        /// <summary>
        /// A human-readable name for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The phone number in E.164 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// Reference to the provider. Pass `{ "id": "..." }` for an existing provider, or `{ "type": "twilio", "account_sid": "...", "region": "..." }` to look up by account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount> Provider { get; set; }

        /// <summary>
        /// Optionally assign an agent to answer inbound calls to this number. Omit to keep the number outbound-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportPhoneNumberBody" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-readable name for the phone number.
        /// </param>
        /// <param name="number">
        /// The phone number in E.164 format.
        /// </param>
        /// <param name="provider">
        /// Reference to the provider. Pass `{ "id": "..." }` for an existing provider, or `{ "type": "twilio", "account_sid": "...", "region": "..." }` to look up by account.
        /// </param>
        /// <param name="agentId">
        /// Optionally assign an agent to answer inbound calls to this number. Omit to keep the number outbound-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportPhoneNumberBody(
            string label,
            string number,
            global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount> provider,
            string? agentId)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.Provider = provider;
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportPhoneNumberBody" /> class.
        /// </summary>
        public ImportPhoneNumberBody()
        {
        }

    }
}