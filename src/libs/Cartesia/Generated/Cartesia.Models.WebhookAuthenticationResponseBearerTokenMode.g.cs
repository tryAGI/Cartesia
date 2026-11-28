
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationResponseBearerTokenMode
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationResponseBearerTokenModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationResponseBearerTokenMode value)
        {
            return value switch
            {
                WebhookAuthenticationResponseBearerTokenMode.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationResponseBearerTokenMode? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => WebhookAuthenticationResponseBearerTokenMode.Bearer,
                _ => null,
            };
        }
    }
}