
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionCreateEventAudio
    {
        /// <summary>
        /// Format of the audio your client sends. Agent audio is returned in the same format. Required, because a sample rate that mismatches your capture format fails silently as garbled audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventAudioInputFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.AgentSessionCreateEventAudioInputFormat InputFormat { get; set; }

        /// <summary>
        /// How the server delivers agent audio. `speaking_pace` paces audio to playback speed. `as_available` sends it as fast as the model produces it, so a client that buffers locally can play it back on its own clock for lower latency. Not supported when the agent uses a background sound.<br/>
        /// Default Value: speaking_pace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventAudioOutputDeliveryJsonConverter))]
        public global::Cartesia.Realtime.AgentSessionCreateEventAudioOutputDelivery? OutputDelivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionCreateEventAudio" /> class.
        /// </summary>
        /// <param name="inputFormat">
        /// Format of the audio your client sends. Agent audio is returned in the same format. Required, because a sample rate that mismatches your capture format fails silently as garbled audio.
        /// </param>
        /// <param name="outputDelivery">
        /// How the server delivers agent audio. `speaking_pace` paces audio to playback speed. `as_available` sends it as fast as the model produces it, so a client that buffers locally can play it back on its own clock for lower latency. Not supported when the agent uses a background sound.<br/>
        /// Default Value: speaking_pace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionCreateEventAudio(
            global::Cartesia.Realtime.AgentSessionCreateEventAudioInputFormat inputFormat,
            global::Cartesia.Realtime.AgentSessionCreateEventAudioOutputDelivery? outputDelivery)
        {
            this.InputFormat = inputFormat;
            this.OutputDelivery = outputDelivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionCreateEventAudio" /> class.
        /// </summary>
        public AgentSessionCreateEventAudio()
        {
        }

    }
}