
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ProvidersListType
    {
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvidersListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersListType value)
        {
            return value switch
            {
                ProvidersListType.SipTrunk => "sip_trunk",
                ProvidersListType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersListType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => ProvidersListType.SipTrunk,
                "twilio" => ProvidersListType.Twilio,
                _ => null,
            };
        }
    }
}