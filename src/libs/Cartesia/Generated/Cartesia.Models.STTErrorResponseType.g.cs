
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTErrorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTErrorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTErrorResponseType value)
        {
            return value switch
            {
                STTErrorResponseType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTErrorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "error" => STTErrorResponseType.Error,
                _ => null,
            };
        }
    }
}