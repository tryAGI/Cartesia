
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The type of connection used for the call.
    /// </summary>
    public enum TelephonyParamsConnectionType
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        Websocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelephonyParamsConnectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelephonyParamsConnectionType value)
        {
            return value switch
            {
                TelephonyParamsConnectionType.Phone => "phone",
                TelephonyParamsConnectionType.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelephonyParamsConnectionType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => TelephonyParamsConnectionType.Phone,
                "websocket" => TelephonyParamsConnectionType.Websocket,
                _ => null,
            };
        }
    }
}