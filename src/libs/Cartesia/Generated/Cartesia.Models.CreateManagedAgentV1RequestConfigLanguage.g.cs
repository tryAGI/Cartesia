
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigLanguage
    {
        /// <summary>
        /// ISO 639-1 language code used for speech recognition, agent responses, and speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentPrimaryLanguageV1JsonConverter))]
        public global::Cartesia.ManagedAgentPrimaryLanguageV1? Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigLanguage" /> class.
        /// </summary>
        /// <param name="primary">
        /// ISO 639-1 language code used for speech recognition, agent responses, and speech synthesis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigLanguage(
            global::Cartesia.ManagedAgentPrimaryLanguageV1? primary)
        {
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigLanguage" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigLanguage()
        {
        }

    }
}