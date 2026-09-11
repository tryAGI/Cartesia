
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Default Value: 2026-08-14<br/>
    /// Example: 2026-08-14
    /// </summary>
    public enum AgentsRemoveMetricFromAgentCartesiaVersion
    {
        /// <summary>
        ///
        /// </summary>
        x20260814,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsRemoveMetricFromAgentCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsRemoveMetricFromAgentCartesiaVersion value)
        {
            return value switch
            {
                AgentsRemoveMetricFromAgentCartesiaVersion.x20260814 => "2026-08-14",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsRemoveMetricFromAgentCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-08-14" => AgentsRemoveMetricFromAgentCartesiaVersion.x20260814,
                _ => null,
            };
        }
    }
}