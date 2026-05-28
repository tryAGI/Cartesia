
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Models that support realtime speech-to-text (manual finalize).<br/>
    /// This mode expects you to send the `finalize` command to trigger transcription.<br/>
    /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
    /// </summary>
    public enum STTManualFinalizeModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ink2,
        /// <summary>
        /// 
        /// </summary>
        InkWhisper,
        /// <summary>
        /// 
        /// </summary>
        InkWhisper20250604,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTManualFinalizeModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeModel value)
        {
            return value switch
            {
                STTManualFinalizeModel.Ink2 => "ink-2",
                STTManualFinalizeModel.InkWhisper => "ink-whisper",
                STTManualFinalizeModel.InkWhisper20250604 => "ink-whisper-2025-06-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-2" => STTManualFinalizeModel.Ink2,
                "ink-whisper" => STTManualFinalizeModel.InkWhisper,
                "ink-whisper-2025-06-04" => STTManualFinalizeModel.InkWhisper20250604,
                _ => null,
            };
        }
    }
}