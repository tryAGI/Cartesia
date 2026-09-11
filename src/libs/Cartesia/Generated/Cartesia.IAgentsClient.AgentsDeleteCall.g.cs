#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete Call<br/>
        /// Deletes the sensitive data for a call, including the transcript, audio recordings, and logs. The call record is retained with non-sensitive operational metadata; deleted fields are omitted from subsequent API responses, and `redacted_at` marks when deletion occurred. Deletion cannot be undone.<br/>
        /// Only completed or failed calls can be deleted. Cancel an active call first via `POST /agents/calls/{call_id}/cancel`.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentCall> AgentsDeleteCallAsync(
            string callId,
            global::Cartesia.AgentsDeleteCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsDeleteCallCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Call<br/>
        /// Deletes the sensitive data for a call, including the transcript, audio recordings, and logs. The call record is retained with non-sensitive operational metadata; deleted fields are omitted from subsequent API responses, and `redacted_at` marks when deletion occurred. Deletion cannot be undone.<br/>
        /// Only completed or failed calls can be deleted. Cancel an active call first via `POST /agents/calls/{call_id}/cancel`.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.AgentCall>> AgentsDeleteCallAsResponseAsync(
            string callId,
            global::Cartesia.AgentsDeleteCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsDeleteCallCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}