#nullable enable

namespace Cartesia
{
    public partial interface ISttClient
    {
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// See [the API docs](https://docs.cartesia.ai/api-reference/stt/transcribe) for details.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TranscriptionResponse> SttTranscribeAsync(
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion,

            global::Cartesia.SttTranscribeRequest request,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// See [the API docs](https://docs.cartesia.ai/api-reference/stt/transcribe) for details.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.TranscriptionResponse>> SttTranscribeAsResponseAsync(
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion,

            global::Cartesia.SttTranscribeRequest request,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// See [the API docs](https://docs.cartesia.ai/api-reference/stt/transcribe) for details.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model">
        /// Models that support batch speech-to-text transcription.<br/>
        /// See [the docs](https://docs.cartesia.ai/api-reference/stt/transcribe#body-model) for all options.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TranscriptionResponse> SttTranscribeAsync(
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion,
            byte[] file,
            string filename,
            global::Cartesia.STTBatchModel model,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// See [the API docs](https://docs.cartesia.ai/api-reference/stt/transcribe) for details.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="model">
        /// Models that support batch speech-to-text transcription.<br/>
        /// See [the docs](https://docs.cartesia.ai/api-reference/stt/transcribe#body-model) for all options.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TranscriptionResponse> SttTranscribeAsync(
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion,
            global::System.IO.Stream file,
            string filename,
            global::Cartesia.STTBatchModel model,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// See [the API docs](https://docs.cartesia.ai/api-reference/stt/transcribe) for details.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="model">
        /// Models that support batch speech-to-text transcription.<br/>
        /// See [the docs](https://docs.cartesia.ai/api-reference/stt/transcribe#body-model) for all options.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.TranscriptionResponse>> SttTranscribeAsResponseAsync(
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion,
            global::System.IO.Stream file,
            string filename,
            global::Cartesia.STTBatchModel model,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}