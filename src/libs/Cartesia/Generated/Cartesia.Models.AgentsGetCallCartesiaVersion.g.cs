
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsGetCallCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsGetCallCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsGetCallCartesiaVersion value)
        {
            return value switch
            {
                AgentsGetCallCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsGetCallCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => AgentsGetCallCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}