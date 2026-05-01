
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum PronunciationDictsUpdateCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictsUpdateCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictsUpdateCartesiaVersion value)
        {
            return value switch
            {
                PronunciationDictsUpdateCartesiaVersion.x20260301 => "2026-03-01",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictsUpdateCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-03-01" => PronunciationDictsUpdateCartesiaVersion.x20260301,
                _ => null,
            };
        }
    }
}