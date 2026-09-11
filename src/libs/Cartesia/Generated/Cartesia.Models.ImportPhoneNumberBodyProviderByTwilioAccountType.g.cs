
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ImportPhoneNumberBodyProviderByTwilioAccountType
    {
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportPhoneNumberBodyProviderByTwilioAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportPhoneNumberBodyProviderByTwilioAccountType value)
        {
            return value switch
            {
                ImportPhoneNumberBodyProviderByTwilioAccountType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportPhoneNumberBodyProviderByTwilioAccountType? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => ImportPhoneNumberBodyProviderByTwilioAccountType.Twilio,
                _ => null,
            };
        }
    }
}