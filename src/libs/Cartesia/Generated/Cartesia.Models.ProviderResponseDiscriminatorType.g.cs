
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ProviderResponseDiscriminatorType
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
    public static class ProviderResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResponseDiscriminatorType value)
        {
            return value switch
            {
                ProviderResponseDiscriminatorType.Cartesia => "cartesia",
                ProviderResponseDiscriminatorType.SipTrunk => "sip_trunk",
                ProviderResponseDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => ProviderResponseDiscriminatorType.Cartesia,
                "sip_trunk" => ProviderResponseDiscriminatorType.SipTrunk,
                "twilio" => ProviderResponseDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}