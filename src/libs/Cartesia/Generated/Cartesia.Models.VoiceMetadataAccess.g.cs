
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
    /// </summary>
    public enum VoiceMetadataAccess
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
    public static class VoiceMetadataAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMetadataAccess value)
        {
            return value switch
            {
                VoiceMetadataAccess.Private => "private",
                VoiceMetadataAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMetadataAccess? ToEnum(string value)
        {
            return value switch
            {
                "private" => VoiceMetadataAccess.Private,
                "public" => VoiceMetadataAccess.Public,
                _ => null,
            };
        }
    }
}