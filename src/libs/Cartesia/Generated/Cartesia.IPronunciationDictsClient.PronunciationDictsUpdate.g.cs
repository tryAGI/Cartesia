#nullable enable

namespace Cartesia
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsUpdateAsync(
            global::Cartesia.PronunciationDictsUpdateCartesiaVersion cartesiaVersion,
            string id,

            global::Cartesia.UpdatePronunciationDictRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// New name for the pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// Updated list of pronunciation mappings
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsUpdateAsync(
            global::Cartesia.PronunciationDictsUpdateCartesiaVersion cartesiaVersion,
            string id,
            string? name = default,
            global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? items = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}