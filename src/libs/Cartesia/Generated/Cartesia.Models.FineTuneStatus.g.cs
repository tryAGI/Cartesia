
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Status of a fine-tune
    /// </summary>
    public enum FineTuneStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Training,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneStatus value)
        {
            return value switch
            {
                FineTuneStatus.Created => "created",
                FineTuneStatus.Training => "training",
                FineTuneStatus.Completed => "completed",
                FineTuneStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => FineTuneStatus.Created,
                "training" => FineTuneStatus.Training,
                "completed" => FineTuneStatus.Completed,
                "failed" => FineTuneStatus.Failed,
                _ => null,
            };
        }
    }
}