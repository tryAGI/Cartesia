
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
    /// </summary>
    public enum UpdateVoiceRequestAccessEnumType
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
    public static class UpdateVoiceRequestAccessEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVoiceRequestAccessEnumType value)
        {
            return value switch
            {
                UpdateVoiceRequestAccessEnumType.Private => "private",
                UpdateVoiceRequestAccessEnumType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVoiceRequestAccessEnumType? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateVoiceRequestAccessEnumType.Private,
                "public" => UpdateVoiceRequestAccessEnumType.Public,
                _ => null,
            };
        }
    }
}