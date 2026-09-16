
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Initial custom values while the call is active; final values after it ends, including webhook assignments. System variables are not included. Omitted from ZDR or redacted call history.
    /// </summary>
    public sealed partial class AgentCallDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}