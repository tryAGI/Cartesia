
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Command type. Send this as a JSON formatted WebSocket text message. `ink-preview` only.<br/>
    /// Changes take effect right away, including for words not returned yet. There's no reply on success. An invalid message returns an `error` event, changes nothing, and leaves the connection open.
    /// </summary>
    public enum STTConfigCommandType
    {
        /// <summary>
        ///
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTConfigCommandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTConfigCommandType value)
        {
            return value switch
            {
                STTConfigCommandType.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTConfigCommandType? ToEnum(string value)
        {
            return value switch
            {
                "config" => STTConfigCommandType.Config,
                _ => null,
            };
        }
    }
}