
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum STTManualFinalizeWebSocketResponseDiscriminatorType
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
    public static class STTManualFinalizeWebSocketResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeWebSocketResponseDiscriminatorType value)
        {
            return value switch
            {
                STTManualFinalizeWebSocketResponseDiscriminatorType.Done => "done",
                STTManualFinalizeWebSocketResponseDiscriminatorType.Error => "error",
                STTManualFinalizeWebSocketResponseDiscriminatorType.FlushDone => "flush_done",
                STTManualFinalizeWebSocketResponseDiscriminatorType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeWebSocketResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "done" => STTManualFinalizeWebSocketResponseDiscriminatorType.Done,
                "error" => STTManualFinalizeWebSocketResponseDiscriminatorType.Error,
                "flush_done" => STTManualFinalizeWebSocketResponseDiscriminatorType.FlushDone,
                "transcript" => STTManualFinalizeWebSocketResponseDiscriminatorType.Transcript,
                _ => null,
            };
        }
    }
}