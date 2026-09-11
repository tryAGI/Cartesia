
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentOutboundCallResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse> Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallResponse" /> class.
        /// </summary>
        /// <param name="calls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundCallResponse(
            global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse> calls)
        {
            this.Calls = calls ?? throw new global::System.ArgumentNullException(nameof(calls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallResponse" /> class.
        /// </summary>
        public AgentOutboundCallResponse()
        {
        }

    }
}