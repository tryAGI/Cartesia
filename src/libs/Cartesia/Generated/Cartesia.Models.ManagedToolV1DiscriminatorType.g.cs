
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ManagedToolV1DiscriminatorType
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
    public static class ManagedToolV1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedToolV1DiscriminatorType value)
        {
            return value switch
            {
                ManagedToolV1DiscriminatorType.Client => "client",
                ManagedToolV1DiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedToolV1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ManagedToolV1DiscriminatorType.Client,
                "webhook" => ManagedToolV1DiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}