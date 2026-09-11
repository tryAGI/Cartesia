
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    public enum ServerEventDiscriminatorType
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
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Chunk => "chunk",
                ServerEventDiscriminatorType.Done => "done",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.FlushDone => "flush_done",
                ServerEventDiscriminatorType.PhonemeTimestamps => "phoneme_timestamps",
                ServerEventDiscriminatorType.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => ServerEventDiscriminatorType.Chunk,
                "done" => ServerEventDiscriminatorType.Done,
                "error" => ServerEventDiscriminatorType.Error,
                "flush_done" => ServerEventDiscriminatorType.FlushDone,
                "phoneme_timestamps" => ServerEventDiscriminatorType.PhonemeTimestamps,
                "timestamps" => ServerEventDiscriminatorType.Timestamps,
                _ => null,
            };
        }
    }
}