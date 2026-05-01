
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Word-level timing information.<br/>
    /// Example: {"type":"timestamps","done":false,"status_code":206,"context_id":"872ec12d-bc63-4e1e-a241-4f58c879d105","word_timestamps":{"words":["Hello","world"],"start":[0,0.5],"end":[0.4,0.9]}}
    /// </summary>
    public sealed partial class TTSSSETimestampsEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeJsonConverter))]
        public global::Cartesia.TTSSSETimestampsEventType Type { get; set; }

        /// <summary>
        /// Whether this is the final event for the request. Always `false` for timestamps events.
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
        /// Word-level timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_timestamps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.WordTimestamps WordTimestamps { get; set; }

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
        /// Initializes a new instance of the <see cref="TTSSSETimestampsEvent" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether this is the final event for the request. Always `false` for timestamps events.
        /// </param>
        /// <param name="wordTimestamps">
        /// Word-level timing information.
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
        public TTSSSETimestampsEvent(
            bool done,
            global::Cartesia.WordTimestamps wordTimestamps,
            int statusCode,
            global::Cartesia.TTSSSETimestampsEventType type,
            string? contextId)
        {
            this.Type = type;
            this.Done = done;
            this.ContextId = contextId;
            this.WordTimestamps = wordTimestamps ?? throw new global::System.ArgumentNullException(nameof(wordTimestamps));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSETimestampsEvent" /> class.
        /// </summary>
        public TTSSSETimestampsEvent()
        {
        }
    }
}