
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Models that support realtime speech-to-text with external VAD (voice activity detection).<br/>
    /// This mode expects you to send the `finalize` command to trigger transcription.<br/>
    /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
    /// </summary>
    public enum STTRealtimeExternalVADModel
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
    public static class STTRealtimeExternalVADModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTRealtimeExternalVADModel value)
        {
            return value switch
            {
                STTRealtimeExternalVADModel.Ink2 => "ink-2",
                STTRealtimeExternalVADModel.InkWhisper => "ink-whisper",
                STTRealtimeExternalVADModel.InkWhisper20250604 => "ink-whisper-2025-06-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTRealtimeExternalVADModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-2" => STTRealtimeExternalVADModel.Ink2,
                "ink-whisper" => STTRealtimeExternalVADModel.InkWhisper,
                "ink-whisper-2025-06-04" => STTRealtimeExternalVADModel.InkWhisper20250604,
                _ => null,
            };
        }
    }
}