
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTExternalVADTranscriptResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTExternalVADTranscriptResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTExternalVADTranscriptResponseType value)
        {
            return value switch
            {
                STTExternalVADTranscriptResponseType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTExternalVADTranscriptResponseType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => STTExternalVADTranscriptResponseType.Transcript,
                _ => null,
            };
        }
    }
}