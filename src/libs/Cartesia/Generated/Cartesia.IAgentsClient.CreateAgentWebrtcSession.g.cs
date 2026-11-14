#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create a WebRTC session<br/>
        /// Creates a WebRTC session on your trusted server and returns credentials for the browser to join. Authenticate this request with an API key; access tokens, including returned session tokens, cannot create sessions.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.CreateAgentWebrtcSessionResponse> CreateAgentWebrtcSessionAsync(
            string agentId,

            global::Cartesia.CreateAgentWebSessionRequest request,
            global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion cartesiaVersion = global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a WebRTC session<br/>
        /// Creates a WebRTC session on your trusted server and returns credentials for the browser to join. Authenticate this request with an API key; access tokens, including returned session tokens, cannot create sessions.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.CreateAgentWebrtcSessionResponse>> CreateAgentWebrtcSessionAsResponseAsync(
            string agentId,

            global::Cartesia.CreateAgentWebSessionRequest request,
            global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion cartesiaVersion = global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a WebRTC session<br/>
        /// Creates a WebRTC session on your trusted server and returns credentials for the browser to join. Authenticate this request with an API key; access tokens, including returned session tokens, cannot create sessions.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="dynamicVariables">
        /// Trusted values that Cartesia stores on the call and supplies to the agent.
        /// </param>
        /// <param name="configOverrides">
        /// Per-call overrides using the same field structure as agent configuration. Omitted fields use the agent's published configuration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.CreateAgentWebrtcSessionResponse> CreateAgentWebrtcSessionAsync(
            string agentId,
            global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion cartesiaVersion = global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion.x20260814,
            object? dynamicVariables = default,
            global::Cartesia.AgentSessionConfig? configOverrides = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}