#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsUpdateAsync(
            string id,

            global::Cartesia.UpdatePronunciationDictRequest request,
            global::Cartesia.PronunciationDictsUpdateCartesiaVersion cartesiaVersion = global::Cartesia.PronunciationDictsUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PronunciationDict>> PronunciationDictsUpdateAsResponseAsync(
            string id,

            global::Cartesia.UpdatePronunciationDictRequest request,
            global::Cartesia.PronunciationDictsUpdateCartesiaVersion cartesiaVersion = global::Cartesia.PronunciationDictsUpdateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// New name for the pronunciation dictionary
        /// </param>
        /// <param name="description">
        /// New description for the pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// Updated list of pronunciation mappings
        /// </param>
        /// <param name="access">
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsUpdateAsync(
            string id,
            global::Cartesia.PronunciationDictsUpdateCartesiaVersion cartesiaVersion = global::Cartesia.PronunciationDictsUpdateCartesiaVersion.x20260814,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? items = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>? access = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}