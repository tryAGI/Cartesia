
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Models that support batch speech-to-text transcription.<br/>
    /// See [the docs](https://docs.cartesia.ai/api-reference/stt/transcribe#body-model) for all options.
    /// </summary>
    public enum STTBatchModel
    {
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
    public static class STTBatchModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTBatchModel value)
        {
            return value switch
            {
                STTBatchModel.InkWhisper => "ink-whisper",
                STTBatchModel.InkWhisper20250604 => "ink-whisper-2025-06-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTBatchModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-whisper" => STTBatchModel.InkWhisper,
                "ink-whisper-2025-06-04" => STTBatchModel.InkWhisper20250604,
                _ => null,
            };
        }
    }
}