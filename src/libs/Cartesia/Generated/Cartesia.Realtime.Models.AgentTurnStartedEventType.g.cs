
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentTurnStartedEventType
    {
        /// <summary>
        ///
        /// </summary>
        TurnStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTurnStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnStartedEventType value)
        {
            return value switch
            {
                AgentTurnStartedEventType.TurnStarted => "turn_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "turn_started" => AgentTurnStartedEventType.TurnStarted,
                _ => null,
            };
        }
    }
}