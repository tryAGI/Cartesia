
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSWebSocketResponseVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSWebSocketResponseVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSWebSocketResponseVariant5Type value)
        {
            return value switch
            {
                TTSWebSocketResponseVariant5Type.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSWebSocketResponseVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "error" => TTSWebSocketResponseVariant5Type.Error,
                _ => null,
            };
        }
    }
}