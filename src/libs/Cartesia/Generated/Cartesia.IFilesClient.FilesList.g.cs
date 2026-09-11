#nullable enable

namespace Cartesia
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Paginated list of your uploaded files.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="purpose">
        /// What a file is used for.
        /// </param>
        /// <param name="q">
        /// Example: background
        /// </param>
        /// <param name="limit">
        /// Example: 10
        /// </param>
        /// <param name="startingAfter">
        /// Example: file_EneDabCuJCpfe5CFi5X12e
        /// </param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PaginatedFiles> FilesListAsync(
            global::Cartesia.FilesListCartesiaVersion cartesiaVersion = global::Cartesia.FilesListCartesiaVersion.x20260814,
            global::Cartesia.FilePurpose? purpose = default,
            string? q = default,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Paginated list of your uploaded files.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="purpose">
        /// What a file is used for.
        /// </param>
        /// <param name="q">
        /// Example: background
        /// </param>
        /// <param name="limit">
        /// Example: 10
        /// </param>
        /// <param name="startingAfter">
        /// Example: file_EneDabCuJCpfe5CFi5X12e
        /// </param>
        /// <param name="endingBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PaginatedFiles>> FilesListAsResponseAsync(
            global::Cartesia.FilesListCartesiaVersion cartesiaVersion = global::Cartesia.FilesListCartesiaVersion.x20260814,
            global::Cartesia.FilePurpose? purpose = default,
            string? q = default,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}