
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolCall
    {
        /// <summary>
        /// The unique identifier for the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the tool that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Arguments supplied by the model. For webhook tools, this excludes values filled from dynamic variables or constants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// The result returned by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Values assigned by this tool. Omitted when the tool assigned no values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable_updates")]
        public global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? DynamicVariableUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCall" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool that was called.
        /// </param>
        /// <param name="arguments">
        /// Arguments supplied by the model. For webhook tools, this excludes values filled from dynamic variables or constants.
        /// </param>
        /// <param name="id">
        /// The unique identifier for the tool call.
        /// </param>
        /// <param name="result">
        /// The result returned by the tool.
        /// </param>
        /// <param name="dynamicVariableUpdates">
        /// Values assigned by this tool. Omitted when the tool assigned no values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCall(
            string name,
            object arguments,
            string? id,
            string? result,
            global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? dynamicVariableUpdates)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Result = result;
            this.DynamicVariableUpdates = dynamicVariableUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCall" /> class.
        /// </summary>
        public ToolCall()
        {
        }

    }
}