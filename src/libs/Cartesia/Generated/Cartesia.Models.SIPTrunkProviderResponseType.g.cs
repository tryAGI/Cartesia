
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Always `"sip_trunk"`.
    /// </summary>
    public enum SIPTrunkProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPTrunkProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkProviderResponseType value)
        {
            return value switch
            {
                SIPTrunkProviderResponseType.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => SIPTrunkProviderResponseType.SipTrunk,
                _ => null,
            };
        }
    }
}