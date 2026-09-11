
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request body for queueing a batch of outbound calls.
    /// </summary>
    public sealed partial class AgentCallBatchRequest
    {
        /// <summary>
        /// A label for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The identifier of the agent that handles the batch's calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The identifier of the phone number to place calls from. The attached provider handles outbound calling for this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromNumberId { get; set; }

        /// <summary>
        /// Per-call destination and metadata configuration. Up to 5,000 recipients per batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem> Recipients { get; set; }

        /// <summary>
        /// Maximum number of calls from this batch to dial concurrently. Must not exceed the organization's concurrency limit. Omit to default to half of the organization's agent-call concurrency limit, leaving headroom for other calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_concurrency_limit")]
        public int? TargetConcurrencyLimit { get; set; }

        /// <summary>
        /// Seconds to wait for the callee to answer before giving up. Omit to use the default (60 seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_seconds")]
        public int? RingingTimeoutSeconds { get; set; }

        /// <summary>
        /// Maximum call duration in minutes. Omit to use the default (480 minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_minutes")]
        public int? MaxCallDurationMinutes { get; set; }

        /// <summary>
        /// When to start dispatching the batch, as an RFC3339 timestamp with a timezone offset (e.g. `2026-06-15T16:00:00Z`). Must be in the future and within 30 days. Omit to dispatch immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public global::System.DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// The region from which the batch's outbound calls are dispatched. Valid only when `from_number_id` is a SIP-trunk number; rejected for other telephony account types. Omit to derive the region from the telephony account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AgentCallBatchRequestRegionJsonConverter))]
        public global::Cartesia.AgentCallBatchRequestRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallBatchRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A label for the batch.
        /// </param>
        /// <param name="agentId">
        /// The identifier of the agent that handles the batch's calls.
        /// </param>
        /// <param name="fromNumberId">
        /// The identifier of the phone number to place calls from. The attached provider handles outbound calling for this number.
        /// </param>
        /// <param name="recipients">
        /// Per-call destination and metadata configuration. Up to 5,000 recipients per batch.
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// Maximum number of calls from this batch to dial concurrently. Must not exceed the organization's concurrency limit. Omit to default to half of the organization's agent-call concurrency limit, leaving headroom for other calls.
        /// </param>
        /// <param name="ringingTimeoutSeconds">
        /// Seconds to wait for the callee to answer before giving up. Omit to use the default (60 seconds).
        /// </param>
        /// <param name="maxCallDurationMinutes">
        /// Maximum call duration in minutes. Omit to use the default (480 minutes).
        /// </param>
        /// <param name="scheduledAt">
        /// When to start dispatching the batch, as an RFC3339 timestamp with a timezone offset (e.g. `2026-06-15T16:00:00Z`). Must be in the future and within 30 days. Omit to dispatch immediately.
        /// </param>
        /// <param name="region">
        /// The region from which the batch's outbound calls are dispatched. Valid only when `from_number_id` is a SIP-trunk number; rejected for other telephony account types. Omit to derive the region from the telephony account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCallBatchRequest(
            string name,
            string agentId,
            string fromNumberId,
            global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem> recipients,
            int? targetConcurrencyLimit,
            int? ringingTimeoutSeconds,
            int? maxCallDurationMinutes,
            global::System.DateTime? scheduledAt,
            global::Cartesia.AgentCallBatchRequestRegion? region)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.FromNumberId = fromNumberId ?? throw new global::System.ArgumentNullException(nameof(fromNumberId));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.TargetConcurrencyLimit = targetConcurrencyLimit;
            this.RingingTimeoutSeconds = ringingTimeoutSeconds;
            this.MaxCallDurationMinutes = maxCallDurationMinutes;
            this.ScheduledAt = scheduledAt;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallBatchRequest" /> class.
        /// </summary>
        public AgentCallBatchRequest()
        {
        }

    }
}