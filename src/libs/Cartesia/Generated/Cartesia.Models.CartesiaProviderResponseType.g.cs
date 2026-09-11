
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Always `"cartesia"`.
    /// </summary>
    public enum CartesiaProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaProviderResponseType value)
        {
            return value switch
            {
                CartesiaProviderResponseType.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => CartesiaProviderResponseType.Cartesia,
                _ => null,
            };
        }
    }
}