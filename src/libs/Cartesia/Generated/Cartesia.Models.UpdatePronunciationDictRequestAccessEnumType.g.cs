
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
    /// </summary>
    public enum UpdatePronunciationDictRequestAccessEnumType
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
    public static class UpdatePronunciationDictRequestAccessEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePronunciationDictRequestAccessEnumType value)
        {
            return value switch
            {
                UpdatePronunciationDictRequestAccessEnumType.Private => "private",
                UpdatePronunciationDictRequestAccessEnumType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePronunciationDictRequestAccessEnumType? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdatePronunciationDictRequestAccessEnumType.Private,
                "public" => UpdatePronunciationDictRequestAccessEnumType.Public,
                _ => null,
            };
        }
    }
}