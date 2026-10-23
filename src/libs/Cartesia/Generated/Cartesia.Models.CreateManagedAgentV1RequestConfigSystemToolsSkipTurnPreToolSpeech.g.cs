
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech
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
    public static class CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech value)
        {
            return value switch
            {
                CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Auto => "auto",
                CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Force => "force",
                CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Auto,
                "force" => CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Force,
                "off" => CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}