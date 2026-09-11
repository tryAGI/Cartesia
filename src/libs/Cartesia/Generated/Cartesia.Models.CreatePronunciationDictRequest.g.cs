
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request to create a new pronunciation dictionary
    /// </summary>
    public sealed partial class CreatePronunciationDictRequest
    {
        /// <summary>
        /// Name for the new pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional description for the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional initial list of pronunciation mappings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? Items { get; set; }

        /// <summary>
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>))]
        public global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationDictRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new pronunciation dictionary
        /// </param>
        /// <param name="description">
        /// An optional description for the pronunciation dictionary.
        /// </param>
        /// <param name="items">
        /// Optional initial list of pronunciation mappings
        /// </param>
        /// <param name="access">
        /// Controls who can access this resource. Prefer `"public"` | `"private"`. Deprecated nested `{ "type": "public" | "private" }` is still accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePronunciationDictRequest(
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? items,
            global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? access)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Items = items;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationDictRequest" /> class.
        /// </summary>
        public CreatePronunciationDictRequest()
        {
        }

    }
}