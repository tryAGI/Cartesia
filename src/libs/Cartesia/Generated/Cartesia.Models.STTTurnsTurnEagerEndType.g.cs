
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTTurnsTurnEagerEndType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnEagerEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsTurnEagerEndTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsTurnEagerEndType value)
        {
            return value switch
            {
                STTTurnsTurnEagerEndType.TurnEagerEnd => "turn.eager_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsTurnEagerEndType? ToEnum(string value)
        {
            return value switch
            {
                "turn.eager_end" => STTTurnsTurnEagerEndType.TurnEagerEnd,
                _ => null,
            };
        }
    }
}