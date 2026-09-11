
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request body for provisioning a new Cartesia-managed phone number.
    /// </summary>
    public sealed partial class ProvisionPhoneNumberBody
    {
        /// <summary>
        /// A human-readable name for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

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
        /// Initializes a new instance of the <see cref="ProvisionPhoneNumberBody" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-readable name for the phone number.
        /// </param>
        /// <param name="agentId">
        /// Optionally assign an agent to answer inbound calls to this number. Omit to keep the number outbound-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvisionPhoneNumberBody(
            string label,
            string? agentId)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionPhoneNumberBody" /> class.
        /// </summary>
        public ProvisionPhoneNumberBody()
        {
        }

    }
}