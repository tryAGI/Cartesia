
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum RawEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        PcmF32le,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le,
        /// <summary>
        /// 
        /// </summary>
        PcmMulaw,
        /// <summary>
        /// 
        /// </summary>
        PcmAlaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RawEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RawEncoding value)
        {
            return value switch
            {
                RawEncoding.PcmF32le => "pcm_f32le",
                RawEncoding.PcmS16le => "pcm_s16le",
                RawEncoding.PcmMulaw => "pcm_mulaw",
                RawEncoding.PcmAlaw => "pcm_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RawEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_f32le" => RawEncoding.PcmF32le,
                "pcm_s16le" => RawEncoding.PcmS16le,
                "pcm_mulaw" => RawEncoding.PcmMulaw,
                "pcm_alaw" => RawEncoding.PcmAlaw,
                _ => null,
            };
        }
    }
}