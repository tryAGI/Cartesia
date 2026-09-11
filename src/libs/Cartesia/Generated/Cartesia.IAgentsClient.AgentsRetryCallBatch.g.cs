#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Retry Call Batch<br/>
        /// Re-queues the batch's recipients whose latest call attempt failed or went unanswered, so the dispatcher dials them again. Recipients that successfully completed their call are left untouched. A cancelled batch cannot be retried.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentCallBatch> AgentsRetryCallBatchAsync(
            string batchId,
            global::Cartesia.AgentsRetryCallBatchCartesiaVersion cartesiaVersion = global::Cartesia.AgentsRetryCallBatchCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retry Call Batch<br/>
        /// Re-queues the batch's recipients whose latest call attempt failed or went unanswered, so the dispatcher dials them again. Recipients that successfully completed their call are left untouched. A cancelled batch cannot be retried.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.AgentCallBatch>> AgentsRetryCallBatchAsResponseAsync(
            string batchId,
            global::Cartesia.AgentsRetryCallBatchCartesiaVersion cartesiaVersion = global::Cartesia.AgentsRetryCallBatchCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}