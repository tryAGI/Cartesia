
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Must be `"twilio"`.
    /// </summary>
    public enum UpdateTwilioProviderBodyType
    {
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTwilioProviderBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTwilioProviderBodyType value)
        {
            return value switch
            {
                UpdateTwilioProviderBodyType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTwilioProviderBodyType? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => UpdateTwilioProviderBodyType.Twilio,
                _ => null,
            };
        }
    }
}