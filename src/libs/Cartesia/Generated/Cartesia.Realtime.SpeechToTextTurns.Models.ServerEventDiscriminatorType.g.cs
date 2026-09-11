
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    ///
    /// </summary>
    public enum ServerEventDiscriminatorType
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
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Connected => "connected",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.TurnEagerEnd => "turn.eager_end",
                ServerEventDiscriminatorType.TurnEnd => "turn.end",
                ServerEventDiscriminatorType.TurnResume => "turn.resume",
                ServerEventDiscriminatorType.TurnStart => "turn.start",
                ServerEventDiscriminatorType.TurnUpdate => "turn.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "connected" => ServerEventDiscriminatorType.Connected,
                "error" => ServerEventDiscriminatorType.Error,
                "turn.eager_end" => ServerEventDiscriminatorType.TurnEagerEnd,
                "turn.end" => ServerEventDiscriminatorType.TurnEnd,
                "turn.resume" => ServerEventDiscriminatorType.TurnResume,
                "turn.start" => ServerEventDiscriminatorType.TurnStart,
                "turn.update" => ServerEventDiscriminatorType.TurnUpdate,
                _ => null,
            };
        }
    }
}