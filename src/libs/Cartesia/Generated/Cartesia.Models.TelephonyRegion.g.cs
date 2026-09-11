
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The Twilio region the phone number and API key are configured for. `us1` (US), `ie1` (Ireland), `au1` (Australia). Default is `us1`.<br/>
    /// Default Value: us1
    /// </summary>
    public enum TelephonyRegion
    {
        /// <summary>
        ///
        /// </summary>
        Au1,
        /// <summary>
        ///
        /// </summary>
        Ie1,
        /// <summary>
        ///
        /// </summary>
        Us1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelephonyRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelephonyRegion value)
        {
            return value switch
            {
                TelephonyRegion.Au1 => "au1",
                TelephonyRegion.Ie1 => "ie1",
                TelephonyRegion.Us1 => "us1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelephonyRegion? ToEnum(string value)
        {
            return value switch
            {
                "au1" => TelephonyRegion.Au1,
                "ie1" => TelephonyRegion.Ie1,
                "us1" => TelephonyRegion.Us1,
                _ => null,
            };
        }
    }
}