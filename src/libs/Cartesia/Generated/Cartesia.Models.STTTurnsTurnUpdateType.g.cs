
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTTurnsTurnUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsTurnUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsTurnUpdateType value)
        {
            return value switch
            {
                STTTurnsTurnUpdateType.TurnUpdate => "turn.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsTurnUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "turn.update" => STTTurnsTurnUpdateType.TurnUpdate,
                _ => null,
            };
        }
    }
}