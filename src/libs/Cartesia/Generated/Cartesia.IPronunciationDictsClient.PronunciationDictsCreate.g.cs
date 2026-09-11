#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Create a new pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsCreateAsync(

            global::Cartesia.CreatePronunciationDictRequest request,
            global::Cartesia.PronunciationDictsCreateCartesiaVersion cartesiaVersion = global::Cartesia.PronunciationDictsCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.PronunciationDict>> PronunciationDictsCreateAsResponseAsync(

            global::Cartesia.CreatePronunciationDictRequest request,
            global::Cartesia.PronunciationDictsCreateCartesiaVersion cartesiaVersion = global::Cartesia.PronunciationDictsCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="name">
        /// Name for the new pronunciation dictionary
        /// </param>
        /// <param name="description">
        /// An optional description for the pronunciation dictionary.
        /// </param>
        /// <param name="items">
        /// Optional initial list of pronunciation mappings
        /// </param>
        /// <param name="access">
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.PronunciationDict> PronunciationDictsCreateAsync(
            string name,
            global::Cartesia.PronunciationDictsCreateCartesiaVersion cartesiaVersion = global::Cartesia.PronunciationDictsCreateCartesiaVersion.x20260814,
            string? description = default,
            global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? items = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? access = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}