
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum TTSSSEDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSSSEDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSSSEDoneEventType value)
        {
            return value switch
            {
                TTSSSEDoneEventType.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSSSEDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "done" => TTSSSEDoneEventType.Done,
                _ => null,
            };
        }
    }
}