
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Runs an HTTP request from Cartesia's servers.
    /// </summary>
    public enum ManagedWebhookToolV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedWebhookToolV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookToolV1Type value)
        {
            return value switch
            {
                ManagedWebhookToolV1Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookToolV1Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ManagedWebhookToolV1Type.Webhook,
                _ => null,
            };
        }
    }
}