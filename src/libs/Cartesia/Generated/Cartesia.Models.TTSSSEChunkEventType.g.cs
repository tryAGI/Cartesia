
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum TTSSSEChunkEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Chunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSSSEChunkEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSSSEChunkEventType value)
        {
            return value switch
            {
                TTSSSEChunkEventType.Chunk => "chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSSSEChunkEventType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TTSSSEChunkEventType.Chunk,
                _ => null,
            };
        }
    }
}