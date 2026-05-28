
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTAutoFinalizeTurnStartType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeTurnStartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeTurnStartType value)
        {
            return value switch
            {
                STTAutoFinalizeTurnStartType.TurnStart => "turn.start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeTurnStartType? ToEnum(string value)
        {
            return value switch
            {
                "turn.start" => STTAutoFinalizeTurnStartType.TurnStart,
                _ => null,
            };
        }
    }
}