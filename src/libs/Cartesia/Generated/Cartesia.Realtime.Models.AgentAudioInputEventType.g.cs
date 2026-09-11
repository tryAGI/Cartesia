
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentAudioInputEventType
    {
        /// <summary>
        ///
        /// </summary>
        AudioInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentAudioInputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAudioInputEventType value)
        {
            return value switch
            {
                AgentAudioInputEventType.AudioInput => "audio_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAudioInputEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio_input" => AgentAudioInputEventType.AudioInput,
                _ => null,
            };
        }
    }
}