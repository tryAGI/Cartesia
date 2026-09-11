
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
    /// </summary>
    public enum CreatePronunciationDictRequestAccessEnum
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
    public static class CreatePronunciationDictRequestAccessEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePronunciationDictRequestAccessEnum value)
        {
            return value switch
            {
                CreatePronunciationDictRequestAccessEnum.Private => "private",
                CreatePronunciationDictRequestAccessEnum.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePronunciationDictRequestAccessEnum? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreatePronunciationDictRequestAccessEnum.Private,
                "public" => CreatePronunciationDictRequestAccessEnum.Public,
                _ => null,
            };
        }
    }
}