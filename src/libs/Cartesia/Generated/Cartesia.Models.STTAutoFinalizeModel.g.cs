
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Models that support realtime speech-to-text (auto finalize).<br/>
    /// This mode detects when the user is speaking and emits turn events.<br/>
    /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for all options.
    /// </summary>
    public enum STTAutoFinalizeModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ink2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeModel value)
        {
            return value switch
            {
                STTAutoFinalizeModel.Ink2 => "ink-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-2" => STTAutoFinalizeModel.Ink2,
                _ => null,
            };
        }
    }
}