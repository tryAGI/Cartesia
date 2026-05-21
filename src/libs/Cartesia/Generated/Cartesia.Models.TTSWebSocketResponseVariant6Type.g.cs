
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSWebSocketResponseVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        PhonemeTimestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSWebSocketResponseVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSWebSocketResponseVariant6Type value)
        {
            return value switch
            {
                TTSWebSocketResponseVariant6Type.PhonemeTimestamps => "phoneme_timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSWebSocketResponseVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "phoneme_timestamps" => TTSWebSocketResponseVariant6Type.PhonemeTimestamps,
                _ => null,
            };
        }
    }
}