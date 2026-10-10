
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech
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
    public static class CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech value)
        {
            return value switch
            {
                CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Auto => "auto",
                CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Force => "force",
                CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Auto,
                "force" => CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Force,
                "off" => CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}