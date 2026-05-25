
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum STTTurnsWebSocketResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        TurnEagerEnd,
        /// <summary>
        /// 
        /// </summary>
        TurnEnd,
        /// <summary>
        /// 
        /// </summary>
        TurnResume,
        /// <summary>
        /// 
        /// </summary>
        TurnStart,
        /// <summary>
        /// 
        /// </summary>
        TurnUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsWebSocketResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsWebSocketResponseDiscriminatorType value)
        {
            return value switch
            {
                STTTurnsWebSocketResponseDiscriminatorType.Connected => "connected",
                STTTurnsWebSocketResponseDiscriminatorType.Error => "error",
                STTTurnsWebSocketResponseDiscriminatorType.TurnEagerEnd => "turn.eager_end",
                STTTurnsWebSocketResponseDiscriminatorType.TurnEnd => "turn.end",
                STTTurnsWebSocketResponseDiscriminatorType.TurnResume => "turn.resume",
                STTTurnsWebSocketResponseDiscriminatorType.TurnStart => "turn.start",
                STTTurnsWebSocketResponseDiscriminatorType.TurnUpdate => "turn.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsWebSocketResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "connected" => STTTurnsWebSocketResponseDiscriminatorType.Connected,
                "error" => STTTurnsWebSocketResponseDiscriminatorType.Error,
                "turn.eager_end" => STTTurnsWebSocketResponseDiscriminatorType.TurnEagerEnd,
                "turn.end" => STTTurnsWebSocketResponseDiscriminatorType.TurnEnd,
                "turn.resume" => STTTurnsWebSocketResponseDiscriminatorType.TurnResume,
                "turn.start" => STTTurnsWebSocketResponseDiscriminatorType.TurnStart,
                "turn.update" => STTTurnsWebSocketResponseDiscriminatorType.TurnUpdate,
                _ => null,
            };
        }
    }
}