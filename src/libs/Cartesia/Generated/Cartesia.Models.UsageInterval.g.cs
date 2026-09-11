
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Groups usage data into buckets according to time.
    /// </summary>
    public enum UsageInterval
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageInterval value)
        {
            return value switch
            {
                UsageInterval.Day => "day",
                UsageInterval.Month => "month",
                UsageInterval.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageInterval? ToEnum(string value)
        {
            return value switch
            {
                "day" => UsageInterval.Day,
                "month" => UsageInterval.Month,
                "week" => UsageInterval.Week,
                _ => null,
            };
        }
    }
}