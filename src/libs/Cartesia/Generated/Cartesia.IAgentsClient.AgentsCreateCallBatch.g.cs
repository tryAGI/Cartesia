#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create Call Batch<br/>
        /// Queues a batch of outbound calls. Calls are issued gradually, subject to the organization's and the batch's concurrency limits.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentCallBatch> AgentsCreateCallBatchAsync(

            global::Cartesia.AgentCallBatchRequest request,
            global::Cartesia.AgentsCreateCallBatchCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCreateCallBatchCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Call Batch<br/>
        /// Queues a batch of outbound calls. Calls are issued gradually, subject to the organization's and the batch's concurrency limits.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.AgentCallBatch>> AgentsCreateCallBatchAsResponseAsync(

            global::Cartesia.AgentCallBatchRequest request,
            global::Cartesia.AgentsCreateCallBatchCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCreateCallBatchCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Call Batch<br/>
        /// Queues a batch of outbound calls. Calls are issued gradually, subject to the organization's and the batch's concurrency limits.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
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
        /// Destinations and optional per-call dynamic variables
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentCallBatch> AgentsCreateCallBatchAsync(
            string name,
            string agentId,
            string fromNumberId,
            global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem> recipients,
            global::Cartesia.AgentsCreateCallBatchCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCreateCallBatchCartesiaVersion.x20260814,
            int? targetConcurrencyLimit = default,
            int? ringingTimeoutSeconds = default,
            int? maxCallDurationMinutes = default,
            global::System.DateTime? scheduledAt = default,
            global::Cartesia.AgentCallBatchRequestRegion? region = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}