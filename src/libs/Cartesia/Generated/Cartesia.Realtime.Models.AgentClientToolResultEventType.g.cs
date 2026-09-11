
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentClientToolResultEventType
    {
        /// <summary>
        ///
        /// </summary>
        ClientToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentClientToolResultEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentClientToolResultEventType value)
        {
            return value switch
            {
                AgentClientToolResultEventType.ClientToolResult => "client_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentClientToolResultEventType? ToEnum(string value)
        {
            return value switch
            {
                "client_tool_result" => AgentClientToolResultEventType.ClientToolResult,
                _ => null,
            };
        }
    }
}