
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models/latest) for all options.<br/>
    /// Example: sonic-3.6
    /// </summary>
    public enum GenerationRequestModelId
    {
        /// <summary>
        ///
        /// </summary>
        Sonic3,
        /// <summary>
        ///
        /// </summary>
        Sonic35,
        /// <summary>
        ///
        /// </summary>
        Sonic36,
        /// <summary>
        ///
        /// </summary>
        SonicLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestModelId value)
        {
            return value switch
            {
                GenerationRequestModelId.Sonic3 => "sonic-3",
                GenerationRequestModelId.Sonic35 => "sonic-3.5",
                GenerationRequestModelId.Sonic36 => "sonic-3.6",
                GenerationRequestModelId.SonicLatest => "sonic-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestModelId? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3" => GenerationRequestModelId.Sonic3,
                "sonic-3.5" => GenerationRequestModelId.Sonic35,
                "sonic-3.6" => GenerationRequestModelId.Sonic36,
                "sonic-latest" => GenerationRequestModelId.SonicLatest,
                _ => null,
            };
        }
    }
}