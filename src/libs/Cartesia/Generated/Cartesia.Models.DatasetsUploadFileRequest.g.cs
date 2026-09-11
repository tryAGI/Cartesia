
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsUploadFileRequest
    {
        /// <summary>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Purpose of the file<br/>
        /// Example: fine_tune
        /// </summary>
        /// <example>fine_tune</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsUploadFileRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="filename">
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="purpose">
        /// Purpose of the file<br/>
        /// Example: fine_tune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetsUploadFileRequest(
            byte[]? file,
            string? filename,
            string? purpose)
        {
            this.File = file;
            this.Filename = filename;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsUploadFileRequest" /> class.
        /// </summary>
        public DatasetsUploadFileRequest()
        {
        }

    }
}