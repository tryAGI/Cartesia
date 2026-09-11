
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Who can use the resource. `private` means only the owner can use the resource. `public` means everyone can use the resource.
    /// </summary>
    public enum VoiceAccess
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
    public static class VoiceAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceAccess value)
        {
            return value switch
            {
                VoiceAccess.Private => "private",
                VoiceAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceAccess? ToEnum(string value)
        {
            return value switch
            {
                "private" => VoiceAccess.Private,
                "public" => VoiceAccess.Public,
                _ => null,
            };
        }
    }
}