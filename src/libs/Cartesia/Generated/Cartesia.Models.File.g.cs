
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An uploaded file.
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// Unique identifier for the file, prefixed with `file_`.<br/>
        /// Example: file_EneDabCuJCpfe5CFi5X12e
        /// </summary>
        /// <example>file_EneDabCuJCpfe5CFi5X12e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Original filename.<br/>
        /// Example: background-sound.wav
        /// </summary>
        /// <example>background-sound.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Example: agent_background_sound
        /// </summary>
        /// <example>agent_background_sound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.FilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.FilePurpose Purpose { get; set; }

        /// <summary>
        /// Size of the file in bytes.<br/>
        /// Example: 2048576
        /// </summary>
        /// <example>2048576</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// Processing status of the file.<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// ID of the account that owns the file.<br/>
        /// Example: org_2x6zg1zx5cnZJHwZCJypdW6YIiC
        /// </summary>
        /// <example>org_2x6zg1zx5cnZJHwZCJypdW6YIiC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Timestamp when the file was created.<br/>
        /// Example: 2026-07-25T18:30:00.000Z
        /// </summary>
        /// <example>2026-07-25T18:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file, prefixed with `file_`.<br/>
        /// Example: file_EneDabCuJCpfe5CFi5X12e
        /// </param>
        /// <param name="filename">
        /// Original filename.<br/>
        /// Example: background-sound.wav
        /// </param>
        /// <param name="purpose">
        /// Example: agent_background_sound
        /// </param>
        /// <param name="size">
        /// Size of the file in bytes.<br/>
        /// Example: 2048576
        /// </param>
        /// <param name="status">
        /// Processing status of the file.<br/>
        /// Example: ready
        /// </param>
        /// <param name="ownerId">
        /// ID of the account that owns the file.<br/>
        /// Example: org_2x6zg1zx5cnZJHwZCJypdW6YIiC
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the file was created.<br/>
        /// Example: 2026-07-25T18:30:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            string id,
            string filename,
            global::Cartesia.FilePurpose purpose,
            long size,
            string status,
            string ownerId,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
            this.Size = size;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }

    }
}