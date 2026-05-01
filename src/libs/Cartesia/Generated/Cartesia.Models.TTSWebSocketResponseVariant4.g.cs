
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSWebSocketResponseVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant4TypeJsonConverter))]
        public global::Cartesia.TTSWebSocketResponseVariant4Type Type { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// HTTP-style status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Whether generation is complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Word-level timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_timestamps")]
        public global::Cartesia.WordTimestamps? WordTimestamps { get; set; }

        /// <summary>
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush_id")]
        public int? FlushId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSWebSocketResponseVariant4" /> class.
        /// </summary>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </param>
        /// <param name="statusCode">
        /// HTTP-style status code
        /// </param>
        /// <param name="done">
        /// Whether generation is complete
        /// </param>
        /// <param name="type"></param>
        /// <param name="wordTimestamps">
        /// Word-level timing information.
        /// </param>
        /// <param name="flushId">
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSWebSocketResponseVariant4(
            string contextId,
            int statusCode,
            bool done,
            global::Cartesia.TTSWebSocketResponseVariant4Type type,
            global::Cartesia.WordTimestamps? wordTimestamps,
            int? flushId)
        {
            this.Type = type;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.StatusCode = statusCode;
            this.Done = done;
            this.WordTimestamps = wordTimestamps;
            this.FlushId = flushId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSWebSocketResponseVariant4" /> class.
        /// </summary>
        public TTSWebSocketResponseVariant4()
        {
        }
    }
}