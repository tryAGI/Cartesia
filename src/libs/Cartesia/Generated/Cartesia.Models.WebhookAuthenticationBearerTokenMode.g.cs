
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookAuthenticationBearerTokenMode
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthenticationBearerTokenModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthenticationBearerTokenMode value)
        {
            return value switch
            {
                WebhookAuthenticationBearerTokenMode.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthenticationBearerTokenMode? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => WebhookAuthenticationBearerTokenMode.Bearer,
                _ => null,
            };
        }
    }
}