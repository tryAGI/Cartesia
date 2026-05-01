
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSSSEEventDiscriminatorType
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
        PhonemeTimestamps,
        /// <summary>
        /// 
        /// </summary>
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSSSEEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSSSEEventDiscriminatorType value)
        {
            return value switch
            {
                TTSSSEEventDiscriminatorType.Chunk => "chunk",
                TTSSSEEventDiscriminatorType.Done => "done",
                TTSSSEEventDiscriminatorType.Error => "error",
                TTSSSEEventDiscriminatorType.PhonemeTimestamps => "phoneme_timestamps",
                TTSSSEEventDiscriminatorType.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSSSEEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TTSSSEEventDiscriminatorType.Chunk,
                "done" => TTSSSEEventDiscriminatorType.Done,
                "error" => TTSSSEEventDiscriminatorType.Error,
                "phoneme_timestamps" => TTSSSEEventDiscriminatorType.PhonemeTimestamps,
                "timestamps" => TTSSSEEventDiscriminatorType.Timestamps,
                _ => null,
            };
        }
    }
}