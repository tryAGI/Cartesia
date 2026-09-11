
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentConfigV1Language
    {
        /// <summary>
        /// ISO 639-1 language code used for speech recognition, agent responses, and speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentPrimaryLanguageV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentPrimaryLanguageV1 Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Language" /> class.
        /// </summary>
        /// <param name="primary">
        /// ISO 639-1 language code used for speech recognition, agent responses, and speech synthesis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1Language(
            global::Cartesia.ManagedAgentPrimaryLanguageV1 primary)
        {
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Language" /> class.
        /// </summary>
        public ManagedAgentConfigV1Language()
        {
        }

    }
}