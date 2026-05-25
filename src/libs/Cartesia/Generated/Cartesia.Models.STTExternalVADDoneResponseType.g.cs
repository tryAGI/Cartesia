
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTExternalVADDoneResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTExternalVADDoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTExternalVADDoneResponseType value)
        {
            return value switch
            {
                STTExternalVADDoneResponseType.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTExternalVADDoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "done" => STTExternalVADDoneResponseType.Done,
                _ => null,
            };
        }
    }
}