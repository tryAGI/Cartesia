
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum ManagedWebhookToolV1PreToolSpeech
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
    public static class ManagedWebhookToolV1PreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookToolV1PreToolSpeech value)
        {
            return value switch
            {
                ManagedWebhookToolV1PreToolSpeech.Auto => "auto",
                ManagedWebhookToolV1PreToolSpeech.Force => "force",
                ManagedWebhookToolV1PreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookToolV1PreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedWebhookToolV1PreToolSpeech.Auto,
                "force" => ManagedWebhookToolV1PreToolSpeech.Force,
                "off" => ManagedWebhookToolV1PreToolSpeech.Off,
                _ => null,
            };
        }
    }
}