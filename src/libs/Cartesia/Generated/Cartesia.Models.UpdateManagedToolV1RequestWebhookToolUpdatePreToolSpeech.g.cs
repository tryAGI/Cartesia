
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
    /// </summary>
    public enum UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech
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
    public static class UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech value)
        {
            return value switch
            {
                UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech.Auto => "auto",
                UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech.Force => "force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech.Auto,
                "force" => UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech.Force,
                _ => null,
            };
        }
    }
}