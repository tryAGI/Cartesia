
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Custom values for this call. Supply values for variables used in the welcome message.<br/>
    /// Names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. Start with a letter or underscore; `system__` and `secret__` prefixes are reserved. Limited to 16 KiB of UTF-8 JSON.
    /// </summary>
    public sealed partial class AgentDynamicVariableInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}