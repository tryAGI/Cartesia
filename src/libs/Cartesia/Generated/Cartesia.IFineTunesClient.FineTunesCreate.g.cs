#nullable enable

namespace Cartesia
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.FineTune> FineTunesCreateAsync(
            global::Cartesia.FineTunesCreateCartesiaVersion cartesiaVersion,

            global::Cartesia.CreateFineTuneRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="name">
        /// Name for the new fine-tune
        /// </param>
        /// <param name="description">
        /// Description for the fine-tune
        /// </param>
        /// <param name="language">
        /// Language code for the fine-tune
        /// </param>
        /// <param name="modelId">
        /// Base model ID to fine-tune from
        /// </param>
        /// <param name="dataset">
        /// Dataset ID containing training files
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.FineTune> FineTunesCreateAsync(
            global::Cartesia.FineTunesCreateCartesiaVersion cartesiaVersion,
            string name,
            string description,
            string language,
            string modelId,
            string dataset,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}