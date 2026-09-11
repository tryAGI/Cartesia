
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentTurnEndedEventType
    {
        /// <summary>
        ///
        /// </summary>
        TurnEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTurnEndedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnEndedEventType value)
        {
            return value switch
            {
                AgentTurnEndedEventType.TurnEnded => "turn_ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnEndedEventType? ToEnum(string value)
        {
            return value switch
            {
                "turn_ended" => AgentTurnEndedEventType.TurnEnded,
                _ => null,
            };
        }
    }
}