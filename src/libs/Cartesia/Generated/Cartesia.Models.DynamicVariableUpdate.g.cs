
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DynamicVariableUpdate
    {
        /// <summary>
        /// Custom variable that changed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableName { get; set; }

        /// <summary>
        /// Previous value, or null if the variable had no value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.AnyOf<string, double?, bool?> OldValue { get; set; }

        /// <summary>
        /// Assigned value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.AnyOf<string, double?, bool?> NewValue { get; set; }

        /// <summary>
        /// Time of the update, in seconds since the call started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// ID of the configured tool that assigned the value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// ID of the tool call that assigned the value, matching `tool_calls[].id`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableUpdate" /> class.
        /// </summary>
        /// <param name="variableName">
        /// Custom variable that changed
        /// </param>
        /// <param name="oldValue">
        /// Previous value, or null if the variable had no value
        /// </param>
        /// <param name="newValue">
        /// Assigned value
        /// </param>
        /// <param name="updatedAt">
        /// Time of the update, in seconds since the call started
        /// </param>
        /// <param name="toolId">
        /// ID of the configured tool that assigned the value
        /// </param>
        /// <param name="toolCallId">
        /// ID of the tool call that assigned the value, matching `tool_calls[].id`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicVariableUpdate(
            string variableName,
            global::Cartesia.AnyOf<string, double?, bool?> oldValue,
            global::Cartesia.AnyOf<string, double?, bool?> newValue,
            double updatedAt,
            string toolId,
            string toolCallId)
        {
            this.VariableName = variableName ?? throw new global::System.ArgumentNullException(nameof(variableName));
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.UpdatedAt = updatedAt;
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableUpdate" /> class.
        /// </summary>
        public DynamicVariableUpdate()
        {
        }

    }
}