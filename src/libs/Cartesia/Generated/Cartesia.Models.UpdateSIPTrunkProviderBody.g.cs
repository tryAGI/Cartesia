
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Update a SIP trunk provider's inbound and/or outbound configuration. Merge-patch semantics: omitted fields are unchanged. To add outbound to an inbound-only provider, send `outbound` with both `address` and `transport`.
    /// </summary>
    public sealed partial class UpdateSIPTrunkProviderBody
    {
        /// <summary>
        /// Must be `"sip_trunk"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateSIPTrunkProviderBodyTypeJsonConverter))]
        public global::Cartesia.UpdateSIPTrunkProviderBodyType Type { get; set; }

        /// <summary>
        /// A new human-readable label for the provider. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Inbound SIP configuration for updating a trunk. Omitted fields remain unchanged. Send `[]` to clear an allowlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound")]
        public global::Cartesia.UpdateInboundSIPTrunkConfig? Inbound { get; set; }

        /// <summary>
        /// Outbound SIP configuration for updating a trunk. `address` and `transport` are immutable on an existing outbound trunk, but required when adding outbound to an inbound-only provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound")]
        public global::Cartesia.UpdateOutboundSIPTrunkConfig? Outbound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSIPTrunkProviderBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be `"sip_trunk"`.
        /// </param>
        /// <param name="label">
        /// A new human-readable label for the provider. Omit to leave unchanged.
        /// </param>
        /// <param name="inbound">
        /// Inbound SIP configuration for updating a trunk. Omitted fields remain unchanged. Send `[]` to clear an allowlist.
        /// </param>
        /// <param name="outbound">
        /// Outbound SIP configuration for updating a trunk. `address` and `transport` are immutable on an existing outbound trunk, but required when adding outbound to an inbound-only provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSIPTrunkProviderBody(
            global::Cartesia.UpdateSIPTrunkProviderBodyType type,
            string? label,
            global::Cartesia.UpdateInboundSIPTrunkConfig? inbound,
            global::Cartesia.UpdateOutboundSIPTrunkConfig? outbound)
        {
            this.Type = type;
            this.Label = label;
            this.Inbound = inbound;
            this.Outbound = outbound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSIPTrunkProviderBody" /> class.
        /// </summary>
        public UpdateSIPTrunkProviderBody()
        {
        }

    }
}