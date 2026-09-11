
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SttTranscribeRequest
    {
        /// <summary>
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// There's no need to break up your audio file. Long files are intelligently chunked by our server.<br/>
        /// Supported audio formats: `flac`, `m4a`, `mp3`, `mp4`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// ID of the model to use for transcription. Must be in the `ink-whisper` family of models.<br/>
        /// Example: ink-whisper
        /// </summary>
        /// <example>ink-whisper</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SttTranscribeRequestModelJsonConverter))]
        public global::Cartesia.SttTranscribeRequestModel Model { get; set; }

        /// <summary>
        /// The language of the input audio in ISO-639-1 format<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SttTranscribeRequestLanguageJsonConverter))]
        public global::Cartesia.SttTranscribeRequestLanguage? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities[]")]
        public global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? TimestampGranularities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscribeRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttTranscribeRequest(
            byte[] file,
            string filename,
            global::Cartesia.SttTranscribeRequestModel model,
            global::Cartesia.SttTranscribeRequestLanguage? language,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model;
            this.Language = language;
            this.TimestampGranularities = timestampGranularities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscribeRequest" /> class.
        /// </summary>
        public SttTranscribeRequest()
        {
        }

    }
}