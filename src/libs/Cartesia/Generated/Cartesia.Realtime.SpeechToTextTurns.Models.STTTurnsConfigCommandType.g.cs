
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Command type. Send this as a JSON encoded WebSocket text message to update model settings.
    /// </summary>
    public enum STTTurnsConfigCommandType
    {
        /// <summary>
        ///
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTurnsConfigCommandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTurnsConfigCommandType value)
        {
            return value switch
            {
                STTTurnsConfigCommandType.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTurnsConfigCommandType? ToEnum(string value)
        {
            return value switch
            {
                "config" => STTTurnsConfigCommandType.Config,
                _ => null,
            };
        }
    }
}