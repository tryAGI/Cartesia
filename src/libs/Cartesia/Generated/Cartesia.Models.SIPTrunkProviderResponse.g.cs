
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A linked SIP trunk provider.
    /// </summary>
    public sealed partial class SIPTrunkProviderResponse
    {
        /// <summary>
        /// Always `"sip_trunk"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SIPTrunkProviderResponseTypeJsonConverter))]
        public global::Cartesia.SIPTrunkProviderResponseType Type { get; set; }

        /// <summary>
        /// Unique identifier for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A human-readable label for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Inbound configuration. Present when inbound is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound")]
        public global::Cartesia.SIPTrunkInboundDetails? Inbound { get; set; }

        /// <summary>
        /// Outbound configuration. Present when outbound is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound")]
        public global::Cartesia.SIPTrunkOutboundDetails? Outbound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkProviderResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the provider.
        /// </param>
        /// <param name="type">
        /// Always `"sip_trunk"`.
        /// </param>
        /// <param name="label">
        /// A human-readable label for the provider.
        /// </param>
        /// <param name="inbound">
        /// Inbound configuration. Present when inbound is configured.
        /// </param>
        /// <param name="outbound">
        /// Outbound configuration. Present when outbound is configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPTrunkProviderResponse(
            string id,
            global::Cartesia.SIPTrunkProviderResponseType type,
            string? label,
            global::Cartesia.SIPTrunkInboundDetails? inbound,
            global::Cartesia.SIPTrunkOutboundDetails? outbound)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label;
            this.Inbound = inbound;
            this.Outbound = outbound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkProviderResponse" /> class.
        /// </summary>
        public SIPTrunkProviderResponse()
        {
        }

    }
}