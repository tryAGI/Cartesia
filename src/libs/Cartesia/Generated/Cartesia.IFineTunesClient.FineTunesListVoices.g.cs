#nullable enable

namespace Cartesia
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// List all voices created from a fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PaginatedVoices> FineTunesListVoicesAsync(
            global::Cartesia.FineTunesListVoicesCartesiaVersion cartesiaVersion,
            string id,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}