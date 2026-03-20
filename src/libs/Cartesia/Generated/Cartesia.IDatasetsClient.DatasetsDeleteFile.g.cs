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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsDeleteFileAsync(
            global::Cartesia.DatasetsDeleteFileCartesiaVersion cartesiaVersion,
            string id,
            string fileID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}