
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum STTDoneResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTDoneResponseType value)
        {
            return value switch
            {
                STTDoneResponseType.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "done" => STTDoneResponseType.Done,
                _ => null,
            };
        }
    }
}