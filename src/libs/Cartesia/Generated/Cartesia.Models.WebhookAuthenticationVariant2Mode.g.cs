
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationVariant2Mode
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationVariant2ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationVariant2Mode value)
        {
            return value switch
            {
                WebhookAuthenticationVariant2Mode.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationVariant2Mode? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => WebhookAuthenticationVariant2Mode.Bearer,
                _ => null,
            };
        }
    }
}