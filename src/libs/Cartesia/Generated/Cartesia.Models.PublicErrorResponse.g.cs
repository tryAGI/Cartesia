
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicErrorResponse
    {
        /// <summary>
        /// URL to relevant documentation for the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_url")]
        public string? DocUrl { get; set; }

        /// <summary>
        /// Machine-readable error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Detailed human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Unique identifier for this request. Include this when contacting support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Short human-readable error summary, like "File too large"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicErrorResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Detailed human-readable error message
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this request. Include this when contacting support.
        /// </param>
        /// <param name="title">
        /// Short human-readable error summary, like "File too large"
        /// </param>
        /// <param name="docUrl">
        /// URL to relevant documentation for the error
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicErrorResponse(
            string message,
            string requestId,
            string title,
            string? docUrl,
            string? errorCode)
        {
            this.DocUrl = docUrl;
            this.ErrorCode = errorCode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicErrorResponse" /> class.
        /// </summary>
        public PublicErrorResponse()
        {
        }

    }
}