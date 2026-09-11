#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Voices
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="isOwner"></param>
        /// <param name="gender"></param>
        /// <param name="language"></param>
        /// <param name="includeArchived"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetVoicesResponse> VoicesListAsync(
            global::Cartesia.VoicesListCartesiaVersion cartesiaVersion = global::Cartesia.VoicesListCartesiaVersion.x20260814,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            bool? isOwner = default,
            global::Cartesia.GenderPresentation? gender = default,
            string? language = default,
            bool? includeArchived = default,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? expand = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Voices
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="isOwner"></param>
        /// <param name="gender"></param>
        /// <param name="language"></param>
        /// <param name="includeArchived"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.GetVoicesResponse>> VoicesListAsResponseAsync(
            global::Cartesia.VoicesListCartesiaVersion cartesiaVersion = global::Cartesia.VoicesListCartesiaVersion.x20260814,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            bool? isOwner = default,
            global::Cartesia.GenderPresentation? gender = default,
            string? language = default,
            bool? includeArchived = default,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? expand = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}