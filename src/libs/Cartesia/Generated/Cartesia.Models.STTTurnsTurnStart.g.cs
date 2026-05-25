
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Marks the start of a user turn. Fires quickly after the user begins speaking. This event can be used to interrupt your agent to avoid talking over the user.<br/>
    /// Example: {"type":"turn.start","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
    /// </summary>
    public sealed partial class STTTurnsTurnStart
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTTurnsTurnStartTypeJsonConverter))]
        public global::Cartesia.STTTurnsTurnStartType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="STTTurnsTurnStart" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this connection. Does not change between turns.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsTurnStart(
            string requestId,
            global::Cartesia.STTTurnsTurnStartType type)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnStart" /> class.
        /// </summary>
        public STTTurnsTurnStart()
        {
        }

    }
}