
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum STTAutoFinalizeConnectedType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTAutoFinalizeConnectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTAutoFinalizeConnectedType value)
        {
            return value switch
            {
                STTAutoFinalizeConnectedType.Connected => "connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTAutoFinalizeConnectedType? ToEnum(string value)
        {
            return value switch
            {
                "connected" => STTAutoFinalizeConnectedType.Connected,
                _ => null,
            };
        }
    }
}