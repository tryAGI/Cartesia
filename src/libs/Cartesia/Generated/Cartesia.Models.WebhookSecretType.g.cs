
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookSecretType
    {
        /// <summary>
        ///
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretType value)
        {
            return value switch
            {
                WebhookSecretType.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretType? ToEnum(string value)
        {
            return value switch
            {
                "secret" => WebhookSecretType.Secret,
                _ => null,
            };
        }
    }
}