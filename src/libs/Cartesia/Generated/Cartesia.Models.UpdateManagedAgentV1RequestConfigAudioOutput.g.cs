
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigAudioOutput
    {
        /// <summary>
        /// Background audio played during the conversation. Set to `null` to disable it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_sound")]
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? BackgroundSound { get; set; }

        /// <summary>
        /// Text-to-speech emotion supported by the selected voice and model, such as `calm`, `happy`, or `sad`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// ID of the pronunciation dictionary used for agent speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_id")]
        public string? PronunciationDictionaryId { get; set; }

        /// <summary>
        /// Speech speed multiplier, from `0.6` to `1.5`. Set to `null` to use the default speed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// ID of the voice used for agent speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Speech volume multiplier, from `0.5` to `2`. Set to `null` to use the default volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigAudioOutput" /> class.
        /// </summary>
        /// <param name="backgroundSound">
        /// Background audio played during the conversation. Set to `null` to disable it.
        /// </param>
        /// <param name="emotion">
        /// Text-to-speech emotion supported by the selected voice and model, such as `calm`, `happy`, or `sad`.
        /// </param>
        /// <param name="pronunciationDictionaryId">
        /// ID of the pronunciation dictionary used for agent speech.
        /// </param>
        /// <param name="speed">
        /// Speech speed multiplier, from `0.6` to `1.5`. Set to `null` to use the default speed.
        /// </param>
        /// <param name="voiceId">
        /// ID of the voice used for agent speech.
        /// </param>
        /// <param name="volume">
        /// Speech volume multiplier, from `0.5` to `2`. Set to `null` to use the default volume.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1RequestConfigAudioOutput(
            global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? backgroundSound,
            string? emotion,
            string? pronunciationDictionaryId,
            double? speed,
            string? voiceId,
            double? volume)
        {
            this.BackgroundSound = backgroundSound;
            this.Emotion = emotion;
            this.PronunciationDictionaryId = pronunciationDictionaryId;
            this.Speed = speed;
            this.VoiceId = voiceId;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigAudioOutput" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigAudioOutput()
        {
        }

    }
}