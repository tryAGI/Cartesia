#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Voices
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="isOwner"></param>
        /// <param name="gender"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetVoicesResponse> VoicesListAsync(
            global::Cartesia.VoicesListCartesiaVersion cartesiaVersion,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            bool? isOwner = default,
            global::Cartesia.GenderPresentation? gender = default,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? expand = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}