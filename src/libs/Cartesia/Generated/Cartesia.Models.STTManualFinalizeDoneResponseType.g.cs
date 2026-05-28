
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTManualFinalizeDoneResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTManualFinalizeDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeDoneResponseType value)
        {
            return value switch
            {
                STTManualFinalizeDoneResponseType.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "done" => STTManualFinalizeDoneResponseType.Done,
                _ => null,
            };
        }
    }
}