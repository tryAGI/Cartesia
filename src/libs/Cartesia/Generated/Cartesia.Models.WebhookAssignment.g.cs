
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Save a response field as a dynamic variable after a successful JSON response. Missing or `null` fields leave the variable unchanged. Objects and lists are saved as JSON text.
    /// </summary>
    public sealed partial class WebhookAssignment
    {
        /// <summary>
        /// Name of the custom variable to update. `system__` variables cannot be updated. Assign each variable at most once per tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DynamicVariable { get; set; }

        /// <summary>
        /// Response path, such as `order.status` or `items[0].name`. List positions start at zero; `items.0.name` also selects the first item. Field names cannot contain `.`, `[` or `]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValuePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAssignment" /> class.
        /// </summary>
        /// <param name="dynamicVariable">
        /// Name of the custom variable to update. `system__` variables cannot be updated. Assign each variable at most once per tool.
        /// </param>
        /// <param name="valuePath">
        /// Response path, such as `order.status` or `items[0].name`. List positions start at zero; `items.0.name` also selects the first item. Field names cannot contain `.`, `[` or `]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAssignment(
            string dynamicVariable,
            string valuePath)
        {
            this.DynamicVariable = dynamicVariable ?? throw new global::System.ArgumentNullException(nameof(dynamicVariable));
            this.ValuePath = valuePath ?? throw new global::System.ArgumentNullException(nameof(valuePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAssignment" /> class.
        /// </summary>
        public WebhookAssignment()
        {
        }

    }
}