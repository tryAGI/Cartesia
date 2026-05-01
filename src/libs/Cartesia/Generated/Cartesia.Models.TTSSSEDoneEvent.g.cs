
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Generation completion signal. Final event in the stream.<br/>
    /// Example: {"type":"done","done":true,"status_code":206,"context_id":"50dc3b5e-5841-4aa1-9f94-60cfb9aead79"}
    /// </summary>
    public sealed partial class TTSSSEDoneEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSSSEDoneEventTypeJsonConverter))]
        public global::Cartesia.TTSSSEDoneEventType Type { get; set; }

        /// <summary>
        /// Whether generation is complete. Always `true` for done events.
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
        /// Initializes a new instance of the <see cref="TTSSSEDoneEvent" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether generation is complete. Always `true` for done events.
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
        public TTSSSEDoneEvent(
            bool done,
            int statusCode,
            global::Cartesia.TTSSSEDoneEventType type,
            string? contextId)
        {
            this.Type = type;
            this.Done = done;
            this.ContextId = contextId;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSEDoneEvent" /> class.
        /// </summary>
        public TTSSSEDoneEvent()
        {
        }
    }
}