
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSWebSocketResponseVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        FlushDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSWebSocketResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSWebSocketResponseVariant2Type value)
        {
            return value switch
            {
                TTSWebSocketResponseVariant2Type.FlushDone => "flush_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSWebSocketResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "flush_done" => TTSWebSocketResponseVariant2Type.FlushDone,
                _ => null,
            };
        }
    }
}