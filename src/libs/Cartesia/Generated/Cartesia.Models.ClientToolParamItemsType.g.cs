
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ClientToolParamItemsType
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
    public static class ClientToolParamItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolParamItemsType value)
        {
            return value switch
            {
                ClientToolParamItemsType.Boolean => "boolean",
                ClientToolParamItemsType.Integer => "integer",
                ClientToolParamItemsType.Number => "number",
                ClientToolParamItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolParamItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => ClientToolParamItemsType.Boolean,
                "integer" => ClientToolParamItemsType.Integer,
                "number" => ClientToolParamItemsType.Number,
                "string" => ClientToolParamItemsType.String,
                _ => null,
            };
        }
    }
}