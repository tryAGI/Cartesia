
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
    /// </summary>
    public enum UpdateVoiceRequestAccessEnum
    {
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateVoiceRequestAccessEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVoiceRequestAccessEnum value)
        {
            return value switch
            {
                UpdateVoiceRequestAccessEnum.Private => "private",
                UpdateVoiceRequestAccessEnum.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVoiceRequestAccessEnum? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateVoiceRequestAccessEnum.Private,
                "public" => UpdateVoiceRequestAccessEnum.Public,
                _ => null,
            };
        }
    }
}