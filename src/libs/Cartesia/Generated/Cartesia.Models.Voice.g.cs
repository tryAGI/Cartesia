
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Example: {"id":"db6b0ed5-d5d3-463d-ae85-518a07d3c2b4","is_owner":false,"status":"active","access":"public","name":"Skylar","tagline":"Friendly Guide","description":"Approachable American female ideal for customer care and support.","gender":"feminine","language":"en","accents":[{"accent":"general-american","locale":"en-US","is_native":true},{"accent":"hindi","locale":"hi-IN","is_native":false},{"accent":"mexican","locale":"es-MX","is_native":false},{"accent":"high-german","locale":"de-DE","is_native":false},{"accent":"israeli","locale":"he-IL","is_native":false},{"accent":"italian","locale":"it-IT","is_native":false},{"accent":"brazilian-portuguese","locale":"pt-BR","is_native":false},{"accent":"central-tamil","locale":"ta-IN","is_native":false}],"country":"US","created_at":"2026-03-31T17:37:05.961874Z","visibility":"all"}
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether your organization owns the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        /// Status of the voice. Only active voices are returned in [List Voices](/api-reference/voices/list) by default unless `include_archived=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceStatus Status { get; set; }

        /// <summary>
        /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceAccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceAccess Access { get; set; }

        /// <summary>
        /// The display name of the voice. Does not include the tagline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A short descriptor for the voice (at most 32 characters). Empty string when unset.
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.GenderPresentationJsonConverter))]
        public global::Cartesia.GenderPresentation? Gender { get; set; }

        /// <summary>
        /// The date and time the voice was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A URL to download a preview audio file for this voice. Useful to avoid consuming credits when looking for the right voice. The URL requires the same Authorization header. Voice previews may be changed, moved, or deleted so you should avoid storing the URL permanently. This property will be null if there's no preview available. Only included when `expand[]` includes `preview_file_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_file_url")]
        public string? PreviewFileUrl { get; set; }

        /// <summary>
        /// The voice's language, as an ISO 639-1 code (e.g. `en`, `fr`, `zh`)<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Accents supported by this voice. The accent with `is_native: true` is the voice's original accent. Only available for voices with known accent information.<br/>
        /// Example: [{"accent":"general-american","locale":"en-US","is_native":true}, {"accent":"mexican","locale":"es-MX","is_native":false}]
        /// </summary>
        /// <example>[{"accent":"general-american","locale":"en-US","is_native":true}, {"accent":"mexican","locale":"es-MX","is_native":false}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accents")]
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? Accents { get; set; }

        /// <summary>
        /// The country associated with the voice, as an ISO 3166-1 alpha-2 code when available (e.g. `US`, `GB`, `FR`).<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Whether this voice is a pro voice clone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pro")]
        public bool? IsPro { get; set; }

        /// <summary>
        /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.VoiceVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.VoiceVisibility Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice. Find one in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list).
        /// </param>
        /// <param name="isOwner">
        /// Whether your organization owns the voice.
        /// </param>
        /// <param name="status">
        /// Status of the voice. Only active voices are returned in [List Voices](/api-reference/voices/list) by default unless `include_archived=true`.
        /// </param>
        /// <param name="access">
        /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
        /// </param>
        /// <param name="name">
        /// The display name of the voice. Does not include the tagline.
        /// </param>
        /// <param name="tagline">
        /// A short descriptor for the voice (at most 32 characters). Empty string when unset.
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
        /// <param name="visibility">
        /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
        /// </param>
        /// <param name="gender"></param>
        /// <param name="previewFileUrl">
        /// A URL to download a preview audio file for this voice. Useful to avoid consuming credits when looking for the right voice. The URL requires the same Authorization header. Voice previews may be changed, moved, or deleted so you should avoid storing the URL permanently. This property will be null if there's no preview available. Only included when `expand[]` includes `preview_file_url`.
        /// </param>
        /// <param name="accents">
        /// Accents supported by this voice. The accent with `is_native: true` is the voice's original accent. Only available for voices with known accent information.<br/>
        /// Example: [{"accent":"general-american","locale":"en-US","is_native":true}, {"accent":"mexican","locale":"es-MX","is_native":false}]
        /// </param>
        /// <param name="country">
        /// The country associated with the voice, as an ISO 3166-1 alpha-2 code when available (e.g. `US`, `GB`, `FR`).<br/>
        /// Example: US
        /// </param>
        /// <param name="isPro">
        /// Whether this voice is a pro voice clone.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            string id,
            bool isOwner,
            global::Cartesia.VoiceStatus status,
            global::Cartesia.VoiceAccess access,
            string name,
            string tagline,
            string description,
            global::System.DateTime createdAt,
            string language,
            global::Cartesia.VoiceVisibility visibility,
            global::Cartesia.GenderPresentation? gender,
            string? previewFileUrl,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? accents,
            string? country,
            bool? isPro)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsOwner = isOwner;
            this.Status = status;
            this.Access = access;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tagline = tagline ?? throw new global::System.ArgumentNullException(nameof(tagline));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Gender = gender;
            this.CreatedAt = createdAt;
            this.PreviewFileUrl = previewFileUrl;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Accents = accents;
            this.Country = country;
            this.IsPro = isPro;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }

    }
}