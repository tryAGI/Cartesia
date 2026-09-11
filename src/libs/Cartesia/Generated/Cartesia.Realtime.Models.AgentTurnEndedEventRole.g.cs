
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Who spoke.
    /// </summary>
    public enum AgentTurnEndedEventRole
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
    public static class AgentTurnEndedEventRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnEndedEventRole value)
        {
            return value switch
            {
                AgentTurnEndedEventRole.Assistant => "assistant",
                AgentTurnEndedEventRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnEndedEventRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentTurnEndedEventRole.Assistant,
                "user" => AgentTurnEndedEventRole.User,
                _ => null,
            };
        }
    }
}