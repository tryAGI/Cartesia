
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTunesGetCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTunesGetCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTunesGetCartesiaVersion value)
        {
            return value switch
            {
                FineTunesGetCartesiaVersion.x20260301 => "2026-03-01",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTunesGetCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-03-01" => FineTunesGetCartesiaVersion.x20260301,
                _ => null,
            };
        }
    }
}