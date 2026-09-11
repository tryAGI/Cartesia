
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentAudioOutputClearEventType
    {
        /// <summary>
        ///
        /// </summary>
        AudioOutputClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentAudioOutputClearEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAudioOutputClearEventType value)
        {
            return value switch
            {
                AgentAudioOutputClearEventType.AudioOutputClear => "audio_output_clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAudioOutputClearEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio_output_clear" => AgentAudioOutputClearEventType.AudioOutputClear,
                _ => null,
            };
        }
    }
}