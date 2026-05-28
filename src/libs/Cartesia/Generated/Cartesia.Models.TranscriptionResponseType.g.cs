
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The message type. Always `transcript` for a batch transcription response.
    /// </summary>
    public enum TranscriptionResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionResponseType value)
        {
            return value switch
            {
                TranscriptionResponseType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionResponseType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => TranscriptionResponseType.Transcript,
                _ => null,
            };
        }
    }
}