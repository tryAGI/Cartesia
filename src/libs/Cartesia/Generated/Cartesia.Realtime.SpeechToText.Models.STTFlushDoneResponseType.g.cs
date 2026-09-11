
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum STTFlushDoneResponseType
    {
        /// <summary>
        ///
        /// </summary>
        FlushDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTFlushDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTFlushDoneResponseType value)
        {
            return value switch
            {
                STTFlushDoneResponseType.FlushDone => "flush_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTFlushDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "flush_done" => STTFlushDoneResponseType.FlushDone,
                _ => null,
            };
        }
    }
}