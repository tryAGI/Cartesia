#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update Agent
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentSummary> AgentsUpdateAsync(
            string agentId,

            global::Cartesia.UpdateAgentRequest request,
            global::Cartesia.AgentsUpdateCartesiaVersion cartesiaVersion = global::Cartesia.AgentsUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.AgentSummary>> AgentsUpdateAsResponseAsync(
            string agentId,

            global::Cartesia.UpdateAgentRequest request,
            global::Cartesia.AgentsUpdateCartesiaVersion cartesiaVersion = global::Cartesia.AgentsUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="ttsVoice">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="ttsLanguage">
        /// The language to use for text-to-speech.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AgentSummary> AgentsUpdateAsync(
            string agentId,
            global::Cartesia.AgentsUpdateCartesiaVersion cartesiaVersion = global::Cartesia.AgentsUpdateCartesiaVersion.x20260814,
            string? name = default,
            string? description = default,
            string? ttsVoice = default,
            string? ttsLanguage = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}