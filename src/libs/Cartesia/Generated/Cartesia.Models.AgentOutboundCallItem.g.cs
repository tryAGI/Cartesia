
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Destination and metadata for one outbound call.
    /// </summary>
    public sealed partial class AgentOutboundCallItem
    {
        /// <summary>
        /// Destination phone number for this outbound call, in E.164 format (e.g., `+14155559876`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

        /// <summary>
        /// Custom metadata associated with this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallItem" /> class.
        /// </summary>
        /// <param name="toNumber">
        /// Destination phone number for this outbound call, in E.164 format (e.g., `+14155559876`).
        /// </param>
        /// <param name="metadata">
        /// Custom metadata associated with this call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundCallItem(
            string toNumber,
            object? metadata)
        {
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallItem" /> class.
        /// </summary>
        public AgentOutboundCallItem()
        {
        }

    }
}