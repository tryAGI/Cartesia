
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum GenerationDoneResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationDoneResponseType value)
        {
            return value switch
            {
                GenerationDoneResponseType.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "done" => GenerationDoneResponseType.Done,
                _ => null,
            };
        }
    }
}