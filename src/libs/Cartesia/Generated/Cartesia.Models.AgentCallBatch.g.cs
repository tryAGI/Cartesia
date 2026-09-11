
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentCallBatch
    {
        /// <summary>
        /// The unique identifier for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The batch's label.
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
        /// The identifier of the phone number the batch dials from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromNumberId { get; set; }

        /// <summary>
        /// The region that handles the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AgentCallBatchRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.AgentCallBatchRegion Region { get; set; }

        /// <summary>
        /// Maximum number of calls from this batch dialed concurrently.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_concurrency_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetConcurrencyLimit { get; set; }

        /// <summary>
        /// The lifecycle status of a batch, derived at read time from dispatch progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AgentCallBatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.AgentCallBatchStatus Status { get; set; }

        /// <summary>
        /// Total recipients queued in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_scheduled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCallsScheduled { get; set; }

        /// <summary>
        /// Recipients handed to the dialer so far, including those that failed before a call could be placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_dispatched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCallsDispatched { get; set; }

        /// <summary>
        /// Recipients whose latest call attempt reached a terminal state (completed or failed), including pre-dial failures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_finished")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCallsFinished { get; set; }

        /// <summary>
        /// Number of times the batch has been retried. `0` until the first retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetryCount { get; set; }

        /// <summary>
        /// When the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the batch was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdatedAt { get; set; }

        /// <summary>
        /// The scheduled dispatch time, in RFC3339 UTC format. Omitted for batches that dispatch immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public global::System.DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// The actual dispatch time, in RFC3339 UTC format. The batch may stay unadmitted in the queue due to scheduling or unavailable concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admitted_at")]
        public global::System.DateTime? AdmittedAt { get; set; }

        /// <summary>
        /// The batch's recipients. Returned only on `GET /agents/calls/batches/{batch_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallBatch" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the batch.
        /// </param>
        /// <param name="name">
        /// The batch's label.
        /// </param>
        /// <param name="agentId">
        /// The identifier of the agent that handles the batch's calls.
        /// </param>
        /// <param name="fromNumberId">
        /// The identifier of the phone number the batch dials from.
        /// </param>
        /// <param name="region">
        /// The region that handles the batch.
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// Maximum number of calls from this batch dialed concurrently.
        /// </param>
        /// <param name="status">
        /// The lifecycle status of a batch, derived at read time from dispatch progress.
        /// </param>
        /// <param name="totalCallsScheduled">
        /// Total recipients queued in the batch.
        /// </param>
        /// <param name="totalCallsDispatched">
        /// Recipients handed to the dialer so far, including those that failed before a call could be placed.
        /// </param>
        /// <param name="totalCallsFinished">
        /// Recipients whose latest call attempt reached a terminal state (completed or failed), including pre-dial failures.
        /// </param>
        /// <param name="retryCount">
        /// Number of times the batch has been retried. `0` until the first retry.
        /// </param>
        /// <param name="createdAt">
        /// When the batch was created.
        /// </param>
        /// <param name="lastUpdatedAt">
        /// When the batch was last updated.
        /// </param>
        /// <param name="scheduledAt">
        /// The scheduled dispatch time, in RFC3339 UTC format. Omitted for batches that dispatch immediately.
        /// </param>
        /// <param name="admittedAt">
        /// The actual dispatch time, in RFC3339 UTC format. The batch may stay unadmitted in the queue due to scheduling or unavailable concurrency.
        /// </param>
        /// <param name="recipients">
        /// The batch's recipients. Returned only on `GET /agents/calls/batches/{batch_id}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCallBatch(
            string id,
            string name,
            string agentId,
            string fromNumberId,
            global::Cartesia.AgentCallBatchRegion region,
            int targetConcurrencyLimit,
            global::Cartesia.AgentCallBatchStatus status,
            int totalCallsScheduled,
            int totalCallsDispatched,
            int totalCallsFinished,
            int retryCount,
            global::System.DateTime createdAt,
            global::System.DateTime lastUpdatedAt,
            global::System.DateTime? scheduledAt,
            global::System.DateTime? admittedAt,
            global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? recipients)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.FromNumberId = fromNumberId ?? throw new global::System.ArgumentNullException(nameof(fromNumberId));
            this.Region = region;
            this.TargetConcurrencyLimit = targetConcurrencyLimit;
            this.Status = status;
            this.TotalCallsScheduled = totalCallsScheduled;
            this.TotalCallsDispatched = totalCallsDispatched;
            this.TotalCallsFinished = totalCallsFinished;
            this.RetryCount = retryCount;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.ScheduledAt = scheduledAt;
            this.AdmittedAt = admittedAt;
            this.Recipients = recipients;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallBatch" /> class.
        /// </summary>
        public AgentCallBatch()
        {
        }

    }
}