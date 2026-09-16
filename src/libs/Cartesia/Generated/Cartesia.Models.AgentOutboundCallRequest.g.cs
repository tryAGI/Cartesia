
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request body for starting outbound calls from an agent phone number.
    /// </summary>
    public sealed partial class AgentOutboundCallRequest
    {
        /// <summary>
        /// Phone number ID to place calls from. The attached provider handles outbound calling for this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromNumberId { get; set; }

        /// <summary>
        /// Agent that handles the outbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Destinations and optional per-call dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem> OutboundCalls { get; set; }

        /// <summary>
        /// Seconds to wait for the callee to answer before giving up. Omit to use  the default (60 seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_seconds")]
        public int? RingingTimeoutSeconds { get; set; }

        /// <summary>
        /// Optional maximum call duration in minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_minutes")]
        public int? MaxCallDurationMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallRequest" /> class.
        /// </summary>
        /// <param name="fromNumberId">
        /// Phone number ID to place calls from. The attached provider handles outbound calling for this number.
        /// </param>
        /// <param name="agentId">
        /// Agent that handles the outbound calls.
        /// </param>
        /// <param name="outboundCalls">
        /// Destinations and optional per-call dynamic variables
        /// </param>
        /// <param name="ringingTimeoutSeconds">
        /// Seconds to wait for the callee to answer before giving up. Omit to use  the default (60 seconds).
        /// </param>
        /// <param name="maxCallDurationMinutes">
        /// Optional maximum call duration in minutes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundCallRequest(
            string fromNumberId,
            string agentId,
            global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem> outboundCalls,
            int? ringingTimeoutSeconds,
            int? maxCallDurationMinutes)
        {
            this.FromNumberId = fromNumberId ?? throw new global::System.ArgumentNullException(nameof(fromNumberId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.OutboundCalls = outboundCalls ?? throw new global::System.ArgumentNullException(nameof(outboundCalls));
            this.RingingTimeoutSeconds = ringingTimeoutSeconds;
            this.MaxCallDurationMinutes = maxCallDurationMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallRequest" /> class.
        /// </summary>
        public AgentOutboundCallRequest()
        {
        }

    }
}