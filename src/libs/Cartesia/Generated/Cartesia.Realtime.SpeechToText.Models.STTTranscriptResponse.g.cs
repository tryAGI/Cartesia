
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Transcript chunks.<br/>
    /// You should send the `finalize` command after the user is done speaking to make the API emit these transcript chunks;<br/>
    /// although, the API may send transcript chunks even before you send the `finalize` command.
    /// </summary>
    public sealed partial class STTTranscriptResponse
    {
        /// <summary>
        /// Response type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTTranscriptResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseType Type { get; set; }

        /// <summary>
        /// Whether `text` is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// Unique identifier for this WebSocket connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Transcribed text. This is a delta from the last transcript chunk with `"is_final": true`.<br/>
        /// To assemble the full transcript, concatenate all transcript chunks where `"is_final": true`.<br/>
        /// Do not strip whitespace from `text` or add whitespace between chunks as this will produce an incorrect transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Duration of the audio in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Word-level timestamps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTranscriptResponse" /> class.
        /// </summary>
        /// <param name="isFinal">
        /// Whether `text` is finalized.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this WebSocket connection.
        /// </param>
        /// <param name="text">
        /// Transcribed text. This is a delta from the last transcript chunk with `"is_final": true`.<br/>
        /// To assemble the full transcript, concatenate all transcript chunks where `"is_final": true`.<br/>
        /// Do not strip whitespace from `text` or add whitespace between chunks as this will produce an incorrect transcript.
        /// </param>
        /// <param name="type">
        /// Response type identifier
        /// </param>
        /// <param name="duration">
        /// Duration of the audio in seconds
        /// </param>
        /// <param name="words">
        /// Word-level timestamps
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTranscriptResponse(
            bool isFinal,
            string requestId,
            string text,
            global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseType type,
            double? duration,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>? words)
        {
            this.Type = type;
            this.IsFinal = isFinal;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Duration = duration;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTranscriptResponse" /> class.
        /// </summary>
        public STTTranscriptResponse()
        {
        }

    }
}