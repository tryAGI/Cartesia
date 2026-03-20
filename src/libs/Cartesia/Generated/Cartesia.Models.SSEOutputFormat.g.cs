
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSEOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SSEOutputFormatContainerJsonConverter))]
        public global::Cartesia.SSEOutputFormatContainer Container { get; set; }

        /// <summary>
        /// 
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
        /// <param name="container"></param>
        /// <param name="encoding"></param>
        /// <param name="sampleRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSEOutputFormat(
            global::Cartesia.RawEncoding encoding,
            int sampleRate,
            global::Cartesia.SSEOutputFormatContainer container)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSEOutputFormat" /> class.
        /// </summary>
        public SSEOutputFormat()
        {
        }
    }
}