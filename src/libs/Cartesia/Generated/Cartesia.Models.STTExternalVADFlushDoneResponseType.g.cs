
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTExternalVADFlushDoneResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        FlushDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTExternalVADFlushDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTExternalVADFlushDoneResponseType value)
        {
            return value switch
            {
                STTExternalVADFlushDoneResponseType.FlushDone => "flush_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTExternalVADFlushDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "flush_done" => STTExternalVADFlushDoneResponseType.FlushDone,
                _ => null,
            };
        }
    }
}