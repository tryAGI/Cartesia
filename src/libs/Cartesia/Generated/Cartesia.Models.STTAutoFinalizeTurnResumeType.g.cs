
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTAutoFinalizeTurnResumeType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnResume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeTurnResumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeTurnResumeType value)
        {
            return value switch
            {
                STTAutoFinalizeTurnResumeType.TurnResume => "turn.resume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeTurnResumeType? ToEnum(string value)
        {
            return value switch
            {
                "turn.resume" => STTAutoFinalizeTurnResumeType.TurnResume,
                _ => null,
            };
        }
    }
}