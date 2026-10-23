
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum ManagedAgentSystemToolsV1SkipTurnPreToolSpeech
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
    public static class ManagedAgentSystemToolsV1SkipTurnPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentSystemToolsV1SkipTurnPreToolSpeech value)
        {
            return value switch
            {
                ManagedAgentSystemToolsV1SkipTurnPreToolSpeech.Auto => "auto",
                ManagedAgentSystemToolsV1SkipTurnPreToolSpeech.Force => "force",
                ManagedAgentSystemToolsV1SkipTurnPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentSystemToolsV1SkipTurnPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedAgentSystemToolsV1SkipTurnPreToolSpeech.Auto,
                "force" => ManagedAgentSystemToolsV1SkipTurnPreToolSpeech.Force,
                "off" => ManagedAgentSystemToolsV1SkipTurnPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}