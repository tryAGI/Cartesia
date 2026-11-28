
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationResponseBasicAuthMode
    {
        /// <summary>
        ///
        /// </summary>
        BasicAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationResponseBasicAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationResponseBasicAuthMode value)
        {
            return value switch
            {
                WebhookAuthenticationResponseBasicAuthMode.BasicAuth => "basic_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationResponseBasicAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "basic_auth" => WebhookAuthenticationResponseBasicAuthMode.BasicAuth,
                _ => null,
            };
        }
    }
}