
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Acknowledgment that flush command was received. See [Context Flushing](/use-the-api/tts-websocket/context-flushing-and-flush-i-ds) for details.
    /// </summary>
    public sealed partial class FlushDoneResponse
    {
        /// <summary>
        /// Response type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.FlushDoneResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.TextToSpeech.FlushDoneResponseType Type { get; set; }

        /// <summary>
        /// Whether generation is complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Whether the flush is complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush_done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FlushDone { get; set; }

        /// <summary>
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1. This can be used to map chunks of audio to certain transcript submissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FlushId { get; set; }

        /// <summary>
        /// HTTP-style status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// See [Contexts](/use-the-api/tts-websocket/contexts) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlushDoneResponse" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether generation is complete
        /// </param>
        /// <param name="flushDone">
        /// Whether the flush is complete
        /// </param>
        /// <param name="flushId">
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1. This can be used to map chunks of audio to certain transcript submissions.
        /// </param>
        /// <param name="statusCode">
        /// HTTP-style status code
        /// </param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// See [Contexts](/use-the-api/tts-websocket/contexts) for details.
        /// </param>
        /// <param name="type">
        /// Response type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlushDoneResponse(
            bool done,
            bool flushDone,
            int flushId,
            int statusCode,
            string contextId,
            global::Cartesia.Realtime.TextToSpeech.FlushDoneResponseType type)
        {
            this.Type = type;
            this.Done = done;
            this.FlushDone = flushDone;
            this.FlushId = flushId;
            this.StatusCode = statusCode;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlushDoneResponse" /> class.
        /// </summary>
        public FlushDoneResponse()
        {
        }

    }
}