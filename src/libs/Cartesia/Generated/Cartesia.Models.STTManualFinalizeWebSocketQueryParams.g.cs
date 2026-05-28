
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class STTManualFinalizeWebSocketQueryParams
    {
        /// <summary>
        /// Models that support realtime speech-to-text (manual finalize).<br/>
        /// This mode expects you to send the `finalize` command to trigger transcription.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTManualFinalizeModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.STTManualFinalizeModel Model { get; set; }

        /// <summary>
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.STTEncoding Encoding { get; set; }

        /// <summary>
        /// Sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for current language support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTManualFinalizeWebSocketQueryParamsLanguageJsonConverter))]
        public global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? Language { get; set; }

        /// <summary>
        /// Used by `ink-whisper` models only. Controls what is considered silence for automatic transcript finalization. Lower values pick up quiet audio; higher values filter noisy audio more aggressively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_volume")]
        public double? MinVolume { get; set; }

        /// <summary>
        /// Used by `ink-whisper` models only. Maximum duration of silence (in seconds) before the API automatically finalizes the transcript. Lower values finalize more aggressively; higher values allow longer pauses within utterances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_silence_duration_secs")]
        public double? MaxSilenceDurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTManualFinalizeWebSocketQueryParams" /> class.
        /// </summary>
        /// <param name="model">
        /// Models that support realtime speech-to-text (manual finalize).<br/>
        /// This mode expects you to send the `finalize` command to trigger transcription.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
        /// </param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for current language support.
        /// </param>
        /// <param name="minVolume">
        /// Used by `ink-whisper` models only. Controls what is considered silence for automatic transcript finalization. Lower values pick up quiet audio; higher values filter noisy audio more aggressively.
        /// </param>
        /// <param name="maxSilenceDurationSecs">
        /// Used by `ink-whisper` models only. Maximum duration of silence (in seconds) before the API automatically finalizes the transcript. Lower values finalize more aggressively; higher values allow longer pauses within utterances.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTManualFinalizeWebSocketQueryParams(
            global::Cartesia.STTManualFinalizeModel model,
            global::Cartesia.STTEncoding encoding,
            int sampleRate,
            global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? language,
            double? minVolume,
            double? maxSilenceDurationSecs)
        {
            this.Model = model;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
            this.Language = language;
            this.MinVolume = minVolume;
            this.MaxSilenceDurationSecs = maxSilenceDurationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTManualFinalizeWebSocketQueryParams" /> class.
        /// </summary>
        public STTManualFinalizeWebSocketQueryParams()
        {
        }

    }
}