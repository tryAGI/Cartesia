#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Templates<br/>
        /// List of public, Cartesia-provided agent templates to help you get started.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetTemplatesResponse> AgentsTemplatesAsync(
            global::Cartesia.AgentsTemplatesCartesiaVersion cartesiaVersion,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}