
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsTemplatesCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsTemplatesCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsTemplatesCartesiaVersion value)
        {
            return value switch
            {
                AgentsTemplatesCartesiaVersion.x20260301 => "2026-03-01",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsTemplatesCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-03-01" => AgentsTemplatesCartesiaVersion.x20260301,
                _ => null,
            };
        }
    }
}