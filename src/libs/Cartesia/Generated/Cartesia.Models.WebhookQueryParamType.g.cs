
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookQueryParamType
    {
        /// <summary>
        ///
        /// </summary>
        Array,
        /// <summary>
        ///
        /// </summary>
        Boolean,
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
    public static class WebhookQueryParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookQueryParamType value)
        {
            return value switch
            {
                WebhookQueryParamType.Array => "array",
                WebhookQueryParamType.Boolean => "boolean",
                WebhookQueryParamType.Integer => "integer",
                WebhookQueryParamType.Number => "number",
                WebhookQueryParamType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookQueryParamType? ToEnum(string value)
        {
            return value switch
            {
                "array" => WebhookQueryParamType.Array,
                "boolean" => WebhookQueryParamType.Boolean,
                "integer" => WebhookQueryParamType.Integer,
                "number" => WebhookQueryParamType.Number,
                "string" => WebhookQueryParamType.String,
                _ => null,
            };
        }
    }
}