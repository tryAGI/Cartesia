
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Phoneme-level timing information.<br/>
    /// Example: {"type":"phoneme_timestamps","done":false,"status_code":206,"context_id":"872ec12d-bc63-4e1e-a241-4f58c879d105","phoneme_timestamps":{"phonemes":["h","\u0259","l","o\u028A"],"start":[0.093,0.174,0.255,0.337],"end":[0.174,0.255,0.337,0.418]}}
    /// </summary>
    public sealed partial class TTSSSEPhonemeTimestampsEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeJsonConverter))]
        public global::Cartesia.TTSSSEPhonemeTimestampsEventType Type { get; set; }

        /// <summary>
        /// Whether this is the final event for the request. Always `false` for phoneme_timestamps events.
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
        /// Phoneme-level timing information.<br/>
        /// Example: {"phonemes":["h","\u0259","l","o\u028A"],"start":[0.093,0.174,0.255,0.337],"end":[0.174,0.255,0.337,0.418]}
        /// </summary>
        /// <example>{"phonemes":["h","\u0259","l","o\u028A"],"start":[0.093,0.174,0.255,0.337],"end":[0.174,0.255,0.337,0.418]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneme_timestamps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.PhonemeTimestamps PhonemeTimestamps { get; set; }

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
        /// Initializes a new instance of the <see cref="TTSSSEPhonemeTimestampsEvent" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether this is the final event for the request. Always `false` for phoneme_timestamps events.
        /// </param>
        /// <param name="phonemeTimestamps">
        /// Phoneme-level timing information.<br/>
        /// Example: {"phonemes":["h","\u0259","l","o\u028A"],"start":[0.093,0.174,0.255,0.337],"end":[0.174,0.255,0.337,0.418]}
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
        public TTSSSEPhonemeTimestampsEvent(
            bool done,
            global::Cartesia.PhonemeTimestamps phonemeTimestamps,
            int statusCode,
            global::Cartesia.TTSSSEPhonemeTimestampsEventType type,
            string? contextId)
        {
            this.Type = type;
            this.Done = done;
            this.ContextId = contextId;
            this.PhonemeTimestamps = phonemeTimestamps ?? throw new global::System.ArgumentNullException(nameof(phonemeTimestamps));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSEPhonemeTimestampsEvent" /> class.
        /// </summary>
        public TTSSSEPhonemeTimestampsEvent()
        {
        }
    }
}