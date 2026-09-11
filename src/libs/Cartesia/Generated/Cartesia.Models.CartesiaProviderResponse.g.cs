
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A Cartesia-managed provider. US phone numbers only.
    /// </summary>
    public sealed partial class CartesiaProviderResponse
    {
        /// <summary>
        /// Always `"cartesia"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.CartesiaProviderResponseTypeJsonConverter))]
        public global::Cartesia.CartesiaProviderResponseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaProviderResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `"cartesia"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaProviderResponse(
            global::Cartesia.CartesiaProviderResponseType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaProviderResponse" /> class.
        /// </summary>
        public CartesiaProviderResponse()
        {
        }

    }
}