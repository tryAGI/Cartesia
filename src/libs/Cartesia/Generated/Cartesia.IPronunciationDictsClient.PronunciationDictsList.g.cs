#nullable enable

namespace Cartesia
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// List all pronunciation dictionaries for the authenticated user
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PaginatedPronunciationDicts> PronunciationDictsListAsync(
            global::Cartesia.PronunciationDictsListCartesiaVersion cartesiaVersion,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}