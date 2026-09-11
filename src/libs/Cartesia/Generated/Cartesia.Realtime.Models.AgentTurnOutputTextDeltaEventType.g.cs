
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentTurnOutputTextDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        TurnOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTurnOutputTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnOutputTextDeltaEventType value)
        {
            return value switch
            {
                AgentTurnOutputTextDeltaEventType.TurnOutputTextDelta => "turn_output_text_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnOutputTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "turn_output_text_delta" => AgentTurnOutputTextDeltaEventType.TurnOutputTextDelta,
                _ => null,
            };
        }
    }
}