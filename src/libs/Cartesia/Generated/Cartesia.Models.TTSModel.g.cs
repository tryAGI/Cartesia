
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Text-to-speech models. See [the docs](https://docs.cartesia.ai/build-with-cartesia/tts-models/latest) for all options.
    /// </summary>
    public enum TTSModel
    {
        /// <summary>
        /// 
        /// </summary>
        Sonic3,
        /// <summary>
        /// 
        /// </summary>
        Sonic320251027,
        /// <summary>
        /// 
        /// </summary>
        Sonic320260112,
        /// <summary>
        /// 
        /// </summary>
        Sonic35,
        /// <summary>
        /// 
        /// </summary>
        Sonic3520260504,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSModel value)
        {
            return value switch
            {
                TTSModel.Sonic3 => "sonic-3",
                TTSModel.Sonic320251027 => "sonic-3-2025-10-27",
                TTSModel.Sonic320260112 => "sonic-3-2026-01-12",
                TTSModel.Sonic35 => "sonic-3.5",
                TTSModel.Sonic3520260504 => "sonic-3.5-2026-05-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSModel? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3" => TTSModel.Sonic3,
                "sonic-3-2025-10-27" => TTSModel.Sonic320251027,
                "sonic-3-2026-01-12" => TTSModel.Sonic320260112,
                "sonic-3.5" => TTSModel.Sonic35,
                "sonic-3.5-2026-05-04" => TTSModel.Sonic3520260504,
                _ => null,
            };
        }
    }
}