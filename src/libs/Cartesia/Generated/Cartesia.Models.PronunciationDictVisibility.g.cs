
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
    /// </summary>
    public enum PronunciationDictVisibility
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictVisibility value)
        {
            return value switch
            {
                PronunciationDictVisibility.All => "all",
                PronunciationDictVisibility.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => PronunciationDictVisibility.All,
                "owner" => PronunciationDictVisibility.Owner,
                _ => null,
            };
        }
    }
}