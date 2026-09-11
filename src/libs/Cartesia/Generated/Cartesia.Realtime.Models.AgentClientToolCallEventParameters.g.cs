
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Arguments for the tool, matching the tool's parameter schema.
    /// </summary>
    public sealed partial class AgentClientToolCallEventParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}