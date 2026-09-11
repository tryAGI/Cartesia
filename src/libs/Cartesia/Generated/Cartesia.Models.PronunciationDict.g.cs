
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A dictionary of text-to-pronunciation mappings<br/>
    /// Example: {"id":"pdict_123","name":"Acme","description":"An example dictionary","is_owner":true,"pinned":false,"access":"private","items":[{"text":"acme","pronunciation":"\u003C\u003C\u02C8|\u00E6|k|m|i\u003E\u003E","case_sensitive":false}],"created_at":"2025-10-27T14:54:26.68581Z","visibility":"owner"}
    /// </summary>
    public sealed partial class PronunciationDict
    {
        /// <summary>
        /// Unique identifier for the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether your organization owns the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.PronunciationDictAccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.PronunciationDictAccess Access { get; set; }

        /// <summary>
        /// Whether this dictionary is pinned for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// List of text-to-pronunciation mappings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem> Items { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the dictionary was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.PronunciationDictVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.PronunciationDictVisibility Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDict" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the pronunciation dictionary
        /// </param>
        /// <param name="name">
        /// Name of the pronunciation dictionary
        /// </param>
        /// <param name="description">
        /// Description of the pronunciation dictionary
        /// </param>
        /// <param name="isOwner">
        /// Whether your organization owns the pronunciation dictionary.
        /// </param>
        /// <param name="access">
        /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
        /// </param>
        /// <param name="pinned">
        /// Whether this dictionary is pinned for the user
        /// </param>
        /// <param name="items">
        /// List of text-to-pronunciation mappings
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the dictionary was created
        /// </param>
        /// <param name="visibility">
        /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDict(
            string id,
            string name,
            string description,
            bool isOwner,
            global::Cartesia.PronunciationDictAccess access,
            bool pinned,
            global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem> items,
            string createdAt,
            global::Cartesia.PronunciationDictVisibility visibility)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsOwner = isOwner;
            this.Access = access;
            this.Pinned = pinned;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDict" /> class.
        /// </summary>
        public PronunciationDict()
        {
        }

    }
}