
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Parameters sent in the request query string.
    /// </summary>
    public sealed partial class WebhookQuerySchema
    {
        /// <summary>
        /// Query parameters keyed by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam> Properties { get; set; }

        /// <summary>
        /// Parameter names the agent must provide. Other agent-provided parameters are optional; parameters with `constant_value` are always sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookQuerySchema" /> class.
        /// </summary>
        /// <param name="properties">
        /// Query parameters keyed by name.
        /// </param>
        /// <param name="required">
        /// Parameter names the agent must provide. Other agent-provided parameters are optional; parameters with `constant_value` are always sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookQuerySchema(
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam> properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookQuerySchema" /> class.
        /// </summary>
        public WebhookQuerySchema()
        {
        }

    }
}