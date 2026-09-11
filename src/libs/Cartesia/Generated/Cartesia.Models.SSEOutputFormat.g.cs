
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SSEOutputFormat
    {
        /// <summary>
        /// Default Value: raw
        /// </summary>
        /// <default>global::Cartesia.SSEOutputFormatContainer.Raw</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SSEOutputFormatContainerJsonConverter))]
        public global::Cartesia.SSEOutputFormatContainer Container { get; set; } = global::Cartesia.SSEOutputFormatContainer.Raw;

        /// <summary>
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.RawEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.RawEncoding Encoding { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="SSEOutputFormat" /> class.
        /// </summary>
        /// <param name="encoding">
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="container">
        /// Default Value: raw
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSEOutputFormat(
            global::Cartesia.RawEncoding encoding,
            int sampleRate,
            global::Cartesia.SSEOutputFormatContainer container = global::Cartesia.SSEOutputFormatContainer.Raw)
        {
            this.Container = container;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSEOutputFormat" /> class.
        /// </summary>
        public SSEOutputFormat()
        {
        }

    }
}