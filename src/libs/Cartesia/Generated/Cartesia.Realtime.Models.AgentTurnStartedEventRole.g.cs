
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Who is speaking.
    /// </summary>
    public enum AgentTurnStartedEventRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTurnStartedEventRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnStartedEventRole value)
        {
            return value switch
            {
                AgentTurnStartedEventRole.Assistant => "assistant",
                AgentTurnStartedEventRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnStartedEventRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentTurnStartedEventRole.Assistant,
                "user" => AgentTurnStartedEventRole.User,
                _ => null,
            };
        }
    }
}