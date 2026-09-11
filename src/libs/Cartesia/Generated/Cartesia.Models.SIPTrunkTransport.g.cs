
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Transport for outbound SIP signaling.
    /// </summary>
    public enum SIPTrunkTransport
    {
        /// <summary>
        ///
        /// </summary>
        Tcp,
        /// <summary>
        ///
        /// </summary>
        Tls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPTrunkTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkTransport value)
        {
            return value switch
            {
                SIPTrunkTransport.Tcp => "tcp",
                SIPTrunkTransport.Tls => "tls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkTransport? ToEnum(string value)
        {
            return value switch
            {
                "tcp" => SIPTrunkTransport.Tcp,
                "tls" => SIPTrunkTransport.Tls,
                _ => null,
            };
        }
    }
}