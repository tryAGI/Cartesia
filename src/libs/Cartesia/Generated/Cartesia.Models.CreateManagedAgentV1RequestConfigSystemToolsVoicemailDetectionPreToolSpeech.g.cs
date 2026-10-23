
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech
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
    public static class CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech value)
        {
            return value switch
            {
                CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Auto => "auto",
                CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Force => "force",
                CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Auto,
                "force" => CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Force,
                "off" => CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}