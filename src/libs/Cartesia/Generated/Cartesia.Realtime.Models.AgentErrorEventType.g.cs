
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentErrorEventType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentErrorEventType value)
        {
            return value switch
            {
                AgentErrorEventType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentErrorEventType.Error,
                _ => null,
            };
        }
    }
}