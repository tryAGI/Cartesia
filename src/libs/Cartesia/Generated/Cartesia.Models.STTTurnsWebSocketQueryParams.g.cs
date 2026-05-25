
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class STTTurnsWebSocketQueryParams
    {
        /// <summary>
        /// Models that support realtime speech-to-text with turn-detection.<br/>
        /// This mode detects when the user is speaking and emits turn events.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTRealtimeTurnDetectingModelJsonConverter))]
        public global::Cartesia.STTRealtimeTurnDetectingModel Model { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsWebSocketQueryParams" /> class.
        /// </summary>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz.
        /// </param>
        /// <param name="model">
        /// Models that support realtime speech-to-text with turn-detection.<br/>
        /// This mode detects when the user is speaking and emits turn events.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsWebSocketQueryParams(
            global::Cartesia.STTEncoding encoding,
            int sampleRate,
            global::Cartesia.STTRealtimeTurnDetectingModel model)
        {
            this.Model = model;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsWebSocketQueryParams" /> class.
        /// </summary>
        public STTTurnsWebSocketQueryParams()
        {
        }

    }
}