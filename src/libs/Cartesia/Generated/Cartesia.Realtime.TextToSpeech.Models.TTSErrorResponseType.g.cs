
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum TTSErrorResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSErrorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSErrorResponseType value)
        {
            return value switch
            {
                TTSErrorResponseType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSErrorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "error" => TTSErrorResponseType.Error,
                _ => null,
            };
        }
    }
}