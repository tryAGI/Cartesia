
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
    /// </summary>
    public enum ManagedWebhookToolDefinitionV1PreToolSpeech
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
    public static class ManagedWebhookToolDefinitionV1PreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookToolDefinitionV1PreToolSpeech value)
        {
            return value switch
            {
                ManagedWebhookToolDefinitionV1PreToolSpeech.Auto => "auto",
                ManagedWebhookToolDefinitionV1PreToolSpeech.Force => "force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookToolDefinitionV1PreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedWebhookToolDefinitionV1PreToolSpeech.Auto,
                "force" => ManagedWebhookToolDefinitionV1PreToolSpeech.Force,
                _ => null,
            };
        }
    }
}