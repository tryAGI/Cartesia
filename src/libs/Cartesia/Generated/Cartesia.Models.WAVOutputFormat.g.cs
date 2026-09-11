
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WAVOutputFormat
    {
        /// <summary>
        /// Default Value: wav
        /// </summary>
        /// <default>global::Cartesia.WAVOutputFormatContainer.Wav</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WAVOutputFormatContainerJsonConverter))]
        public global::Cartesia.WAVOutputFormatContainer Container { get; set; } = global::Cartesia.WAVOutputFormatContainer.Wav;

        /// <summary>
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.RawEncodingJsonConverter))]
        public global::Cartesia.RawEncoding? Encoding { get; set; }

        /// <summary>
        /// Default Value: 44100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WAVOutputFormat" /> class.
        /// </summary>
        /// <param name="encoding">
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </param>
        /// <param name="sampleRate">
        /// Default Value: 44100
        /// </param>
        /// <param name="container">
        /// Default Value: wav
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WAVOutputFormat(
            global::Cartesia.RawEncoding? encoding,
            int? sampleRate,
            global::Cartesia.WAVOutputFormatContainer container = global::Cartesia.WAVOutputFormatContainer.Wav)
        {
            this.Container = container;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WAVOutputFormat" /> class.
        /// </summary>
        public WAVOutputFormat()
        {
        }

    }
}