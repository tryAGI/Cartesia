
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTurnEndedEventToolCall
    {
        /// <summary>
        /// Name of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Arguments the model supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// The tool's result, when one was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Identifier of the invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Values assigned by this tool. Omitted when the tool assigned no values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable_updates")]
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCallDynamicVariableUpdate>? DynamicVariableUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnEndedEventToolCall" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool.
        /// </param>
        /// <param name="arguments">
        /// Arguments the model supplied.
        /// </param>
        /// <param name="result">
        /// The tool's result, when one was recorded.
        /// </param>
        /// <param name="id">
        /// Identifier of the invocation.
        /// </param>
        /// <param name="dynamicVariableUpdates">
        /// Values assigned by this tool. Omitted when the tool assigned no values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnEndedEventToolCall(
            string name,
            object arguments,
            string? result,
            string? id,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCallDynamicVariableUpdate>? dynamicVariableUpdates)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Result = result;
            this.Id = id;
            this.DynamicVariableUpdates = dynamicVariableUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnEndedEventToolCall" /> class.
        /// </summary>
        public AgentTurnEndedEventToolCall()
        {
        }

    }
}