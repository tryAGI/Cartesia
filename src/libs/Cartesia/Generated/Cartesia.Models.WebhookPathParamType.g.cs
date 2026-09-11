
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPathParamType
    {
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPathParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPathParamType value)
        {
            return value switch
            {
                WebhookPathParamType.Integer => "integer",
                WebhookPathParamType.Number => "number",
                WebhookPathParamType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPathParamType? ToEnum(string value)
        {
            return value switch
            {
                "integer" => WebhookPathParamType.Integer,
                "number" => WebhookPathParamType.Number,
                "string" => WebhookPathParamType.String,
                _ => null,
            };
        }
    }
}