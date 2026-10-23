
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech
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
    public static class UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Auto => "auto",
                UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Force => "force",
                UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Auto,
                "force" => UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Force,
                "off" => UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}