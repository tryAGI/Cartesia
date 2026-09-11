
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationVariant1Mode
    {
        /// <summary>
        ///
        /// </summary>
        BasicAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationVariant1Mode value)
        {
            return value switch
            {
                WebhookAuthenticationVariant1Mode.BasicAuth => "basic_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "basic_auth" => WebhookAuthenticationVariant1Mode.BasicAuth,
                _ => null,
            };
        }
    }
}