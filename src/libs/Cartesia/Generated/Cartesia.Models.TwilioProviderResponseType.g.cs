
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Always `"twilio"`.
    /// </summary>
    public enum TwilioProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioProviderResponseType value)
        {
            return value switch
            {
                TwilioProviderResponseType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => TwilioProviderResponseType.Twilio,
                _ => null,
            };
        }
    }
}