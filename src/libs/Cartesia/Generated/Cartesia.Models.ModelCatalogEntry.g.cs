
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelCatalogEntry
    {
        /// <summary>
        /// Value clients send as TTS `model_id` or STT `model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Which speech API family the model belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ModelCapabilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ModelCapability Capability { get; set; }

        /// <summary>
        /// STT transport paths. Omitted on TTS rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modes")]
        public global::System.Collections.Generic.IList<global::Cartesia.STTMode>? Modes { get; set; }

        /// <summary>
        /// Sorted synthesis language codes supported by this TTS model. Omitted on STT rows.<br/>
        /// Example: [de, en, es, fr, ja, ko, or, pt, ur, zh]
        /// </summary>
        /// <example>[de, en, es, fr, ja, ko, or, pt, ur, zh]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_languages")]
        public global::System.Collections.Generic.IList<string>? SupportedLanguages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCatalogEntry" /> class.
        /// </summary>
        /// <param name="id">
        /// Value clients send as TTS `model_id` or STT `model`.
        /// </param>
        /// <param name="capability">
        /// Which speech API family the model belongs to.
        /// </param>
        /// <param name="modes">
        /// STT transport paths. Omitted on TTS rows.
        /// </param>
        /// <param name="supportedLanguages">
        /// Sorted synthesis language codes supported by this TTS model. Omitted on STT rows.<br/>
        /// Example: [de, en, es, fr, ja, ko, or, pt, ur, zh]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCatalogEntry(
            string id,
            global::Cartesia.ModelCapability capability,
            global::System.Collections.Generic.IList<global::Cartesia.STTMode>? modes,
            global::System.Collections.Generic.IList<string>? supportedLanguages)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Capability = capability;
            this.Modes = modes;
            this.SupportedLanguages = supportedLanguages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCatalogEntry" /> class.
        /// </summary>
        public ModelCatalogEntry()
        {
        }

    }
}