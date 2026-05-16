
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsListMetricResultsCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsListMetricResultsCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsListMetricResultsCartesiaVersion value)
        {
            return value switch
            {
                AgentsListMetricResultsCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsListMetricResultsCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => AgentsListMetricResultsCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}