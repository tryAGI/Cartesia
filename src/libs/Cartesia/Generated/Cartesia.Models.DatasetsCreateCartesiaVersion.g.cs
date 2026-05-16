
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetsCreateCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsCreateCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsCreateCartesiaVersion value)
        {
            return value switch
            {
                DatasetsCreateCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsCreateCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => DatasetsCreateCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}