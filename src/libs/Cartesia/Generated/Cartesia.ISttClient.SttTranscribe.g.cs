#nullable enable

namespace Cartesia
{
    public partial interface ISttClient
    {
        /// <summary>
        /// Batch Speech-to-Text<br/>
        /// Transcribes an audio file of any length
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="encoding">
        /// Must match the actual encoding of your audio.<br/>
        /// For detailed guidance on each format, see [Audio Input](/build-with-cartesia/stt/audio-input).
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TranscriptionResponse> SttTranscribeAsync(

            global::Cartesia.SttTranscribeRequest request,
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion = global::Cartesia.SttTranscribeCartesiaVersion.x20260814,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Speech-to-Text<br/>
        /// Transcribes an audio file of any length
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="encoding">
        /// Must match the actual encoding of your audio.<br/>
        /// For detailed guidance on each format, see [Audio Input](/build-with-cartesia/stt/audio-input).
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.TranscriptionResponse>> SttTranscribeAsResponseAsync(

            global::Cartesia.SttTranscribeRequest request,
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion = global::Cartesia.SttTranscribeCartesiaVersion.x20260814,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Speech-to-Text<br/>
        /// Transcribes an audio file of any length
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="encoding">
        /// Must match the actual encoding of your audio.<br/>
        /// For detailed guidance on each format, see [Audio Input](/build-with-cartesia/stt/audio-input).
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file">
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="filename">
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="model">
        /// ID of the model to use for transcription. Must be in the `ink-whisper` family of models.<br/>
        /// Example: ink-whisper
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format<br/>
        /// Default Value: en
        /// </param>
        /// <param name="timestampGranularities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TranscriptionResponse> SttTranscribeAsync(
            byte[] file,
            string filename,
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion = global::Cartesia.SttTranscribeCartesiaVersion.x20260814,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.SttTranscribeRequestModel model = default,
            global::Cartesia.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Batch Speech-to-Text<br/>
        /// Transcribes an audio file of any length
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="encoding">
        /// Must match the actual encoding of your audio.<br/>
        /// For detailed guidance on each format, see [Audio Input](/build-with-cartesia/stt/audio-input).
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file">
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="filename">
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="model">
        /// ID of the model to use for transcription. Must be in the `ink-whisper` family of models.<br/>
        /// Example: ink-whisper
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format<br/>
        /// Default Value: en
        /// </param>
        /// <param name="timestampGranularities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.TranscriptionResponse> SttTranscribeAsync(
            global::System.IO.Stream file,
            string filename,
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion = global::Cartesia.SttTranscribeCartesiaVersion.x20260814,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.SttTranscribeRequestModel model = default,
            global::Cartesia.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Speech-to-Text<br/>
        /// Transcribes an audio file of any length
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="encoding">
        /// Must match the actual encoding of your audio.<br/>
        /// For detailed guidance on each format, see [Audio Input](/build-with-cartesia/stt/audio-input).
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file">
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="filename">
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="model">
        /// ID of the model to use for transcription. Must be in the `ink-whisper` family of models.<br/>
        /// Example: ink-whisper
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format<br/>
        /// Default Value: en
        /// </param>
        /// <param name="timestampGranularities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::Cartesia.TranscriptionResponse>> SttTranscribeAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Cartesia.SttTranscribeCartesiaVersion cartesiaVersion = global::Cartesia.SttTranscribeCartesiaVersion.x20260814,
            global::Cartesia.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::Cartesia.SttTranscribeRequestModel model = default,
            global::Cartesia.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}