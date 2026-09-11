
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// The encoding format of the audio data. This determines how the server interprets the raw binary audio data you send.<br/>
    /// For guidance on choosing an encoding, see [Audio Input](/build-with-cartesia/stt/audio-input).
    /// </summary>
    public enum SpeechToTextTurnsEncoding
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
    public static class SpeechToTextTurnsEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextTurnsEncoding value)
        {
            return value switch
            {
                SpeechToTextTurnsEncoding.PcmAlaw => "pcm_alaw",
                SpeechToTextTurnsEncoding.PcmF16le => "pcm_f16le",
                SpeechToTextTurnsEncoding.PcmF32le => "pcm_f32le",
                SpeechToTextTurnsEncoding.PcmMulaw => "pcm_mulaw",
                SpeechToTextTurnsEncoding.PcmS16le => "pcm_s16le",
                SpeechToTextTurnsEncoding.PcmS32le => "pcm_s32le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextTurnsEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_alaw" => SpeechToTextTurnsEncoding.PcmAlaw,
                "pcm_f16le" => SpeechToTextTurnsEncoding.PcmF16le,
                "pcm_f32le" => SpeechToTextTurnsEncoding.PcmF32le,
                "pcm_mulaw" => SpeechToTextTurnsEncoding.PcmMulaw,
                "pcm_s16le" => SpeechToTextTurnsEncoding.PcmS16le,
                "pcm_s32le" => SpeechToTextTurnsEncoding.PcmS32le,
                _ => null,
            };
        }
    }
}