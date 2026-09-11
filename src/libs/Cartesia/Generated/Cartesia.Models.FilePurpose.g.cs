
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// What a file is used for.
    /// </summary>
    public enum FilePurpose
    {
        /// <summary>
        ///
        /// </summary>
        AgentBackgroundSound,
        /// <summary>
        ///
        /// </summary>
        FineTune,
        /// <summary>
        ///
        /// </summary>
        TtsGeneration,
        /// <summary>
        ///
        /// </summary>
        VoiceClone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.AgentBackgroundSound => "agent_background_sound",
                FilePurpose.FineTune => "fine_tune",
                FilePurpose.TtsGeneration => "tts_generation",
                FilePurpose.VoiceClone => "voice-clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "agent_background_sound" => FilePurpose.AgentBackgroundSound,
                "fine_tune" => FilePurpose.FineTune,
                "tts_generation" => FilePurpose.TtsGeneration,
                "voice-clone" => FilePurpose.VoiceClone,
                _ => null,
            };
        }
    }
}