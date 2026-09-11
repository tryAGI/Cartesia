
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Audio encoding format. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
    /// </summary>
    public enum GenerationRequestOutputFormatEncoding
    {
        /// <summary>
        ///
        /// </summary>
        PcmAlaw,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestOutputFormatEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestOutputFormatEncoding value)
        {
            return value switch
            {
                GenerationRequestOutputFormatEncoding.PcmAlaw => "pcm_alaw",
                GenerationRequestOutputFormatEncoding.PcmF32le => "pcm_f32le",
                GenerationRequestOutputFormatEncoding.PcmMulaw => "pcm_mulaw",
                GenerationRequestOutputFormatEncoding.PcmS16le => "pcm_s16le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestOutputFormatEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_alaw" => GenerationRequestOutputFormatEncoding.PcmAlaw,
                "pcm_f32le" => GenerationRequestOutputFormatEncoding.PcmF32le,
                "pcm_mulaw" => GenerationRequestOutputFormatEncoding.PcmMulaw,
                "pcm_s16le" => GenerationRequestOutputFormatEncoding.PcmS16le,
                _ => null,
            };
        }
    }
}