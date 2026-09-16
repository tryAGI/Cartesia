
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Sample values for Playground test calls. Production calls never use them.<br/>
    /// Replaces saved samples on update. Omit to keep them, or send `{}` to clear them.<br/>
    /// Variable names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. Start with a letter or underscore; `system__` and `secret__` prefixes are reserved. Limited to 16 KiB of UTF-8 JSON.
    /// </summary>
    public sealed partial class ManagedAgentDynamicVariablePlaceholdersV1
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}