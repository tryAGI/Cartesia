
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionConfigLanguage
    {
        /// <summary>
        /// Primary language used for this call. Omit to inherit the published language or set to `null` to use English (`en`).
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
        /// Initializes a new instance of the <see cref="AgentSessionConfigLanguage" /> class.
        /// </summary>
        /// <param name="primary">
        /// Primary language used for this call. Omit to inherit the published language or set to `null` to use English (`en`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionConfigLanguage(
            global::Cartesia.ManagedAgentPrimaryLanguageV1? primary)
        {
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfigLanguage" /> class.
        /// </summary>
        public AgentSessionConfigLanguage()
        {
        }

    }
}