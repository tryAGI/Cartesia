
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionConfigAudioOutput
    {
        /// <summary>
        /// ID of the voice used for agent speech during this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Speech speed multiplier from `0.6` to `1.5`. Set to `null` to use the default speed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Text-to-speech emotion. Set to `null` to let the model infer the emotion from the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.EmotionJsonConverter))]
        public global::Cartesia.Emotion? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfigAudioOutput" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// ID of the voice used for agent speech during this call.
        /// </param>
        /// <param name="speed">
        /// Speech speed multiplier from `0.6` to `1.5`. Set to `null` to use the default speed.
        /// </param>
        /// <param name="emotion">
        /// Text-to-speech emotion. Set to `null` to let the model infer the emotion from the transcript.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionConfigAudioOutput(
            string? voiceId,
            double? speed,
            global::Cartesia.Emotion? emotion)
        {
            this.VoiceId = voiceId;
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfigAudioOutput" /> class.
        /// </summary>
        public AgentSessionConfigAudioOutput()
        {
        }

    }
}