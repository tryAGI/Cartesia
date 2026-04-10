#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Remove a file from a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="fileID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsDeleteFileAsync(
            global::Cartesia.DatasetsDeleteFileCartesiaVersion cartesiaVersion,
            string id,
            string fileID,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}