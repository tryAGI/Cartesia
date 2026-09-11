
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Optional. If omitted, the model interprets the emotional subtext of the transcript. Must match a valid option exactly.<br/>
    /// A complete list can be found on the [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) page.
    /// </summary>
    public enum GenerationRequestGenerationConfigEmotion
    {
        /// <summary>
        ///
        /// </summary>
        Angry,
        /// <summary>
        ///
        /// </summary>
        Calm,
        /// <summary>
        ///
        /// </summary>
        Content,
        /// <summary>
        ///
        /// </summary>
        Neutral,
        /// <summary>
        ///
        /// </summary>
        Sad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestGenerationConfigEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestGenerationConfigEmotion value)
        {
            return value switch
            {
                GenerationRequestGenerationConfigEmotion.Angry => "angry",
                GenerationRequestGenerationConfigEmotion.Calm => "calm",
                GenerationRequestGenerationConfigEmotion.Content => "content",
                GenerationRequestGenerationConfigEmotion.Neutral => "neutral",
                GenerationRequestGenerationConfigEmotion.Sad => "sad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestGenerationConfigEmotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => GenerationRequestGenerationConfigEmotion.Angry,
                "calm" => GenerationRequestGenerationConfigEmotion.Calm,
                "content" => GenerationRequestGenerationConfigEmotion.Content,
                "neutral" => GenerationRequestGenerationConfigEmotion.Neutral,
                "sad" => GenerationRequestGenerationConfigEmotion.Sad,
                _ => null,
            };
        }
    }
}