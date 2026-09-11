
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// ID of the model to use for transcription.<br/>
    /// See [Models](/build-with-cartesia/stt/latest) for details.<br/>
    /// Example: ink-2
    /// </summary>
    public enum SpeechToTextModel
    {
        /// <summary>
        ///
        /// </summary>
        Ink2,
        /// <summary>
        ///
        /// </summary>
        InkPreview,
        /// <summary>
        ///
        /// </summary>
        InkWhisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechToTextModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextModel value)
        {
            return value switch
            {
                SpeechToTextModel.Ink2 => "ink-2",
                SpeechToTextModel.InkPreview => "ink-preview",
                SpeechToTextModel.InkWhisper => "ink-whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-2" => SpeechToTextModel.Ink2,
                "ink-preview" => SpeechToTextModel.InkPreview,
                "ink-whisper" => SpeechToTextModel.InkWhisper,
                _ => null,
            };
        }
    }
}