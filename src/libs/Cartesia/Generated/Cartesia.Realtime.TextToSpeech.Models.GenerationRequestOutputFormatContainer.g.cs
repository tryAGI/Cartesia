
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Audio container format<br/>
    /// Default Value: raw
    /// </summary>
    public enum GenerationRequestOutputFormatContainer
    {
        /// <summary>
        ///
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestOutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestOutputFormatContainer value)
        {
            return value switch
            {
                GenerationRequestOutputFormatContainer.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestOutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => GenerationRequestOutputFormatContainer.Raw,
                _ => null,
            };
        }
    }
}