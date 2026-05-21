
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSWebSocketResponseVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Chunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSWebSocketResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSWebSocketResponseVariant1Type value)
        {
            return value switch
            {
                TTSWebSocketResponseVariant1Type.Chunk => "chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSWebSocketResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TTSWebSocketResponseVariant1Type.Chunk,
                _ => null,
            };
        }
    }
}