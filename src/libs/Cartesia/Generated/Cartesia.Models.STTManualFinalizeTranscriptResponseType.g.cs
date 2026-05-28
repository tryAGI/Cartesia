
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTManualFinalizeTranscriptResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTManualFinalizeTranscriptResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeTranscriptResponseType value)
        {
            return value switch
            {
                STTManualFinalizeTranscriptResponseType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeTranscriptResponseType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => STTManualFinalizeTranscriptResponseType.Transcript,
                _ => null,
            };
        }
    }
}