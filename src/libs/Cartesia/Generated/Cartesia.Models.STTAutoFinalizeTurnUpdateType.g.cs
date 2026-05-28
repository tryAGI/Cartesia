
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTAutoFinalizeTurnUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeTurnUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeTurnUpdateType value)
        {
            return value switch
            {
                STTAutoFinalizeTurnUpdateType.TurnUpdate => "turn.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeTurnUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "turn.update" => STTAutoFinalizeTurnUpdateType.TurnUpdate,
                _ => null,
            };
        }
    }
}