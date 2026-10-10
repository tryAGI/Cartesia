
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum ManagedAgentSystemToolsV1SendDtmfPreToolSpeech
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
    public static class ManagedAgentSystemToolsV1SendDtmfPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentSystemToolsV1SendDtmfPreToolSpeech value)
        {
            return value switch
            {
                ManagedAgentSystemToolsV1SendDtmfPreToolSpeech.Auto => "auto",
                ManagedAgentSystemToolsV1SendDtmfPreToolSpeech.Force => "force",
                ManagedAgentSystemToolsV1SendDtmfPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedAgentSystemToolsV1SendDtmfPreToolSpeech.Auto,
                "force" => ManagedAgentSystemToolsV1SendDtmfPreToolSpeech.Force,
                "off" => ManagedAgentSystemToolsV1SendDtmfPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}