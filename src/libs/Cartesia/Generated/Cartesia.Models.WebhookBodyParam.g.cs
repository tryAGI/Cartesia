
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A value sent in the JSON request body.
    /// </summary>
    public sealed partial class WebhookBodyParam
    {
        /// <summary>
        /// A fixed value sent on every request. It must match the parameter's `type`. The agent does not see or set it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>))]
        public global::Cartesia.AnyOf<string, double?, bool?>? ConstantValue { get; set; }

        /// <summary>
        /// What value the agent should provide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Allowed values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Enum { get; set; }

        /// <summary>
        /// A value sent in the JSON request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Cartesia.WebhookBodyParam? Items { get; set; }

        /// <summary>
        /// Object properties keyed by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? Properties { get; set; }

        /// <summary>
        /// Property names the agent must provide. Other agent-provided properties are optional; properties with `constant_value` are always sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookBodyParamTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.WebhookBodyParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBodyParam" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="constantValue">
        /// A fixed value sent on every request. It must match the parameter's `type`. The agent does not see or set it.
        /// </param>
        /// <param name="description">
        /// What value the agent should provide.
        /// </param>
        /// <param name="enum">
        /// Allowed values.
        /// </param>
        /// <param name="items">
        /// A value sent in the JSON request body.
        /// </param>
        /// <param name="properties">
        /// Object properties keyed by name.
        /// </param>
        /// <param name="required">
        /// Property names the agent must provide. Other agent-provided properties are optional; properties with `constant_value` are always sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBodyParam(
            global::Cartesia.WebhookBodyParamType type,
            global::Cartesia.AnyOf<string, double?, bool?>? constantValue,
            string? description,
            global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? @enum,
            global::Cartesia.WebhookBodyParam? items,
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.ConstantValue = constantValue;
            this.Description = description;
            this.Enum = @enum;
            this.Items = items;
            this.Properties = properties;
            this.Required = required;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBodyParam" /> class.
        /// </summary>
        public WebhookBodyParam()
        {
        }

    }
}