
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
        Active,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
                AgentCallStatus.Active => "active",
                AgentCallStatus.Completed => "completed",
                AgentCallStatus.Failed => "failed",
                AgentCallStatus.Cancelled => "cancelled",
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
                "active" => AgentCallStatus.Active,
                "completed" => AgentCallStatus.Completed,
                "failed" => AgentCallStatus.Failed,
                "cancelled" => AgentCallStatus.Cancelled,
                _ => null,
            };
        }
    }
}