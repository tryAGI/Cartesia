
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentSessionCreateEventType
    {
        /// <summary>
        ///
        /// </summary>
        SessionCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionCreateEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionCreateEventType value)
        {
            return value switch
            {
                AgentSessionCreateEventType.SessionCreate => "session_create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionCreateEventType? ToEnum(string value)
        {
            return value switch
            {
                "session_create" => AgentSessionCreateEventType.SessionCreate,
                _ => null,
            };
        }
    }
}