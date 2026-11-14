
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentWebSessionRequest
    {
        /// <summary>
        /// Trusted values that Cartesia stores on the call and supplies to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Per-call overrides using the same field structure as agent configuration. Omitted fields use the agent's published configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_overrides")]
        public global::Cartesia.AgentSessionConfig? ConfigOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebSessionRequest" /> class.
        /// </summary>
        /// <param name="dynamicVariables">
        /// Trusted values that Cartesia stores on the call and supplies to the agent.
        /// </param>
        /// <param name="configOverrides">
        /// Per-call overrides using the same field structure as agent configuration. Omitted fields use the agent's published configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentWebSessionRequest(
            object? dynamicVariables,
            global::Cartesia.AgentSessionConfig? configOverrides)
        {
            this.DynamicVariables = dynamicVariables;
            this.ConfigOverrides = configOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebSessionRequest" /> class.
        /// </summary>
        public CreateAgentWebSessionRequest()
        {
        }

    }
}