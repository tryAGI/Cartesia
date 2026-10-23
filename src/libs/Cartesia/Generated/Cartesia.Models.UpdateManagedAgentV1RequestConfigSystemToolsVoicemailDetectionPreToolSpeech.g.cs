
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech
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
    public static class UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Auto => "auto",
                UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Force => "force",
                UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Auto,
                "force" => UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Force,
                "off" => UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}