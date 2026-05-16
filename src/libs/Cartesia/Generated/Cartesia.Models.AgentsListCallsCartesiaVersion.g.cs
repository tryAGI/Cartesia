
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsListCallsCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsListCallsCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsListCallsCartesiaVersion value)
        {
            return value switch
            {
                AgentsListCallsCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsListCallsCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => AgentsListCallsCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}