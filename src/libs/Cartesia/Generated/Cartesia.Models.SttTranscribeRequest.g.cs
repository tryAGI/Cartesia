
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttTranscribeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Models that support batch speech-to-text transcription.<br/>
        /// See [the docs](https://docs.cartesia.ai/api-reference/stt/transcribe#body-model) for all options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTBatchModelJsonConverter))]
        public global::Cartesia.STTBatchModel? Model { get; set; }

        /// <summary>
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SttTranscribeRequestLanguageJsonConverter))]
        public global::Cartesia.SttTranscribeRequestLanguage? Language { get; set; }

        /// <summary>
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttTranscribeRequest(
            byte[]? file,
            string? filename,
            global::Cartesia.STTBatchModel? model,
            global::Cartesia.SttTranscribeRequestLanguage? language,
            global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? timestampGranularities)
        {
            this.File = file;
            this.Filename = filename;
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