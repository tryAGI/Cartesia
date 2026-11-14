
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Settings per language, keyed by a language or locale such as `es-MX`. A preset applies only when the agent speaks that exact language or locale, including the primary language. Languages without a matching preset use the agent's own settings. Returns `{}` when none are configured.<br/>
    /// Example: {"es-MX":{"voice_id":"\u003Cspanish_voice_id\u003E"}}
    /// </summary>
    public sealed partial class ManagedAgentConfigV1LanguagePresets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}