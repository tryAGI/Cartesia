
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// The value `finalize` as a text message
    /// </summary>
    public enum STTFinalizeCommand
    {
        /// <summary>
        ///
        /// </summary>
        Finalize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTFinalizeCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTFinalizeCommand value)
        {
            return value switch
            {
                STTFinalizeCommand.Finalize => "finalize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTFinalizeCommand? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => STTFinalizeCommand.Finalize,
                _ => null,
            };
        }
    }
}