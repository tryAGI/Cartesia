
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Transcript chunks.<br/>
    /// Send the `finalize` command when the user has finished speaking to get these chunks. The API can also send chunks before you send `finalize`.
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
        /// Whether `text` is finalized
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// Unique identifier for this WebSocket connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Text transcribed since the last chunk with `"is_final": true`.<br/>
        /// To build the full transcript, concatenate the `text` of every chunk where `"is_final": true`.<br/>
        /// Don't strip whitespace from `text` or add whitespace between chunks. Either one produces an incorrect transcript.
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
        /// Word-level timestamps, from `ink-preview` and `ink-whisper`. `ink-2` doesn't return them.<br/>
        /// With `ink-preview`, each event lists only the words completed since the previous event. A word's timestamps can arrive in a later event than its text, sometimes in an event with empty `text`. Left out when there are none. See [Word timestamps](/use-the-api/stt/word-timestamps).
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
        /// Whether `text` is finalized
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this WebSocket connection
        /// </param>
        /// <param name="text">
        /// Text transcribed since the last chunk with `"is_final": true`.<br/>
        /// To build the full transcript, concatenate the `text` of every chunk where `"is_final": true`.<br/>
        /// Don't strip whitespace from `text` or add whitespace between chunks. Either one produces an incorrect transcript.
        /// </param>
        /// <param name="type">
        /// Response type identifier
        /// </param>
        /// <param name="duration">
        /// Duration of the audio in seconds
        /// </param>
        /// <param name="words">
        /// Word-level timestamps, from `ink-preview` and `ink-whisper`. `ink-2` doesn't return them.<br/>
        /// With `ink-preview`, each event lists only the words completed since the previous event. A word's timestamps can arrive in a later event than its text, sometimes in an event with empty `text`. Left out when there are none. See [Word timestamps](/use-the-api/stt/word-timestamps).
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