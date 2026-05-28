
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum STTAutoFinalizeWebSocketResponseDiscriminatorType
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
    public static class STTAutoFinalizeWebSocketResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeWebSocketResponseDiscriminatorType value)
        {
            return value switch
            {
                STTAutoFinalizeWebSocketResponseDiscriminatorType.Connected => "connected",
                STTAutoFinalizeWebSocketResponseDiscriminatorType.Error => "error",
                STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnEagerEnd => "turn.eager_end",
                STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnEnd => "turn.end",
                STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnResume => "turn.resume",
                STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnStart => "turn.start",
                STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnUpdate => "turn.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeWebSocketResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "connected" => STTAutoFinalizeWebSocketResponseDiscriminatorType.Connected,
                "error" => STTAutoFinalizeWebSocketResponseDiscriminatorType.Error,
                "turn.eager_end" => STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnEagerEnd,
                "turn.end" => STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnEnd,
                "turn.resume" => STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnResume,
                "turn.start" => STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnStart,
                "turn.update" => STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnUpdate,
                _ => null,
            };
        }
    }
}