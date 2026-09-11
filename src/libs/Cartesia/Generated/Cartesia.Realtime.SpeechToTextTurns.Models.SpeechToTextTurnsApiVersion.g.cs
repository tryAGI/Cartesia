
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// API version.<br/>
    /// Example: 2026-08-14
    /// </summary>
    public enum SpeechToTextTurnsApiVersion
    {
        /// <summary>
        ///
        /// </summary>
        x20260814,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechToTextTurnsApiVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextTurnsApiVersion value)
        {
            return value switch
            {
                SpeechToTextTurnsApiVersion.x20260814 => "2026-08-14",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextTurnsApiVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-08-14" => SpeechToTextTurnsApiVersion.x20260814,
                _ => null,
            };
        }
    }
}