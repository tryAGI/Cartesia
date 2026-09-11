
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// ID of the model to use for transcription. Must be in the `ink-whisper` family of models.<br/>
    /// Example: ink-whisper
    /// </summary>
    public enum SttTranscribeRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        InkWhisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttTranscribeRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttTranscribeRequestModel value)
        {
            return value switch
            {
                SttTranscribeRequestModel.InkWhisper => "ink-whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttTranscribeRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-whisper" => SttTranscribeRequestModel.InkWhisper,
                _ => null,
            };
        }
    }
}