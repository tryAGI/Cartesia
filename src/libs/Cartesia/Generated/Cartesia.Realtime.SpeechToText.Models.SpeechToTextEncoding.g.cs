
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// The encoding format of the audio data. This determines how the server interprets the raw binary audio data you send.<br/>
    /// For guidance on choosing an encoding, see [Audio Input](/build-with-cartesia/stt/audio-input).
    /// </summary>
    public enum SpeechToTextEncoding
    {
        /// <summary>
        ///
        /// </summary>
        PcmAlaw,
        /// <summary>
        ///
        /// </summary>
        PcmF16le,
        /// <summary>
        ///
        /// </summary>
        PcmF32le,
        /// <summary>
        ///
        /// </summary>
        PcmMulaw,
        /// <summary>
        ///
        /// </summary>
        PcmS16le,
        /// <summary>
        ///
        /// </summary>
        PcmS32le,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechToTextEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextEncoding value)
        {
            return value switch
            {
                SpeechToTextEncoding.PcmAlaw => "pcm_alaw",
                SpeechToTextEncoding.PcmF16le => "pcm_f16le",
                SpeechToTextEncoding.PcmF32le => "pcm_f32le",
                SpeechToTextEncoding.PcmMulaw => "pcm_mulaw",
                SpeechToTextEncoding.PcmS16le => "pcm_s16le",
                SpeechToTextEncoding.PcmS32le => "pcm_s32le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_alaw" => SpeechToTextEncoding.PcmAlaw,
                "pcm_f16le" => SpeechToTextEncoding.PcmF16le,
                "pcm_f32le" => SpeechToTextEncoding.PcmF32le,
                "pcm_mulaw" => SpeechToTextEncoding.PcmMulaw,
                "pcm_s16le" => SpeechToTextEncoding.PcmS16le,
                "pcm_s32le" => SpeechToTextEncoding.PcmS32le,
                _ => null,
            };
        }
    }
}