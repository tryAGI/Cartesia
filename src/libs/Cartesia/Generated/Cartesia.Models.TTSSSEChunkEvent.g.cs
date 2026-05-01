
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Audio data chunk.<br/>
    /// Example: {"type":"chunk","done":false,"status_code":206,"step_time":123,"context_id":"50dc3b5e-5841-4aa1-9f94-60cfb9aead79","data":"aSDinaTvuI8gbWludGxpZnk="}
    /// </summary>
    public sealed partial class TTSSSEChunkEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSSSEChunkEventTypeJsonConverter))]
        public global::Cartesia.TTSSSEChunkEventType Type { get; set; }

        /// <summary>
        /// Whether this is the final event for the request. Always `false` for chunk events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Server-side processing time for this chunk in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepTime { get; set; }

        /// <summary>
        /// HTTP-style status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSEChunkEvent" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether this is the final event for the request. Always `false` for chunk events.
        /// </param>
        /// <param name="data">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="stepTime">
        /// Server-side processing time for this chunk in milliseconds.
        /// </param>
        /// <param name="statusCode">
        /// HTTP-style status code.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSSSEChunkEvent(
            bool done,
            string data,
            double stepTime,
            int statusCode,
            global::Cartesia.TTSSSEChunkEventType type,
            string? contextId)
        {
            this.Type = type;
            this.Done = done;
            this.ContextId = contextId;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.StepTime = stepTime;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSEChunkEvent" /> class.
        /// </summary>
        public TTSSSEChunkEvent()
        {
        }
    }
}