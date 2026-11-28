
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationBasicAuthMode
    {
        /// <summary>
        ///
        /// </summary>
        BasicAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationBasicAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationBasicAuthMode value)
        {
            return value switch
            {
                WebhookAuthenticationBasicAuthMode.BasicAuth => "basic_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationBasicAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "basic_auth" => WebhookAuthenticationBasicAuthMode.BasicAuth,
                _ => null,
            };
        }
    }
}