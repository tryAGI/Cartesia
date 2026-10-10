
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech
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
    public static class UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Auto => "auto",
                UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Force => "force",
                UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Auto,
                "force" => UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Force,
                "off" => UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Off,
                _ => null,
            };
        }
    }
}