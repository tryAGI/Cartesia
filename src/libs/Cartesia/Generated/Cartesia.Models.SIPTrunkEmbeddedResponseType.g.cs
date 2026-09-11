
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Always `"sip_trunk"`.
    /// </summary>
    public enum SIPTrunkEmbeddedResponseType
    {
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPTrunkEmbeddedResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkEmbeddedResponseType value)
        {
            return value switch
            {
                SIPTrunkEmbeddedResponseType.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkEmbeddedResponseType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => SIPTrunkEmbeddedResponseType.SipTrunk,
                _ => null,
            };
        }
    }
}