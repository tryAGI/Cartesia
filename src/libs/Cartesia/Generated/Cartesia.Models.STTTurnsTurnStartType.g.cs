
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTTurnsTurnStartType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsTurnStartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsTurnStartType value)
        {
            return value switch
            {
                STTTurnsTurnStartType.TurnStart => "turn.start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsTurnStartType? ToEnum(string value)
        {
            return value switch
            {
                "turn.start" => STTTurnsTurnStartType.TurnStart,
                _ => null,
            };
        }
    }
}