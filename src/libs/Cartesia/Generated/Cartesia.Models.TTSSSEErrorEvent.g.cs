
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Error information for the TTS SSE request.<br/>
    /// Example: {"type":"error","done":true,"title":"Invalid model","message":"The model is not valid, make sure it is a valid model ID.","error_code":"model_not_found","status_code":400,"doc_url":"https://docs.cartesia.ai/build-with-cartesia/tts-models/latest","request_id":"2ff8af53-4d38-479d-8287-58940f01c701","context_id":"50dc3b5e-5841-4aa1-9f94-60cfb9aead79"}
    /// </summary>
    public sealed partial class TTSSSEErrorEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSSSEErrorEventTypeJsonConverter))]
        public global::Cartesia.TTSSSEErrorEventType Type { get; set; }

        /// <summary>
        /// Whether generation is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// An HTTP response status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

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
        /// Machine-readable error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Unique identifier for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// URL to relevant documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_url")]
        public string? DocUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSEErrorEvent" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether generation is complete.
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
        /// <param name="requestId">
        /// Unique identifier for this request.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code.
        /// </param>
        /// <param name="docUrl">
        /// URL to relevant documentation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSSSEErrorEvent(
            bool done,
            int statusCode,
            string title,
            string message,
            string requestId,
            global::Cartesia.TTSSSEErrorEventType type,
            string? errorCode,
            string? docUrl)
        {
            this.Type = type;
            this.Done = done;
            this.StatusCode = statusCode;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ErrorCode = errorCode;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.DocUrl = docUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSEErrorEvent" /> class.
        /// </summary>
        public TTSSSEErrorEvent()
        {
        }
    }
}