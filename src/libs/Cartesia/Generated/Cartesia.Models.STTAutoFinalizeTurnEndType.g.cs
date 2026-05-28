
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTAutoFinalizeTurnEndType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeTurnEndTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeTurnEndType value)
        {
            return value switch
            {
                STTAutoFinalizeTurnEndType.TurnEnd => "turn.end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeTurnEndType? ToEnum(string value)
        {
            return value switch
            {
                "turn.end" => STTAutoFinalizeTurnEndType.TurnEnd,
                _ => null,
            };
        }
    }
}