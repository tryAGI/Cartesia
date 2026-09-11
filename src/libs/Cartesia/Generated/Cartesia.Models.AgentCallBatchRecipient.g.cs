
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// One recipient within a batch and its current status. Returned only on batch detail reads.
    /// </summary>
    public sealed partial class AgentCallBatchRecipient
    {
        /// <summary>
        /// The unique identifier for the recipient within the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Destination phone number, in E.164 format (e.g., `+14155559876`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

        /// <summary>
        /// The status of a recipient within a batch. Before dispatch it reflects the queue state; after dispatch it reflects the latest call attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The agent call ID, used to fetch per-call information via [Get Call](/api-reference/agents/calls/get-call). Set once the call has been dispatched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_call_id")]
        public string? AgentCallId { get; set; }

        /// <summary>
        /// A machine-readable enum indicating why a call ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.EndReasonJsonConverter))]
        public global::Cartesia.EndReason? EndReason { get; set; }

        /// <summary>
        /// Why the request failed before a call could be placed. Returned in place of `agent_call_id` when the recipient never reached a dial attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Custom metadata associated with this recipient.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// When the recipient was queued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallBatchRecipient" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the recipient within the batch.
        /// </param>
        /// <param name="toNumber">
        /// Destination phone number, in E.164 format (e.g., `+14155559876`).
        /// </param>
        /// <param name="status">
        /// The status of a recipient within a batch. Before dispatch it reflects the queue state; after dispatch it reflects the latest call attempt.
        /// </param>
        /// <param name="createdAt">
        /// When the recipient was queued.
        /// </param>
        /// <param name="agentCallId">
        /// The agent call ID, used to fetch per-call information via [Get Call](/api-reference/agents/calls/get-call). Set once the call has been dispatched.
        /// </param>
        /// <param name="endReason">
        /// A machine-readable enum indicating why a call ended.
        /// </param>
        /// <param name="errorMessage">
        /// Why the request failed before a call could be placed. Returned in place of `agent_call_id` when the recipient never reached a dial attempt.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata associated with this recipient.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCallBatchRecipient(
            string id,
            string toNumber,
            string status,
            global::System.DateTime createdAt,
            string? agentCallId,
            global::Cartesia.EndReason? endReason,
            string? errorMessage,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.AgentCallId = agentCallId;
            this.EndReason = endReason;
            this.ErrorMessage = errorMessage;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallBatchRecipient" /> class.
        /// </summary>
        public AgentCallBatchRecipient()
        {
        }

    }
}