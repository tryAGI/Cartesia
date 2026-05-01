#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Dataset> DatasetsCreateAsync(
            global::Cartesia.DatasetsCreateCartesiaVersion cartesiaVersion,

            global::Cartesia.CreateDatasetRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="name">
        /// Name for the new dataset
        /// </param>
        /// <param name="description">
        /// Optional description for the dataset
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Dataset> DatasetsCreateAsync(
            global::Cartesia.DatasetsCreateCartesiaVersion cartesiaVersion,
            string name,
            string description,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}