
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    ///
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
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
        Transcript,
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
                ServerEventDiscriminatorType.Done => "done",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.FlushDone => "flush_done",
                ServerEventDiscriminatorType.Transcript => "transcript",
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
                "done" => ServerEventDiscriminatorType.Done,
                "error" => ServerEventDiscriminatorType.Error,
                "flush_done" => ServerEventDiscriminatorType.FlushDone,
                "transcript" => ServerEventDiscriminatorType.Transcript,
                _ => null,
            };
        }
    }
}