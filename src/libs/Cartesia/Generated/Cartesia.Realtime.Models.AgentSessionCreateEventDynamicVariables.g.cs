
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Custom [dynamic variable](/agents/dynamic-variables) values for this session.<br/>
    /// Names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. `system__` and `secret__` prefixes are reserved.
    /// </summary>
    public sealed partial class AgentSessionCreateEventDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}