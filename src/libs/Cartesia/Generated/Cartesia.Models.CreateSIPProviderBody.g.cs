
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Link a SIP trunk provider. At least one of `inbound` or `outbound` is required.
    /// </summary>
    public sealed partial class CreateSIPProviderBody
    {
        /// <summary>
        /// Must be `"sip_trunk"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.CreateSIPProviderBodyTypeJsonConverter))]
        public global::Cartesia.CreateSIPProviderBodyType Type { get; set; }

        /// <summary>
        /// A human-readable label for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Inbound SIP configuration for creating a trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound")]
        public global::Cartesia.InboundSIPTrunkConfig? Inbound { get; set; }

        /// <summary>
        /// Outbound SIP configuration for creating a trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound")]
        public global::Cartesia.OutboundSIPTrunkConfig? Outbound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPProviderBody" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-readable label for the provider.
        /// </param>
        /// <param name="type">
        /// Must be `"sip_trunk"`.
        /// </param>
        /// <param name="inbound">
        /// Inbound SIP configuration for creating a trunk.
        /// </param>
        /// <param name="outbound">
        /// Outbound SIP configuration for creating a trunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSIPProviderBody(
            string label,
            global::Cartesia.CreateSIPProviderBodyType type,
            global::Cartesia.InboundSIPTrunkConfig? inbound,
            global::Cartesia.OutboundSIPTrunkConfig? outbound)
        {
            this.Type = type;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Inbound = inbound;
            this.Outbound = outbound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPProviderBody" /> class.
        /// </summary>
        public CreateSIPProviderBody()
        {
        }

    }
}