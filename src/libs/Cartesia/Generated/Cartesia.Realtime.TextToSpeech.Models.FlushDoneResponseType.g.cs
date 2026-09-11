
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum FlushDoneResponseType
    {
        /// <summary>
        ///
        /// </summary>
        FlushDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlushDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlushDoneResponseType value)
        {
            return value switch
            {
                FlushDoneResponseType.FlushDone => "flush_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlushDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "flush_done" => FlushDoneResponseType.FlushDone,
                _ => null,
            };
        }
    }
}