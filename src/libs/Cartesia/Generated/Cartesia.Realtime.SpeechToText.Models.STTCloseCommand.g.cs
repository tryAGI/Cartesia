
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// The value `close` as a text message
    /// </summary>
    public enum STTCloseCommand
    {
        /// <summary>
        ///
        /// </summary>
        Close,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTCloseCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTCloseCommand value)
        {
            return value switch
            {
                STTCloseCommand.Close => "close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTCloseCommand? ToEnum(string value)
        {
            return value switch
            {
                "close" => STTCloseCommand.Close,
                _ => null,
            };
        }
    }
}