
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Fires repeatedly as the model transcribes the current user turn.
    /// </summary>
    public sealed partial class STTTurnsTurnUpdate
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnUpdateTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateType Type { get; set; }

        /// <summary>
        /// Cumulative text for the current turn, i.e. the full text transcribed so far in this turn, not a delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Unique identifier for this connection. Does not change between turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnUpdate" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Cumulative text for the current turn, i.e. the full text transcribed so far in this turn, not a delta.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this connection. Does not change between turns.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsTurnUpdate(
            string transcript,
            string requestId,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateType type)
        {
            this.Type = type;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnUpdate" /> class.
        /// </summary>
        public STTTurnsTurnUpdate()
        {
        }

    }
}