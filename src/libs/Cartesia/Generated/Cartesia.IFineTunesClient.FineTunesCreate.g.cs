#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.FineTune> FineTunesCreateAsync(

            global::Cartesia.CreateFineTuneRequest request,
            global::Cartesia.FineTunesCreateCartesiaVersion cartesiaVersion = global::Cartesia.FineTunesCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.FineTune>> FineTunesCreateAsResponseAsync(

            global::Cartesia.CreateFineTuneRequest request,
            global::Cartesia.FineTunesCreateCartesiaVersion cartesiaVersion = global::Cartesia.FineTunesCreateCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="name">
        /// Name for the new fine-tune
        /// </param>
        /// <param name="description">
        /// Description for the fine-tune
        /// </param>
        /// <param name="language">
        /// Language code for the fine-tune. Cannot be changed after training starts or completes.
        /// </param>
        /// <param name="accent">
        /// Metadata for labeling the accent of this fine-tune. See [GET /accents](/api-reference/accents/list) for values valid for each language. Cannot be changed after training starts or completes.
        /// </param>
        /// <param name="dataset">
        /// Dataset ID containing training files
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.FineTune> FineTunesCreateAsync(
            string name,
            string description,
            string language,
            string dataset,
            global::Cartesia.FineTunesCreateCartesiaVersion cartesiaVersion = global::Cartesia.FineTunesCreateCartesiaVersion.x20260814,
            global::Cartesia.VoiceAccent? accent = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}