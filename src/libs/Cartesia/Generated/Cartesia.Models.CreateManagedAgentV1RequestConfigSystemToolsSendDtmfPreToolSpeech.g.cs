
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
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
                _ => null,
            };
        }
    }
}