
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesLocalizeCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesLocalizeCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesLocalizeCartesiaVersion value)
        {
            return value switch
            {
                VoicesLocalizeCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesLocalizeCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => VoicesLocalizeCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}