
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Fires when the model predicts that the user might be done speaking.
    /// </summary>
    public sealed partial class STTTurnsTurnEagerEnd
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnEagerEndTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndType Type { get; set; }

        /// <summary>
        /// Cumulative text for the current turn.
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
        /// Initializes a new instance of the <see cref="STTTurnsTurnEagerEnd" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Cumulative text for the current turn.
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
        public STTTurnsTurnEagerEnd(
            string transcript,
            string requestId,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndType type)
        {
            this.Type = type;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnEagerEnd" /> class.
        /// </summary>
        public STTTurnsTurnEagerEnd()
        {
        }

    }
}