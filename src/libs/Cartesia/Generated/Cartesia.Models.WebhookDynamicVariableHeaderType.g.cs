
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookDynamicVariableHeaderType
    {
        /// <summary>
        ///
        /// </summary>
        DynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDynamicVariableHeaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDynamicVariableHeaderType value)
        {
            return value switch
            {
                WebhookDynamicVariableHeaderType.DynamicVariable => "dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDynamicVariableHeaderType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic_variable" => WebhookDynamicVariableHeaderType.DynamicVariable,
                _ => null,
            };
        }
    }
}