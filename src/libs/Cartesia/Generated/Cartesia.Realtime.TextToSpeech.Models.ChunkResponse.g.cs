
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Audio data chunk
    /// </summary>
    public sealed partial class ChunkResponse
    {
        /// <summary>
        /// Response type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.ChunkResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.TextToSpeech.ChunkResponseType Type { get; set; }

        /// <summary>
        /// Base64-encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Whether this is the final chunk for this context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// HTTP-style status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Server-side processing time for this chunk in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepTime { get; set; }

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
        /// Initializes a new instance of the <see cref="ChunkResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data
        /// </param>
        /// <param name="done">
        /// Whether this is the final chunk for this context
        /// </param>
        /// <param name="statusCode">
        /// HTTP-style status code
        /// </param>
        /// <param name="stepTime">
        /// Server-side processing time for this chunk in milliseconds
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
        public ChunkResponse(
            string data,
            bool done,
            int statusCode,
            double stepTime,
            string contextId,
            global::Cartesia.Realtime.TextToSpeech.ChunkResponseType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Done = done;
            this.StatusCode = statusCode;
            this.StepTime = stepTime;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkResponse" /> class.
        /// </summary>
        public ChunkResponse()
        {
        }

    }
}