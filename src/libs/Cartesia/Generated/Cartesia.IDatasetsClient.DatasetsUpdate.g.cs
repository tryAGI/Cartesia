#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update an existing dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsUpdateAsync(
            global::Cartesia.DatasetsUpdateCartesiaVersion cartesiaVersion,
            string id,

            global::Cartesia.UpdateDatasetRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id"></param>
        /// <param name="name">
        /// New name for the dataset
        /// </param>
        /// <param name="description">
        /// New description for the dataset
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DatasetsUpdateAsync(
            global::Cartesia.DatasetsUpdateCartesiaVersion cartesiaVersion,
            string id,
            string name,
            string description,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}