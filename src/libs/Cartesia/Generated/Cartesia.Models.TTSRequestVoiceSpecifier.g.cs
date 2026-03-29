
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSRequestVoiceSpecifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSRequestVoiceSpecifierModeJsonConverter))]
        public global::Cartesia.TTSRequestVoiceSpecifierMode Mode { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequestVoiceSpecifier" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSRequestVoiceSpecifier(
            string id,
            global::Cartesia.TTSRequestVoiceSpecifierMode mode)
        {
            this.Mode = mode;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequestVoiceSpecifier" /> class.
        /// </summary>
        public TTSRequestVoiceSpecifier()
        {
        }
    }
}