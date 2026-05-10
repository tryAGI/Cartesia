
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSWebSocketResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Chunk,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        FlushDone,
        /// <summary>
        /// 
        /// </summary>
        PhonemeTimestamps,
        /// <summary>
        /// 
        /// </summary>
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSWebSocketResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSWebSocketResponseDiscriminatorType value)
        {
            return value switch
            {
                TTSWebSocketResponseDiscriminatorType.Chunk => "chunk",
                TTSWebSocketResponseDiscriminatorType.Done => "done",
                TTSWebSocketResponseDiscriminatorType.Error => "error",
                TTSWebSocketResponseDiscriminatorType.FlushDone => "flush_done",
                TTSWebSocketResponseDiscriminatorType.PhonemeTimestamps => "phoneme_timestamps",
                TTSWebSocketResponseDiscriminatorType.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSWebSocketResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TTSWebSocketResponseDiscriminatorType.Chunk,
                "done" => TTSWebSocketResponseDiscriminatorType.Done,
                "error" => TTSWebSocketResponseDiscriminatorType.Error,
                "flush_done" => TTSWebSocketResponseDiscriminatorType.FlushDone,
                "phoneme_timestamps" => TTSWebSocketResponseDiscriminatorType.PhonemeTimestamps,
                "timestamps" => TTSWebSocketResponseDiscriminatorType.Timestamps,
                _ => null,
            };
        }
    }
}