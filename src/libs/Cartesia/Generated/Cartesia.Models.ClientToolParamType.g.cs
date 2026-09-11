
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The parameter's JSON type.
    /// </summary>
    public enum ClientToolParamType
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
    public static class ClientToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolParamType value)
        {
            return value switch
            {
                ClientToolParamType.Array => "array",
                ClientToolParamType.Boolean => "boolean",
                ClientToolParamType.Integer => "integer",
                ClientToolParamType.Number => "number",
                ClientToolParamType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ClientToolParamType.Array,
                "boolean" => ClientToolParamType.Boolean,
                "integer" => ClientToolParamType.Integer,
                "number" => ClientToolParamType.Number,
                "string" => ClientToolParamType.String,
                _ => null,
            };
        }
    }
}