
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A value sent in the URL path. The model supplies it unless you set `constant_value` or `dynamic_variable`.
    /// </summary>
    public sealed partial class WebhookPathParam
    {
        /// <summary>
        /// A fixed value sent on every request. It must match the parameter's `type`. The agent does not see or set it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>))]
        public global::Cartesia.AnyOf<string, double?, bool?>? ConstantValue { get; set; }

        /// <summary>
        /// What the agent should provide when it chooses this parameter's value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the variable to use when the tool runs. The parameter is hidden from the model. A missing value or type mismatch returns a tool error before execution. Use `constant_value` instead to send a fixed value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// Allowed values for the model to choose from. Use only when `constant_value` and `dynamic_variable` are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Enum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookPathParamTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.WebhookPathParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPathParam" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="constantValue">
        /// A fixed value sent on every request. It must match the parameter's `type`. The agent does not see or set it.
        /// </param>
        /// <param name="description">
        /// What the agent should provide when it chooses this parameter's value.
        /// </param>
        /// <param name="dynamicVariable">
        /// Name of the variable to use when the tool runs. The parameter is hidden from the model. A missing value or type mismatch returns a tool error before execution. Use `constant_value` instead to send a fixed value.
        /// </param>
        /// <param name="enum">
        /// Allowed values for the model to choose from. Use only when `constant_value` and `dynamic_variable` are omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPathParam(
            global::Cartesia.WebhookPathParamType type,
            global::Cartesia.AnyOf<string, double?, bool?>? constantValue,
            string? description,
            string? dynamicVariable,
            global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? @enum)
        {
            this.ConstantValue = constantValue;
            this.Description = description;
            this.DynamicVariable = dynamicVariable;
            this.Enum = @enum;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPathParam" /> class.
        /// </summary>
        public WebhookPathParam()
        {
        }

    }
}