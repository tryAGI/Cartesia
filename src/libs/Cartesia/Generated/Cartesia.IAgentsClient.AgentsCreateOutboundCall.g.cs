#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create Outbound Call
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentOutboundCallResponse> AgentsCreateOutboundCallAsync(

            global::Cartesia.AgentOutboundCallRequest request,
            global::Cartesia.AgentsCreateOutboundCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCreateOutboundCallCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Outbound Call
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.AgentOutboundCallResponse>> AgentsCreateOutboundCallAsResponseAsync(

            global::Cartesia.AgentOutboundCallRequest request,
            global::Cartesia.AgentsCreateOutboundCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCreateOutboundCallCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Outbound Call
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentOutboundCallResponse> AgentsCreateOutboundCallAsync(
            string fromNumberId,
            string agentId,
            global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem> outboundCalls,
            global::Cartesia.AgentsCreateOutboundCallCartesiaVersion cartesiaVersion = global::Cartesia.AgentsCreateOutboundCallCartesiaVersion.x20260814,
            int? ringingTimeoutSeconds = default,
            int? maxCallDurationMinutes = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}