
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum PronunciationDictsDeleteCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictsDeleteCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictsDeleteCartesiaVersion value)
        {
            return value switch
            {
                PronunciationDictsDeleteCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictsDeleteCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-11-04" => PronunciationDictsDeleteCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}