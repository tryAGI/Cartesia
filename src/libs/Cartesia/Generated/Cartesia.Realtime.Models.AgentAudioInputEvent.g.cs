
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Streams user audio to the agent. Send chunks continuously (for example every 20–100 ms) for the best latency. `audio` must be base64-encoded audio in the format declared in `session_create.audio.input_format`. Wait for `session_ready` before sending audio; audio sent earlier is dropped.
    /// </summary>
    public sealed partial class AgentAudioInputEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioInputEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentAudioInputEventType Type { get; set; }

        /// <summary>
        /// Base64-encoded audio in the format declared in `session_create.audio.input_format`.
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
        /// Initializes a new instance of the <see cref="AgentAudioInputEvent" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio in the format declared in `session_create.audio.input_format`.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAudioInputEvent(
            string audio,
            global::Cartesia.Realtime.AgentAudioInputEventType type)
        {
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAudioInputEvent" /> class.
        /// </summary>
        public AgentAudioInputEvent()
        {
        }

    }
}