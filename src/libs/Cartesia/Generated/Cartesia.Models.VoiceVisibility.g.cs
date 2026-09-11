
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
    /// </summary>
    public enum VoiceVisibility
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
    public static class VoiceVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceVisibility value)
        {
            return value switch
            {
                VoiceVisibility.All => "all",
                VoiceVisibility.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => VoiceVisibility.All,
                "owner" => VoiceVisibility.Owner,
                _ => null,
            };
        }
    }
}