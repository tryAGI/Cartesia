#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload a new file to a dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsUploadFileAsync(
            global::Cartesia.DatasetsUploadFileCartesiaVersion cartesiaVersion,
            string id,

            global::Cartesia.DatasetsUploadFileRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a new file to a dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="purpose">
        /// Purpose of the file (e.g., fine_tune)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DatasetsUploadFileAsync(
            global::Cartesia.DatasetsUploadFileCartesiaVersion cartesiaVersion,
            string id,
            byte[]? file = default,
            string? filename = default,
            string? purpose = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}