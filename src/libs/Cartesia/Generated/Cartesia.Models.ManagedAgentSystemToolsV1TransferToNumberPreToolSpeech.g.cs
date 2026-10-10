
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech
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
    public static class ManagedAgentSystemToolsV1TransferToNumberPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech value)
        {
            return value switch
            {
                ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech.Auto => "auto",
                ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech.Force => "force",
                ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech.Auto,
                "force" => ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech.Force,
                "off" => ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}