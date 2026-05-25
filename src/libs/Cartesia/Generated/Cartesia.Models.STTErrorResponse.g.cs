
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Error information for STT WebSocket connections.<br/>
    /// Example: {"type":"error","title":"Invalid model","message":"The model is not valid, make sure it is a valid model ID.","error_code":"model_not_found","doc_url":"https://docs.cartesia.ai/build-with-cartesia/stt-models/latest","status_code":400,"request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
    /// </summary>
    public sealed partial class STTErrorResponse
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTErrorResponseTypeJsonConverter))]
        public global::Cartesia.STTErrorResponseType Type { get; set; }

        /// <summary>
        /// Machine-readable error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// An HTTP response status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Human-readable error title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// URL to relevant documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_url")]
        public string? DocUrl { get; set; }

        /// <summary>
        /// Unique identifier for this WebSocket connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTErrorResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code.
        /// </param>
        /// <param name="statusCode">
        /// An HTTP response status code.
        /// </param>
        /// <param name="title">
        /// Human-readable error title.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="docUrl">
        /// URL to relevant documentation.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this WebSocket connection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTErrorResponse(
            global::Cartesia.STTErrorResponseType type,
            string? errorCode,
            int? statusCode,
            string? title,
            string? message,
            string? docUrl,
            string? requestId)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
            this.StatusCode = statusCode;
            this.Title = title;
            this.Message = message;
            this.DocUrl = docUrl;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTErrorResponse" /> class.
        /// </summary>
        public STTErrorResponse()
        {
        }

    }
}