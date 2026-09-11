
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// `invalid_event` for a rejected client event, `agent_failed` for an agent pipeline failure.
    /// </summary>
    public enum AgentErrorEventCode
    {
        /// <summary>
        ///
        /// </summary>
        AgentFailed,
        /// <summary>
        ///
        /// </summary>
        InvalidEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentErrorEventCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentErrorEventCode value)
        {
            return value switch
            {
                AgentErrorEventCode.AgentFailed => "agent_failed",
                AgentErrorEventCode.InvalidEvent => "invalid_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentErrorEventCode? ToEnum(string value)
        {
            return value switch
            {
                "agent_failed" => AgentErrorEventCode.AgentFailed,
                "invalid_event" => AgentErrorEventCode.InvalidEvent,
                _ => null,
            };
        }
    }
}