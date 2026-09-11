#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Paginated list of files in a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PaginatedDatasetFiles> DatasetsListFilesAsync(
            string id,
            global::Cartesia.DatasetsListFilesCartesiaVersion cartesiaVersion = global::Cartesia.DatasetsListFilesCartesiaVersion.x20260814,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Paginated list of files in a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PaginatedDatasetFiles>> DatasetsListFilesAsResponseAsync(
            string id,
            global::Cartesia.DatasetsListFilesCartesiaVersion cartesiaVersion = global::Cartesia.DatasetsListFilesCartesiaVersion.x20260814,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}