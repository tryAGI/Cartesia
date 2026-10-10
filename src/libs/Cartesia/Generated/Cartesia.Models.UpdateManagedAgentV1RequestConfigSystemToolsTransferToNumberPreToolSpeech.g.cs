
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech
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
    public static class UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech.Auto => "auto",
                UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech.Force => "force",
                UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech.Auto,
                "force" => UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech.Force,
                "off" => UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}