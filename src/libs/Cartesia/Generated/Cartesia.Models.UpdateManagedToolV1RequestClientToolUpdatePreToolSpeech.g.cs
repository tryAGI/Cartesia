
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
    /// </summary>
    public enum UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech
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
    public static class UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech.Auto => "auto",
                UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech.Force => "force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech.Auto,
                "force" => UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech.Force,
                _ => null,
            };
        }
    }
}