
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Fires once when the WebSocket connection is established.<br/>
    /// You do not need to wait for this event before sending audio.
    /// </summary>
    public sealed partial class STTTurnsConnected
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConnectedTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnectedType Type { get; set; }

        /// <summary>
        /// Unique identifier for this connection.
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
        /// Initializes a new instance of the <see cref="STTTurnsConnected" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this connection.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsConnected(
            string requestId,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnectedType type)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConnected" /> class.
        /// </summary>
        public STTTurnsConnected()
        {
        }

    }
}