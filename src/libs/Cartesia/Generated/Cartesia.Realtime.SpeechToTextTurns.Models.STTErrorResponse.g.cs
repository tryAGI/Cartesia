
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Error information for STT WebSocket connections.
    /// </summary>
    public sealed partial class STTErrorResponse
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTErrorResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponseType Type { get; set; }

        /// <summary>
        /// Machine-readable error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// An HTTP response status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusCode { get; set; }

        /// <summary>
        /// Human-readable error title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// URL to relevant documentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_url")]
        public string? DocUrl { get; set; }

        /// <summary>
        /// Unique identifier for this websocket connection
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
        /// <param name="statusCode">
        /// An HTTP response status code.
        /// </param>
        /// <param name="title">
        /// Human-readable error title.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code.
        /// </param>
        /// <param name="docUrl">
        /// URL to relevant documentation
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this websocket connection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTErrorResponse(
            double statusCode,
            string title,
            string message,
            global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponseType type,
            string? errorCode,
            string? docUrl,
            string? requestId)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
            this.StatusCode = statusCode;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
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