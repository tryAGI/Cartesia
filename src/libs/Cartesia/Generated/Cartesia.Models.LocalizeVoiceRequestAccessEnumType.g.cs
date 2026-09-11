
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
    /// </summary>
    public enum LocalizeVoiceRequestAccessEnumType
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
    public static class LocalizeVoiceRequestAccessEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeVoiceRequestAccessEnumType value)
        {
            return value switch
            {
                LocalizeVoiceRequestAccessEnumType.Private => "private",
                LocalizeVoiceRequestAccessEnumType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeVoiceRequestAccessEnumType? ToEnum(string value)
        {
            return value switch
            {
                "private" => LocalizeVoiceRequestAccessEnumType.Private,
                "public" => LocalizeVoiceRequestAccessEnumType.Public,
                _ => null,
            };
        }
    }
}