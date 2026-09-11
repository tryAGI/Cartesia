
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProviderBodyDiscriminatorType
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
    public static class CreateProviderBodyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProviderBodyDiscriminatorType value)
        {
            return value switch
            {
                CreateProviderBodyDiscriminatorType.SipTrunk => "sip_trunk",
                CreateProviderBodyDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProviderBodyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => CreateProviderBodyDiscriminatorType.SipTrunk,
                "twilio" => CreateProviderBodyDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}