
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedClientToolParametersV1
    {
        /// <summary>
        /// Parameters keyed by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? Properties { get; set; }

        /// <summary>
        /// Names of parameters the agent must provide. Other parameters are optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// The parameters schema type. Always `object`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedClientToolParametersV1TypeJsonConverter))]
        public global::Cartesia.ManagedClientToolParametersV1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedClientToolParametersV1" /> class.
        /// </summary>
        /// <param name="properties">
        /// Parameters keyed by name.
        /// </param>
        /// <param name="required">
        /// Names of parameters the agent must provide. Other parameters are optional.
        /// </param>
        /// <param name="type">
        /// The parameters schema type. Always `object`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedClientToolParametersV1(
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? properties,
            global::System.Collections.Generic.IList<string>? required,
            global::Cartesia.ManagedClientToolParametersV1Type type)
        {
            this.Properties = properties;
            this.Required = required;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedClientToolParametersV1" /> class.
        /// </summary>
        public ManagedClientToolParametersV1()
        {
        }

    }
}