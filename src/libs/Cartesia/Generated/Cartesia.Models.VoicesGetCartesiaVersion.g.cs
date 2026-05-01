
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesGetCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesGetCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesGetCartesiaVersion value)
        {
            return value switch
            {
                VoicesGetCartesiaVersion.x20260301 => "2026-03-01",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesGetCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-03-01" => VoicesGetCartesiaVersion.x20260301,
                _ => null,
            };
        }
    }
}