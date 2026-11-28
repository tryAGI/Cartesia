
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Fires after `turn.eager_end` if the user turn has not actually ended.
    /// </summary>
    public sealed partial class STTTurnsTurnResume
    {
        /// <summary>
        /// Event type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnResumeTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResumeType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="STTTurnsTurnResume" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this connection. Does not change between turns.
        /// </param>
        /// <param name="type">
        /// Event type identifier
        /// </param>
        /// <param name="turnId">
        /// Identifies the turn. Every event in a turn has the same `turn_id`, and each new turn gets a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsTurnResume(
            string requestId,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResumeType type,
            string? turnId)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.TurnId = turnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnResume" /> class.
        /// </summary>
        public STTTurnsTurnResume()
        {
        }

    }
}