
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// When the resource is returned by the list endpoint. `owner` means the resource appears for the owner only. `all` means the resource appears for all users.
    /// </summary>
    public enum VoiceMetadataVisibility
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
    public static class VoiceMetadataVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMetadataVisibility value)
        {
            return value switch
            {
                VoiceMetadataVisibility.All => "all",
                VoiceMetadataVisibility.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMetadataVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => VoiceMetadataVisibility.All,
                "owner" => VoiceMetadataVisibility.Owner,
                _ => null,
            };
        }
    }
}