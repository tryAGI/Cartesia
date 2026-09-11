
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Generation completion signal
    /// </summary>
    public sealed partial class GenerationDoneResponse
    {
        /// <summary>
        /// Response type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationDoneResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponseType Type { get; set; }

        /// <summary>
        /// Whether generation is complete
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
        /// Initializes a new instance of the <see cref="GenerationDoneResponse" /> class.
        /// </summary>
        /// <param name="done">
        /// Whether generation is complete
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
        public GenerationDoneResponse(
            bool done,
            int statusCode,
            string contextId,
            global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponseType type)
        {
            this.Type = type;
            this.Done = done;
            this.StatusCode = statusCode;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationDoneResponse" /> class.
        /// </summary>
        public GenerationDoneResponse()
        {
        }

    }
}