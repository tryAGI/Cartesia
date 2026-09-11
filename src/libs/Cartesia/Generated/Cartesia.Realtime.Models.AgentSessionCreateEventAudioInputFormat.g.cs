
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Format of the audio your client sends. Agent audio is returned in the same format. Required, because a sample rate that mismatches your capture format fails silently as garbled audio.
    /// </summary>
    public enum AgentSessionCreateEventAudioInputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mulaw8000,
        /// <summary>
        ///
        /// </summary>
        Pcm16000,
        /// <summary>
        ///
        /// </summary>
        Pcm24000,
        /// <summary>
        ///
        /// </summary>
        Pcm44100,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionCreateEventAudioInputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionCreateEventAudioInputFormat value)
        {
            return value switch
            {
                AgentSessionCreateEventAudioInputFormat.Mulaw8000 => "mulaw_8000",
                AgentSessionCreateEventAudioInputFormat.Pcm16000 => "pcm_16000",
                AgentSessionCreateEventAudioInputFormat.Pcm24000 => "pcm_24000",
                AgentSessionCreateEventAudioInputFormat.Pcm44100 => "pcm_44100",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionCreateEventAudioInputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mulaw_8000" => AgentSessionCreateEventAudioInputFormat.Mulaw8000,
                "pcm_16000" => AgentSessionCreateEventAudioInputFormat.Pcm16000,
                "pcm_24000" => AgentSessionCreateEventAudioInputFormat.Pcm24000,
                "pcm_44100" => AgentSessionCreateEventAudioInputFormat.Pcm44100,
                _ => null,
            };
        }
    }
}