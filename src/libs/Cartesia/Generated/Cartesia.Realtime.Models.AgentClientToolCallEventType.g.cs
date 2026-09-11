
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentClientToolCallEventType
    {
        /// <summary>
        ///
        /// </summary>
        ClientToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentClientToolCallEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentClientToolCallEventType value)
        {
            return value switch
            {
                AgentClientToolCallEventType.ClientToolCall => "client_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentClientToolCallEventType? ToEnum(string value)
        {
            return value switch
            {
                "client_tool_call" => AgentClientToolCallEventType.ClientToolCall,
                _ => null,
            };
        }
    }
}