
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class STTAutoFinalizeWebSocketQueryParams
    {
        /// <summary>
        /// Models that support realtime speech-to-text (auto finalize).<br/>
        /// This mode detects when the user is speaking and emits turn events.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTAutoFinalizeModelJsonConverter))]
        public global::Cartesia.STTAutoFinalizeModel Model { get; set; }

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
        /// Key terms to improve the recall of specific words and phrases. Each value is sent as a repeated `keyterm` query parameter. Pass up to 100 keyterms totaling 1200 characters. To boost one multi-word phrase, keep the words in a single value.<br/>
        /// See [Keyterm prompting](https://docs.cartesia.ai/use-the-api/stt/keyterms) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterm")]
        public global::System.Collections.Generic.IList<string>? Keyterm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTAutoFinalizeWebSocketQueryParams" /> class.
        /// </summary>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz.
        /// </param>
        /// <param name="model">
        /// Models that support realtime speech-to-text (auto finalize).<br/>
        /// This mode detects when the user is speaking and emits turn events.<br/>
        /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
        /// </param>
        /// <param name="keyterm">
        /// Key terms to improve the recall of specific words and phrases. Each value is sent as a repeated `keyterm` query parameter. Pass up to 100 keyterms totaling 1200 characters. To boost one multi-word phrase, keep the words in a single value.<br/>
        /// See [Keyterm prompting](https://docs.cartesia.ai/use-the-api/stt/keyterms) for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTAutoFinalizeWebSocketQueryParams(
            global::Cartesia.STTEncoding encoding,
            int sampleRate,
            global::Cartesia.STTAutoFinalizeModel model,
            global::System.Collections.Generic.IList<string>? keyterm)
        {
            this.Model = model;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
            this.Keyterm = keyterm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTAutoFinalizeWebSocketQueryParams" /> class.
        /// </summary>
        public STTAutoFinalizeWebSocketQueryParams()
        {
        }

    }
}