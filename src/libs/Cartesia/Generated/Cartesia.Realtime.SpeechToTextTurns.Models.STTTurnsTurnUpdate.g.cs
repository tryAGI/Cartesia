
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Fires repeatedly as the model transcribes the current user turn.
    /// </summary>
    public sealed partial class STTTurnsTurnUpdate
    {
        /// <summary>
        /// Event type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnUpdateTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateType Type { get; set; }

        /// <summary>
        /// All text transcribed so far in the current turn, not just the new text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// `ink-preview` only. Every complete word in the turn so far, with timestamps. A word joins the list once the model has heard all of it, and it never changes after that. So during a turn, `words` can trail `transcript`. Left out when there are none.<br/>
        /// See [Word timestamps](/use-the-api/stt/word-timestamps).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateWord>? Words { get; set; }

        /// <summary>
        /// Unique identifier for this connection. Does not change between turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Identifies the turn. Every event in a turn has the same `turn_id`, and each new turn gets a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnUpdate" /> class.
        /// </summary>
        /// <param name="transcript">
        /// All text transcribed so far in the current turn, not just the new text
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this connection. Does not change between turns.
        /// </param>
        /// <param name="type">
        /// Event type identifier
        /// </param>
        /// <param name="words">
        /// `ink-preview` only. Every complete word in the turn so far, with timestamps. A word joins the list once the model has heard all of it, and it never changes after that. So during a turn, `words` can trail `transcript`. Left out when there are none.<br/>
        /// See [Word timestamps](/use-the-api/stt/word-timestamps).
        /// </param>
        /// <param name="turnId">
        /// Identifies the turn. Every event in a turn has the same `turn_id`, and each new turn gets a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsTurnUpdate(
            string transcript,
            string requestId,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateType type,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateWord>? words,
            string? turnId)
        {
            this.Type = type;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Words = words;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.TurnId = turnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnUpdate" /> class.
        /// </summary>
        public STTTurnsTurnUpdate()
        {
        }

    }
}