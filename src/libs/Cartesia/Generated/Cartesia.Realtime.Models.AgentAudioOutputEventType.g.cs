
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentAudioOutputEventType
    {
        /// <summary>
        ///
        /// </summary>
        AudioOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentAudioOutputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAudioOutputEventType value)
        {
            return value switch
            {
                AgentAudioOutputEventType.AudioOutput => "audio_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAudioOutputEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio_output" => AgentAudioOutputEventType.AudioOutput,
                _ => null,
            };
        }
    }
}