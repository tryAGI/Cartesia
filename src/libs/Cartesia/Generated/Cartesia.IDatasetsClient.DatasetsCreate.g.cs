#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Dataset> DatasetsCreateAsync(
            global::Cartesia.DatasetsCreateCartesiaVersion cartesiaVersion,

            global::Cartesia.CreateDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="name">
        /// Name for the new dataset
        /// </param>
        /// <param name="description">
        /// Optional description for the dataset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Dataset> DatasetsCreateAsync(
            global::Cartesia.DatasetsCreateCartesiaVersion cartesiaVersion,
            string name,
            string description,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}