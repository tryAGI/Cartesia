
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Must be `"sip_trunk"`.
    /// </summary>
    public enum UpdateSIPTrunkProviderBodyType
    {
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSIPTrunkProviderBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSIPTrunkProviderBodyType value)
        {
            return value switch
            {
                UpdateSIPTrunkProviderBodyType.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSIPTrunkProviderBodyType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => UpdateSIPTrunkProviderBodyType.SipTrunk,
                _ => null,
            };
        }
    }
}