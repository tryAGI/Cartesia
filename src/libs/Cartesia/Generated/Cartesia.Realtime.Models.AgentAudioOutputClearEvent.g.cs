
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Sent when the user starts speaking. Discard buffered agent audio and stop playback. The event can arrive while no agent audio is playing, in which case there is nothing to clear.
    /// </summary>
    public sealed partial class AgentAudioOutputClearEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioOutputClearEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentAudioOutputClearEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAudioOutputClearEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAudioOutputClearEvent(
            global::Cartesia.Realtime.AgentAudioOutputClearEventType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAudioOutputClearEvent" /> class.
        /// </summary>
        public AgentAudioOutputClearEvent()
        {
        }

    }
}