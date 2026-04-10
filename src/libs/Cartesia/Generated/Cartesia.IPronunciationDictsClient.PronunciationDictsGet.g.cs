#nullable enable

namespace Cartesia
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Retrieve a specific pronunciation dictionary by ID
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsGetAsync(
            global::Cartesia.PronunciationDictsGetCartesiaVersion cartesiaVersion,
            string id,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}