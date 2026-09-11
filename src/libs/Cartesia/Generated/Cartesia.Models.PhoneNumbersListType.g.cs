
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum PhoneNumbersListType
    {
        /// <summary>
        ///
        /// </summary>
        Cartesia,
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
    public static class PhoneNumbersListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumbersListType value)
        {
            return value switch
            {
                PhoneNumbersListType.Cartesia => "cartesia",
                PhoneNumbersListType.SipTrunk => "sip_trunk",
                PhoneNumbersListType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumbersListType? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => PhoneNumbersListType.Cartesia,
                "sip_trunk" => PhoneNumbersListType.SipTrunk,
                "twilio" => PhoneNumbersListType.Twilio,
                _ => null,
            };
        }
    }
}