
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Models that support realtime speech-to-text with turn-detection.<br/>
    /// This mode detects when the user is speaking and emits turn events.<br/>
    /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
    /// </summary>
    public enum STTRealtimeTurnDetectingModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ink2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTRealtimeTurnDetectingModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTRealtimeTurnDetectingModel value)
        {
            return value switch
            {
                STTRealtimeTurnDetectingModel.Ink2 => "ink-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTRealtimeTurnDetectingModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-2" => STTRealtimeTurnDetectingModel.Ink2,
                _ => null,
            };
        }
    }
}