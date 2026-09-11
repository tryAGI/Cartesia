
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Fields to update on a phone number. All fields are optional. Set `agent_id` to `null` to unassign the current agent.
    /// </summary>
    public sealed partial class UpdatePhoneNumberBody
    {
        /// <summary>
        /// A new human-readable name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Assign an agent to answer inbound calls to this number, or `null` to unassign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Change the provider. Pass `{ "id": "..." }` for an existing provider, or pass Twilio account fields for lookup convenience. For Twilio, the phone number must exist in the target provider account. For SIP trunk providers, Cartesia handles reassignment between SIP providers. Switching between provider types is not supported; delete and re-import the number instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>))]
        public global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberBody" /> class.
        /// </summary>
        /// <param name="label">
        /// A new human-readable name.
        /// </param>
        /// <param name="agentId">
        /// Assign an agent to answer inbound calls to this number, or `null` to unassign.
        /// </param>
        /// <param name="provider">
        /// Change the provider. Pass `{ "id": "..." }` for an existing provider, or pass Twilio account fields for lookup convenience. For Twilio, the phone number must exist in the target provider account. For SIP trunk providers, Cartesia handles reassignment between SIP providers. Switching between provider types is not supported; delete and re-import the number instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePhoneNumberBody(
            string? label,
            string? agentId,
            global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? provider)
        {
            this.Label = label;
            this.AgentId = agentId;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberBody" /> class.
        /// </summary>
        public UpdatePhoneNumberBody()
        {
        }

    }
}