
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentSessionReadyEventType
    {
        /// <summary>
        ///
        /// </summary>
        SessionReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionReadyEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionReadyEventType value)
        {
            return value switch
            {
                AgentSessionReadyEventType.SessionReady => "session_ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionReadyEventType? ToEnum(string value)
        {
            return value switch
            {
                "session_ready" => AgentSessionReadyEventType.SessionReady,
                _ => null,
            };
        }
    }
}