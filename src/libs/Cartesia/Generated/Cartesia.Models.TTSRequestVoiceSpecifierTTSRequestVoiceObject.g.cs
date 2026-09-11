
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Voice object. `id` is required; other fields may be added in future API versions.
    /// </summary>
    public sealed partial class TTSRequestVoiceSpecifierTTSRequestVoiceObject
    {
        /// <summary>
        /// The ID of the voice.<br/>
        /// Example: db6b0ed5-d5d3-463d-ae85-518a07d3c2b4
        /// </summary>
        /// <example>db6b0ed5-d5d3-463d-ae85-518a07d3c2b4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequestVoiceSpecifierTTSRequestVoiceObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.<br/>
        /// Example: db6b0ed5-d5d3-463d-ae85-518a07d3c2b4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSRequestVoiceSpecifierTTSRequestVoiceObject(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequestVoiceSpecifierTTSRequestVoiceObject" /> class.
        /// </summary>
        public TTSRequestVoiceSpecifierTTSRequestVoiceObject()
        {
        }

    }
}