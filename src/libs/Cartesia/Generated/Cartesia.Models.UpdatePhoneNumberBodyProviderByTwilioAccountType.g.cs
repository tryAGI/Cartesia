
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdatePhoneNumberBodyProviderByTwilioAccountType
    {
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePhoneNumberBodyProviderByTwilioAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePhoneNumberBodyProviderByTwilioAccountType value)
        {
            return value switch
            {
                UpdatePhoneNumberBodyProviderByTwilioAccountType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePhoneNumberBodyProviderByTwilioAccountType? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => UpdatePhoneNumberBodyProviderByTwilioAccountType.Twilio,
                _ => null,
            };
        }
    }
}