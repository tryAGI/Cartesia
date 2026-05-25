
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum STTExternalVADWebSocketResponseDiscriminatorType
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
    public static class STTExternalVADWebSocketResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTExternalVADWebSocketResponseDiscriminatorType value)
        {
            return value switch
            {
                STTExternalVADWebSocketResponseDiscriminatorType.Done => "done",
                STTExternalVADWebSocketResponseDiscriminatorType.Error => "error",
                STTExternalVADWebSocketResponseDiscriminatorType.FlushDone => "flush_done",
                STTExternalVADWebSocketResponseDiscriminatorType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTExternalVADWebSocketResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "done" => STTExternalVADWebSocketResponseDiscriminatorType.Done,
                "error" => STTExternalVADWebSocketResponseDiscriminatorType.Error,
                "flush_done" => STTExternalVADWebSocketResponseDiscriminatorType.FlushDone,
                "transcript" => STTExternalVADWebSocketResponseDiscriminatorType.Transcript,
                _ => null,
            };
        }
    }
}