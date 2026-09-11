
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Voice object. `id` is required; other fields may be added in future API versions.
    /// </summary>
    public sealed partial class GenerationRequestVoice
    {
        /// <summary>
        /// The ID of the voice.<br/>
        /// Example: a0e99841-438c-4a64-b679-ae501e7d6091
        /// </summary>
        /// <example>a0e99841-438c-4a64-b679-ae501e7d6091</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestVoice" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.<br/>
        /// Example: a0e99841-438c-4a64-b679-ae501e7d6091
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequestVoice(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestVoice" /> class.
        /// </summary>
        public GenerationRequestVoice()
        {
        }

    }
}