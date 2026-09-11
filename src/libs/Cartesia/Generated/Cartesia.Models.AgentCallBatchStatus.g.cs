
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The lifecycle status of a batch, derived at read time from dispatch progress.
    /// </summary>
    public enum AgentCallBatchStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
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
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCallBatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCallBatchStatus value)
        {
            return value switch
            {
                AgentCallBatchStatus.Cancelled => "cancelled",
                AgentCallBatchStatus.Completed => "completed",
                AgentCallBatchStatus.Failed => "failed",
                AgentCallBatchStatus.InProgress => "in_progress",
                AgentCallBatchStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCallBatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentCallBatchStatus.Cancelled,
                "completed" => AgentCallBatchStatus.Completed,
                "failed" => AgentCallBatchStatus.Failed,
                "in_progress" => AgentCallBatchStatus.InProgress,
                "pending" => AgentCallBatchStatus.Pending,
                _ => null,
            };
        }
    }
}