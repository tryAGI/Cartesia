
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A transcript chunk.<br/>
    /// Example: {"type":"transcript","is_final":true,"request_id":"b67e1c5d-2f4c-4c3d-9f82-96eb4d2f12a8","text":"How are you doing today?","duration":2.5,"language":"en","words":[{"word":"How","start":0,"end":0.12},{"word":"are","start":0.15,"end":0.25},{"word":"you","start":0.28,"end":0.35},{"word":"doing","start":0.38,"end":0.55},{"word":"today?","start":0.58,"end":0.78}]}
    /// </summary>
    public sealed partial class STTManualFinalizeTranscriptResponse
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTManualFinalizeTranscriptResponseTypeJsonConverter))]
        public global::Cartesia.STTManualFinalizeTranscriptResponseType Type { get; set; }

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
        /// Whether `text` is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// Duration of the audio that produced this chunk, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Detected language of the audio in ISO-639-1 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Word-level timing information for the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTManualFinalizeTranscriptResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this WebSocket connection.
        /// </param>
        /// <param name="text">
        /// Transcribed text. This is a delta from the last transcript chunk with `"is_final": true`.<br/>
        /// To assemble the full transcript, concatenate all transcript chunks where `"is_final": true`.<br/>
        /// Do not strip whitespace from `text` or add whitespace between chunks as this will produce an incorrect transcript.
        /// </param>
        /// <param name="isFinal">
        /// Whether `text` is finalized.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="duration">
        /// Duration of the audio that produced this chunk, in seconds.
        /// </param>
        /// <param name="language">
        /// Detected language of the audio in ISO-639-1 format.
        /// </param>
        /// <param name="words">
        /// Word-level timing information for the transcript.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTManualFinalizeTranscriptResponse(
            string requestId,
            string text,
            bool isFinal,
            global::Cartesia.STTManualFinalizeTranscriptResponseType type,
            double? duration,
            string? language,
            global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? words)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.IsFinal = isFinal;
            this.Duration = duration;
            this.Language = language;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTManualFinalizeTranscriptResponse" /> class.
        /// </summary>
        public STTManualFinalizeTranscriptResponse()
        {
        }

    }
}