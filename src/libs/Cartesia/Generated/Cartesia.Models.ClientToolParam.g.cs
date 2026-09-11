
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// One argument passed to your function.
    /// </summary>
    public sealed partial class ClientToolParam
    {
        /// <summary>
        /// What value the agent should provide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Allowed string values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// The array item type. Required when `type` is `array`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Cartesia.ClientToolParamItems? Items { get; set; }

        /// <summary>
        /// The parameter's JSON type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ClientToolParamTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ClientToolParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The parameter's JSON type.
        /// </param>
        /// <param name="description">
        /// What value the agent should provide.
        /// </param>
        /// <param name="enum">
        /// Allowed string values.
        /// </param>
        /// <param name="items">
        /// The array item type. Required when `type` is `array`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolParam(
            global::Cartesia.ClientToolParamType type,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            global::Cartesia.ClientToolParamItems? items)
        {
            this.Description = description;
            this.Enum = @enum;
            this.Items = items;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolParam" /> class.
        /// </summary>
        public ClientToolParam()
        {
        }

    }
}