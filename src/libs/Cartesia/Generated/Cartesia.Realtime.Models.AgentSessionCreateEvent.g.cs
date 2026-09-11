
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Configures the session's audio. **This must be the first message sent.** The server closes the connection if any other event arrives first, or if no event arrives within 10 seconds. Unknown fields are rejected.
    /// </summary>
    public sealed partial class AgentSessionCreateEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentSessionCreateEventType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.AgentSessionCreateEventAudio Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionCreateEvent" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionCreateEvent(
            global::Cartesia.Realtime.AgentSessionCreateEventAudio audio,
            global::Cartesia.Realtime.AgentSessionCreateEventType type)
        {
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionCreateEvent" /> class.
        /// </summary>
        public AgentSessionCreateEvent()
        {
        }

    }
}