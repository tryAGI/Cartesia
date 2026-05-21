
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSWebSocketResponseVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSWebSocketResponseVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSWebSocketResponseVariant4Type value)
        {
            return value switch
            {
                TTSWebSocketResponseVariant4Type.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSWebSocketResponseVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "timestamps" => TTSWebSocketResponseVariant4Type.Timestamps,
                _ => null,
            };
        }
    }
}