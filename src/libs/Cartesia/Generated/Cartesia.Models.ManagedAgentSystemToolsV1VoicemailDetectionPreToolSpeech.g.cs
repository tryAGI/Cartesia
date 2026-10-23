
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Force,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech value)
        {
            return value switch
            {
                ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech.Auto => "auto",
                ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech.Force => "force",
                ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech.Auto,
                "force" => ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech.Force,
                "off" => ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}