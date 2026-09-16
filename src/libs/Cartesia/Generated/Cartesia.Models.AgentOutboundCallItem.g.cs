
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Destination and dynamic variables for one outbound call
    /// </summary>
    public sealed partial class AgentOutboundCallItem
    {
        /// <summary>
        /// Destination phone number for this outbound call, in E.164 format (e.g., `+14155559876`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

        /// <summary>
        /// Custom values for this call. Supply values for variables used in the welcome message.<br/>
        /// Names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. Start with a letter or underscore; `system__` and `secret__` prefixes are reserved. Limited to 16 KiB of UTF-8 JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::Cartesia.AgentDynamicVariableInputs? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallItem" /> class.
        /// </summary>
        /// <param name="toNumber">
        /// Destination phone number for this outbound call, in E.164 format (e.g., `+14155559876`).
        /// </param>
        /// <param name="dynamicVariables">
        /// Custom values for this call. Supply values for variables used in the welcome message.<br/>
        /// Names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. Start with a letter or underscore; `system__` and `secret__` prefixes are reserved. Limited to 16 KiB of UTF-8 JSON.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundCallItem(
            string toNumber,
            global::Cartesia.AgentDynamicVariableInputs? dynamicVariables)
        {
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallItem" /> class.
        /// </summary>
        public AgentOutboundCallItem()
        {
        }

    }
}