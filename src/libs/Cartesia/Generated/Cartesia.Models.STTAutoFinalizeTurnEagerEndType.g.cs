
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTAutoFinalizeTurnEagerEndType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnEagerEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeTurnEagerEndTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeTurnEagerEndType value)
        {
            return value switch
            {
                STTAutoFinalizeTurnEagerEndType.TurnEagerEnd => "turn.eager_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeTurnEagerEndType? ToEnum(string value)
        {
            return value switch
            {
                "turn.eager_end" => STTAutoFinalizeTurnEagerEndType.TurnEagerEnd,
                _ => null,
            };
        }
    }
}