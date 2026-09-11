
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum STTTranscriptResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTranscriptResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTranscriptResponseType value)
        {
            return value switch
            {
                STTTranscriptResponseType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTranscriptResponseType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => STTTranscriptResponseType.Transcript,
                _ => null,
            };
        }
    }
}