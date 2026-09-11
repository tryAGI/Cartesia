
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookBodyParamType
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
        Object,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBodyParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBodyParamType value)
        {
            return value switch
            {
                WebhookBodyParamType.Array => "array",
                WebhookBodyParamType.Boolean => "boolean",
                WebhookBodyParamType.Integer => "integer",
                WebhookBodyParamType.Number => "number",
                WebhookBodyParamType.Object => "object",
                WebhookBodyParamType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBodyParamType? ToEnum(string value)
        {
            return value switch
            {
                "array" => WebhookBodyParamType.Array,
                "boolean" => WebhookBodyParamType.Boolean,
                "integer" => WebhookBodyParamType.Integer,
                "number" => WebhookBodyParamType.Number,
                "object" => WebhookBodyParamType.Object,
                "string" => WebhookBodyParamType.String,
                _ => null,
            };
        }
    }
}