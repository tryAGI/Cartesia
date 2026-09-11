#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Cancel Call<br/>
        /// Terminates an active call. Only calls in the `started` status can be cancelled; the call ends with end reason `api_cancelled`.<br/>
        /// Cancelling ends the call but does not delete its data. To delete a call's sensitive data after it ends, use `DELETE /agents/calls/{call_id}`.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentsCancelCallResponse> AgentsCancelCallAsync(
            string callId,
            global::Cartesia.AgentsCancelCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCancelCallCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Call<br/>
        /// Terminates an active call. Only calls in the `started` status can be cancelled; the call ends with end reason `api_cancelled`.<br/>
        /// Cancelling ends the call but does not delete its data. To delete a call's sensitive data after it ends, use `DELETE /agents/calls/{call_id}`.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.AgentsCancelCallResponse>> AgentsCancelCallAsResponseAsync(
            string callId,
            global::Cartesia.AgentsCancelCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCancelCallCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}