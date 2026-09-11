
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookQueryParamItemsType
    {
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
    public static class WebhookQueryParamItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookQueryParamItemsType value)
        {
            return value switch
            {
                WebhookQueryParamItemsType.Boolean => "boolean",
                WebhookQueryParamItemsType.Integer => "integer",
                WebhookQueryParamItemsType.Number => "number",
                WebhookQueryParamItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookQueryParamItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => WebhookQueryParamItemsType.Boolean,
                "integer" => WebhookQueryParamItemsType.Integer,
                "number" => WebhookQueryParamItemsType.Number,
                "string" => WebhookQueryParamItemsType.String,
                _ => null,
            };
        }
    }
}