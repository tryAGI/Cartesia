
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Runs an HTTP request from Cartesia's servers.
    /// </summary>
    public enum ManagedWebhookToolDefinitionV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedWebhookToolDefinitionV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookToolDefinitionV1Type value)
        {
            return value switch
            {
                ManagedWebhookToolDefinitionV1Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookToolDefinitionV1Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ManagedWebhookToolDefinitionV1Type.Webhook,
                _ => null,
            };
        }
    }
}