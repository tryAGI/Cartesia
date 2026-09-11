
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationResponseVariant2Mode
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationResponseVariant2ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationResponseVariant2Mode value)
        {
            return value switch
            {
                WebhookAuthenticationResponseVariant2Mode.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationResponseVariant2Mode? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => WebhookAuthenticationResponseVariant2Mode.Bearer,
                _ => null,
            };
        }
    }
}