
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Configure the various attributes of the generated speech<br/>
    /// See [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) for details
    /// </summary>
    public sealed partial class GenerationRequestGenerationConfig
    {
        /// <summary>
        /// Adjust the volume of the generated speech between 0.5x and 2.0x the default volume. Valid values are between [0.5, 2.0] inclusive.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Adjust the speed of the generated speech between 0.6x and 1.5x the default speed. Valid values are between [0.6, 1.5] inclusive.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Optional. If omitted, the model interprets the emotional subtext of the transcript. Must match a valid option exactly.<br/>
        /// A complete list can be found on the [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestGenerationConfigEmotionJsonConverter))]
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestGenerationConfigEmotion? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestGenerationConfig" /> class.
        /// </summary>
        /// <param name="volume">
        /// Adjust the volume of the generated speech between 0.5x and 2.0x the default volume. Valid values are between [0.5, 2.0] inclusive.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="speed">
        /// Adjust the speed of the generated speech between 0.6x and 1.5x the default speed. Valid values are between [0.6, 1.5] inclusive.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="emotion">
        /// Optional. If omitted, the model interprets the emotional subtext of the transcript. Must match a valid option exactly.<br/>
        /// A complete list can be found on the [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequestGenerationConfig(
            double? volume,
            double? speed,
            global::Cartesia.Realtime.TextToSpeech.GenerationRequestGenerationConfigEmotion? emotion)
        {
            this.Volume = volume;
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestGenerationConfig" /> class.
        /// </summary>
        public GenerationRequestGenerationConfig()
        {
        }

    }
}