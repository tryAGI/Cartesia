
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTManualFinalizeFlushDoneResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        FlushDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTManualFinalizeFlushDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeFlushDoneResponseType value)
        {
            return value switch
            {
                STTManualFinalizeFlushDoneResponseType.FlushDone => "flush_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeFlushDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "flush_done" => STTManualFinalizeFlushDoneResponseType.FlushDone,
                _ => null,
            };
        }
    }
}