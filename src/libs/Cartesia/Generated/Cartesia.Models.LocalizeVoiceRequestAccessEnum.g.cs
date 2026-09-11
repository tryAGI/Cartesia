
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
    /// </summary>
    public enum LocalizeVoiceRequestAccessEnum
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
    public static class LocalizeVoiceRequestAccessEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeVoiceRequestAccessEnum value)
        {
            return value switch
            {
                LocalizeVoiceRequestAccessEnum.Private => "private",
                LocalizeVoiceRequestAccessEnum.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeVoiceRequestAccessEnum? ToEnum(string value)
        {
            return value switch
            {
                "private" => LocalizeVoiceRequestAccessEnum.Private,
                "public" => LocalizeVoiceRequestAccessEnum.Public,
                _ => null,
            };
        }
    }
}