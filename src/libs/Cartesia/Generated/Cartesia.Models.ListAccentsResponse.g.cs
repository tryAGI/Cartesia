
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAccentsResponse
    {
        /// <summary>
        /// Official accents, sorted by id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.Accent> Accents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccentsResponse" /> class.
        /// </summary>
        /// <param name="accents">
        /// Official accents, sorted by id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccentsResponse(
            global::System.Collections.Generic.IList<global::Cartesia.Accent> accents)
        {
            this.Accents = accents ?? throw new global::System.ArgumentNullException(nameof(accents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccentsResponse" /> class.
        /// </summary>
        public ListAccentsResponse()
        {
        }

    }
}