
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
    /// </summary>
    public enum CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech
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
    public static class CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech value)
        {
            return value switch
            {
                CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Auto => "auto",
                CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Force => "force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Auto,
                "force" => CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech.Force,
                _ => null,
            };
        }
    }
}