
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Must be `"twilio"`.
    /// </summary>
    public enum CreateTwilioProviderBodyType
    {
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTwilioProviderBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTwilioProviderBodyType value)
        {
            return value switch
            {
                CreateTwilioProviderBodyType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTwilioProviderBodyType? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => CreateTwilioProviderBodyType.Twilio,
                _ => null,
            };
        }
    }
}