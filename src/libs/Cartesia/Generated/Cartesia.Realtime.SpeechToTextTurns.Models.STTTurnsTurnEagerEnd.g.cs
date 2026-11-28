
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Fires when the model predicts that the user might be done speaking.
    /// </summary>
    public sealed partial class STTTurnsTurnEagerEnd
    {
        /// <summary>
        /// Event type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnEagerEndTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndType Type { get; set; }

        /// <summary>
        /// All text transcribed so far in the current turn. It can be empty. Don't start a reply for an empty transcript. See [Turn detection](/use-the-api/stt/turns).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// `ink-preview` only. Every word in the turn, with timestamps. Left out when there are none.<br/>
        /// See [Word timestamps](/use-the-api/stt/word-timestamps).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndWord>? Words { get; set; }

        /// <summary>
        /// `ink-preview` only. The languages spoken in the turn, highest confidence first. It lists the languages the model is confident about, or only the most likely one if it isn't confident about any. If it's left out, treat the language as unknown.<br/>
        /// See [Detected languages](/use-the-api/stt/languages#detected-languages).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndLanguage>? Languages { get; set; }

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
        /// Initializes a new instance of the <see cref="STTTurnsTurnEagerEnd" /> class.
        /// </summary>
        /// <param name="transcript">
        /// All text transcribed so far in the current turn. It can be empty. Don't start a reply for an empty transcript. See [Turn detection](/use-the-api/stt/turns).
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this connection. Does not change between turns.
        /// </param>
        /// <param name="type">
        /// Event type identifier
        /// </param>
        /// <param name="words">
        /// `ink-preview` only. Every word in the turn, with timestamps. Left out when there are none.<br/>
        /// See [Word timestamps](/use-the-api/stt/word-timestamps).
        /// </param>
        /// <param name="languages">
        /// `ink-preview` only. The languages spoken in the turn, highest confidence first. It lists the languages the model is confident about, or only the most likely one if it isn't confident about any. If it's left out, treat the language as unknown.<br/>
        /// See [Detected languages](/use-the-api/stt/languages#detected-languages).
        /// </param>
        /// <param name="turnId">
        /// Identifies the turn. Every event in a turn has the same `turn_id`, and each new turn gets a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsTurnEagerEnd(
            string transcript,
            string requestId,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndType type,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndWord>? words,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndLanguage>? languages,
            string? turnId)
        {
            this.Type = type;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Words = words;
            this.Languages = languages;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.TurnId = turnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnEagerEnd" /> class.
        /// </summary>
        public STTTurnsTurnEagerEnd()
        {
        }

    }
}