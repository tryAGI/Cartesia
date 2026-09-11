
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// The agent's speech. `audio` is base64-encoded audio in the format declared in `session_create.audio.input_format`.
    /// </summary>
    public sealed partial class AgentAudioOutputEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioOutputEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentAudioOutputEventType Type { get; set; }

        /// <summary>
        /// Base64-encoded agent audio in the format declared in `session_create.audio.input_format`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAudioOutputEvent" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded agent audio in the format declared in `session_create.audio.input_format`.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAudioOutputEvent(
            string audio,
            global::Cartesia.Realtime.AgentAudioOutputEventType type)
        {
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAudioOutputEvent" /> class.
        /// </summary>
        public AgentAudioOutputEvent()
        {
        }

    }
}