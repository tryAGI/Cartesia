
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// STT transport path (`batch` file upload or `stream` websocket).
    /// </summary>
    public enum STTMode
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Stream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTMode value)
        {
            return value switch
            {
                STTMode.Batch => "batch",
                STTMode.Stream => "stream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTMode? ToEnum(string value)
        {
            return value switch
            {
                "batch" => STTMode.Batch,
                "stream" => STTMode.Stream,
                _ => null,
            };
        }
    }
}