
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Fires repeatedly as the model transcribes the current user turn.<br/>
    /// Example: {"type":"turn.update","transcript":"Hey can you help","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
    /// </summary>
    public sealed partial class STTAutoFinalizeTurnUpdate
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTAutoFinalizeTurnUpdateTypeJsonConverter))]
        public global::Cartesia.STTAutoFinalizeTurnUpdateType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="STTAutoFinalizeTurnUpdate" /> class.
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
        public STTAutoFinalizeTurnUpdate(
            string transcript,
            string requestId,
            global::Cartesia.STTAutoFinalizeTurnUpdateType type)
        {
            this.Type = type;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTAutoFinalizeTurnUpdate" /> class.
        /// </summary>
        public STTAutoFinalizeTurnUpdate()
        {
        }

    }
}