
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTTurnsTurnEndType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsTurnEndTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsTurnEndType value)
        {
            return value switch
            {
                STTTurnsTurnEndType.TurnEnd => "turn.end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsTurnEndType? ToEnum(string value)
        {
            return value switch
            {
                "turn.end" => STTTurnsTurnEndType.TurnEnd,
                _ => null,
            };
        }
    }
}