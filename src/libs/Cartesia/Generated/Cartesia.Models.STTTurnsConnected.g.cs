
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Fires once when the WebSocket connection is established. You do not need to wait for this event before sending audio.<br/>
    /// Example: {"type":"connected","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
    /// </summary>
    public sealed partial class STTTurnsConnected
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTTurnsConnectedTypeJsonConverter))]
        public global::Cartesia.STTTurnsConnectedType Type { get; set; }

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
            global::Cartesia.STTTurnsConnectedType type)
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