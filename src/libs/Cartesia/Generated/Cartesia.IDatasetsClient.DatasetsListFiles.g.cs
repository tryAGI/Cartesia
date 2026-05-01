#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Paginated list of files in a dataset
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PaginatedDatasetFiles> DatasetsListFilesAsync(
            global::Cartesia.DatasetsListFilesCartesiaVersion cartesiaVersion,
            string id,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}