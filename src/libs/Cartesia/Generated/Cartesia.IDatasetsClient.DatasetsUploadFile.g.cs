#nullable enable

namespace Cartesia
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload a new file to a dataset
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
        global::System.Threading.Tasks.Task DatasetsUploadFileAsync(
            string id,

            global::Cartesia.DatasetsUploadFileRequest request,
            global::Cartesia.DatasetsUploadFileCartesiaVersion cartesiaVersion = global::Cartesia.DatasetsUploadFileCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a new file to a dataset
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
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse> DatasetsUploadFileAsResponseAsync(
            string id,

            global::Cartesia.DatasetsUploadFileRequest request,
            global::Cartesia.DatasetsUploadFileCartesiaVersion cartesiaVersion = global::Cartesia.DatasetsUploadFileCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a new file to a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="id"></param>
        /// <param name="file">
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="filename">
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="purpose">
        /// Purpose of the file<br/>
        /// Example: fine_tune
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DatasetsUploadFileAsync(
            string id,
            global::Cartesia.DatasetsUploadFileCartesiaVersion cartesiaVersion = global::Cartesia.DatasetsUploadFileCartesiaVersion.x20260814,
            byte[]? file = default,
            string? filename = default,
            string? purpose = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}