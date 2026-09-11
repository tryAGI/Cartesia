
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum PhonemeTimestampsResponseType
    {
        /// <summary>
        ///
        /// </summary>
        PhonemeTimestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhonemeTimestampsResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhonemeTimestampsResponseType value)
        {
            return value switch
            {
                PhonemeTimestampsResponseType.PhonemeTimestamps => "phoneme_timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhonemeTimestampsResponseType? ToEnum(string value)
        {
            return value switch
            {
                "phoneme_timestamps" => PhonemeTimestampsResponseType.PhonemeTimestamps,
                _ => null,
            };
        }
    }
}