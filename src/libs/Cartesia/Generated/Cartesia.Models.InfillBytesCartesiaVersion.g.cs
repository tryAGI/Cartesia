
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum InfillBytesCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InfillBytesCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InfillBytesCartesiaVersion value)
        {
            return value switch
            {
                InfillBytesCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InfillBytesCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => InfillBytesCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}