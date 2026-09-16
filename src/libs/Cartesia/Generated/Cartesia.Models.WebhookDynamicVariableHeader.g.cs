
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Fill this header with the variable's current value. Numbers and true/false values become text. The result must be nonempty printable ASCII.
    /// </summary>
    public sealed partial class WebhookDynamicVariableHeader
    {
        /// <summary>
        /// Name of the dynamic variable whose value is sent as the header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookDynamicVariableHeaderTypeJsonConverter))]
        public global::Cartesia.WebhookDynamicVariableHeaderType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDynamicVariableHeader" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the dynamic variable whose value is sent as the header.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDynamicVariableHeader(
            string name,
            global::Cartesia.WebhookDynamicVariableHeaderType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDynamicVariableHeader" /> class.
        /// </summary>
        public WebhookDynamicVariableHeader()
        {
        }

    }
}