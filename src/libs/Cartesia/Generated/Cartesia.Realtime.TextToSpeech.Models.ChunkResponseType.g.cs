
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Response type identifier
    /// </summary>
    public enum ChunkResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Chunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkResponseType value)
        {
            return value switch
            {
                ChunkResponseType.Chunk => "chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkResponseType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => ChunkResponseType.Chunk,
                _ => null,
            };
        }
    }
}