
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTTurnsConnectedType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsConnectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsConnectedType value)
        {
            return value switch
            {
                STTTurnsConnectedType.Connected => "connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsConnectedType? ToEnum(string value)
        {
            return value switch
            {
                "connected" => STTTurnsConnectedType.Connected,
                _ => null,
            };
        }
    }
}