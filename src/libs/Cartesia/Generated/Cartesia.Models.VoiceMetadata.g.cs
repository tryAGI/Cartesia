
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Example: {"id":"f161df88-b5a0-4ea8-aa21-6be12859f761","access":"private","name":"My localized voice","tagline":"","description":"A voice that I localized","created_at":"2026-01-01T00:00:00.000Z","language":"en","user_id":"org_123","visibility":"owner"}
    /// </summary>
    public sealed partial class VoiceMetadata
    {
        /// <summary>
        /// The ID of the newly created voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceMetadataAccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceMetadataAccess Access { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A few words describing the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tagline { get; set; }

        /// <summary>
        /// A description for the voice, typically longer than the tagline if both are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The date and time the voice was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The voice's language, as an ISO 639-1 code (e.g. `en`, `fr`, `zh`)<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The ID of the user who owns the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceMetadataVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceMetadataVisibility Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMetadata" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the newly created voice.
        /// </param>
        /// <param name="access">
        /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="tagline">
        /// A few words describing the voice.
        /// </param>
        /// <param name="description">
        /// A description for the voice, typically longer than the tagline if both are provided.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the voice was created.
        /// </param>
        /// <param name="language">
        /// The voice's language, as an ISO 639-1 code (e.g. `en`, `fr`, `zh`)<br/>
        /// Example: en
        /// </param>
        /// <param name="userId">
        /// The ID of the user who owns the voice.
        /// </param>
        /// <param name="visibility">
        /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceMetadata(
            string id,
            global::Cartesia.VoiceMetadataAccess access,
            string name,
            string tagline,
            string description,
            global::System.DateTime createdAt,
            string language,
            string userId,
            global::Cartesia.VoiceMetadataVisibility visibility)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Access = access;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tagline = tagline ?? throw new global::System.ArgumentNullException(nameof(tagline));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMetadata" /> class.
        /// </summary>
        public VoiceMetadata()
        {
        }

    }
}