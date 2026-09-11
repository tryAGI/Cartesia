
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ManagedToolDefinitionV1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedToolDefinitionV1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedToolDefinitionV1DiscriminatorType value)
        {
            return value switch
            {
                ManagedToolDefinitionV1DiscriminatorType.Client => "client",
                ManagedToolDefinitionV1DiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedToolDefinitionV1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ManagedToolDefinitionV1DiscriminatorType.Client,
                "webhook" => ManagedToolDefinitionV1DiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}