
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Status of the voice. Only active voices are returned in [List Voices](/api-reference/voices/list) by default unless `include_archived=true`.
    /// </summary>
    public enum VoiceStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceStatus value)
        {
            return value switch
            {
                VoiceStatus.Active => "active",
                VoiceStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => VoiceStatus.Active,
                "archived" => VoiceStatus.Archived,
                _ => null,
            };
        }
    }
}