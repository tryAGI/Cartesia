
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum TTSSSETimestampsEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSSSETimestampsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSSSETimestampsEventType value)
        {
            return value switch
            {
                TTSSSETimestampsEventType.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSSSETimestampsEventType? ToEnum(string value)
        {
            return value switch
            {
                "timestamps" => TTSSSETimestampsEventType.Timestamps,
                _ => null,
            };
        }
    }
}