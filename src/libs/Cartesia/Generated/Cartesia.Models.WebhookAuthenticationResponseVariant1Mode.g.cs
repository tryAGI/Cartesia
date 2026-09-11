
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationResponseVariant1Mode
    {
        /// <summary>
        ///
        /// </summary>
        BasicAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationResponseVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationResponseVariant1Mode value)
        {
            return value switch
            {
                WebhookAuthenticationResponseVariant1Mode.BasicAuth => "basic_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationResponseVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "basic_auth" => WebhookAuthenticationResponseVariant1Mode.BasicAuth,
                _ => null,
            };
        }
    }
}