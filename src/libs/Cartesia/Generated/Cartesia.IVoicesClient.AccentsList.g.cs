#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Accents<br/>
        /// Retrieve all supported accents, including which ones you can localize a voice into. Filter with `is_localizable`, `language`, and `locale`. If you pass more than one, every filter has to match.
        /// </summary>
        /// <param name="isLocalizable"></param>
        /// <param name="language"></param>
        /// <param name="locale"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ListAccentsResponse> AccentsListAsync(
            bool? isLocalizable = default,
            string? language = default,
            string? locale = default,
            global::Cartesia.AccentsListCartesiaVersion cartesiaVersion = global::Cartesia.AccentsListCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Accents<br/>
        /// Retrieve all supported accents, including which ones you can localize a voice into. Filter with `is_localizable`, `language`, and `locale`. If you pass more than one, every filter has to match.
        /// </summary>
        /// <param name="isLocalizable"></param>
        /// <param name="language"></param>
        /// <param name="locale"></param>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.ListAccentsResponse>> AccentsListAsResponseAsync(
            bool? isLocalizable = default,
            string? language = default,
            string? locale = default,
            global::Cartesia.AccentsListCartesiaVersion cartesiaVersion = global::Cartesia.AccentsListCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}