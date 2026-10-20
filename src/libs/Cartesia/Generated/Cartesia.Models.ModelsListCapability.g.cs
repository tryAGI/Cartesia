
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelsListCapability
    {
        /// <summary>
        ///
        /// </summary>
        Stt,
        /// <summary>
        ///
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsListCapabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsListCapability value)
        {
            return value switch
            {
                ModelsListCapability.Stt => "stt",
                ModelsListCapability.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsListCapability? ToEnum(string value)
        {
            return value switch
            {
                "stt" => ModelsListCapability.Stt,
                "tts" => ModelsListCapability.Tts,
                _ => null,
            };
        }
    }
}