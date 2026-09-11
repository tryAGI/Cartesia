
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Audio output format configuration. Use the same value for all generation requests made to the same context.
    /// </summary>
    public sealed partial class GenerationRequestOutputFormat
    {
        /// <summary>
        /// Audio container format<br/>
        /// Default Value: raw
        /// </summary>
        /// <default>global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer.Raw</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestOutputFormatContainerJsonConverter))]
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer Container { get; set; } = global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer.Raw;

        /// <summary>
        /// Audio encoding format. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestOutputFormatEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding Encoding { get; set; }

        /// <summary>
        /// Audio sample rate in Hz.
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
        /// Initializes a new instance of the <see cref="GenerationRequestOutputFormat" /> class.
        /// </summary>
        /// <param name="encoding">
        /// Audio encoding format. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz.
        /// </param>
        /// <param name="container">
        /// Audio container format<br/>
        /// Default Value: raw
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequestOutputFormat(
            global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding encoding,
            int sampleRate,
            global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer container = global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer.Raw)
        {
            this.Container = container;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestOutputFormat" /> class.
        /// </summary>
        public GenerationRequestOutputFormat()
        {
        }

    }
}