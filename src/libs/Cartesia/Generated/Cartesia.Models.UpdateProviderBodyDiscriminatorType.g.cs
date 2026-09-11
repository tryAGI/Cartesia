
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProviderBodyDiscriminatorType
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
    public static class UpdateProviderBodyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProviderBodyDiscriminatorType value)
        {
            return value switch
            {
                UpdateProviderBodyDiscriminatorType.SipTrunk => "sip_trunk",
                UpdateProviderBodyDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProviderBodyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => UpdateProviderBodyDiscriminatorType.SipTrunk,
                "twilio" => UpdateProviderBodyDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}