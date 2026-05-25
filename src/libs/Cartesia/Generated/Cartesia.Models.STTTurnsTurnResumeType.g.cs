
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTTurnsTurnResumeType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnResume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsTurnResumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsTurnResumeType value)
        {
            return value switch
            {
                STTTurnsTurnResumeType.TurnResume => "turn.resume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsTurnResumeType? ToEnum(string value)
        {
            return value switch
            {
                "turn.resume" => STTTurnsTurnResumeType.TurnResume,
                _ => null,
            };
        }
    }
}