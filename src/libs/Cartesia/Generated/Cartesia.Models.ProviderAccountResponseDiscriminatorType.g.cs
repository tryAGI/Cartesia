
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ProviderAccountResponseDiscriminatorType
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
    public static class ProviderAccountResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderAccountResponseDiscriminatorType value)
        {
            return value switch
            {
                ProviderAccountResponseDiscriminatorType.SipTrunk => "sip_trunk",
                ProviderAccountResponseDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderAccountResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => ProviderAccountResponseDiscriminatorType.SipTrunk,
                "twilio" => ProviderAccountResponseDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}