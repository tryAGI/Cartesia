
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceChangerBytesCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceChangerBytesCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceChangerBytesCartesiaVersion value)
        {
            return value switch
            {
                VoiceChangerBytesCartesiaVersion.x20260301 => "2026-03-01",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceChangerBytesCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-03-01" => VoiceChangerBytesCartesiaVersion.x20260301,
                _ => null,
            };
        }
    }
}