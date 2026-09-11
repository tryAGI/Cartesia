
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The status of an agent call.
    /// </summary>
    public enum AgentCallStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCallStatus value)
        {
            return value switch
            {
                AgentCallStatus.Completed => "completed",
                AgentCallStatus.Created => "created",
                AgentCallStatus.Failed => "failed",
                AgentCallStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AgentCallStatus.Completed,
                "created" => AgentCallStatus.Created,
                "failed" => AgentCallStatus.Failed,
                "started" => AgentCallStatus.Started,
                _ => null,
            };
        }
    }
}