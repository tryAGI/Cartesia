
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech
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
    public static class UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Auto => "auto",
                UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Force => "force",
                UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Auto,
                "force" => UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Force,
                "off" => UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}