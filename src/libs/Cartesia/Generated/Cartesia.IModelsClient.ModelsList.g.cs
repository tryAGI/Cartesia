#nullable enable

namespace Cartesia
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Models<br/>
        /// List callable Sonic (TTS) and Ink (STT) model ids.
        /// </summary>
        /// <param name="capability"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ListModelsResponse> ModelsListAsync(
            global::Cartesia.ModelsListCapability? capability = default,
            global::Cartesia.ModelsListCartesiaVersion cartesiaVersion = global::Cartesia.ModelsListCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Models<br/>
        /// List callable Sonic (TTS) and Ink (STT) model ids.
        /// </summary>
        /// <param name="capability"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ListModelsResponse>> ModelsListAsResponseAsync(
            global::Cartesia.ModelsListCapability? capability = default,
            global::Cartesia.ModelsListCartesiaVersion cartesiaVersion = global::Cartesia.ModelsListCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}