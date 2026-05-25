
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Command type. Send this as a JSON-encoded WebSocket text frame to close the session.
    /// </summary>
    public enum STTTurnsCloseCommandType
    {
        /// <summary>
        /// 
        /// </summary>
        Close,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsCloseCommandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsCloseCommandType value)
        {
            return value switch
            {
                STTTurnsCloseCommandType.Close => "close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsCloseCommandType? ToEnum(string value)
        {
            return value switch
            {
                "close" => STTTurnsCloseCommandType.Close,
                _ => null,
            };
        }
    }
}