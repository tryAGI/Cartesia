
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum TimestampsResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimestampsResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimestampsResponseType value)
        {
            return value switch
            {
                TimestampsResponseType.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimestampsResponseType? ToEnum(string value)
        {
            return value switch
            {
                "timestamps" => TimestampsResponseType.Timestamps,
                _ => null,
            };
        }
    }
}