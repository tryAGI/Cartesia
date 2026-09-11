
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The ID of the model to use for the generation.<br/>
    /// See [Models](/build-with-cartesia/tts-models/latest) all options.<br/>
    /// Default Value: sonic-3.6<br/>
    /// Example: sonic-3.6
    /// </summary>
    public enum TTSModelID
    {
        /// <summary>
        ///
        /// </summary>
        Sonic3,
        /// <summary>
        ///
        /// </summary>
        Sonic35,
        /// <summary>
        ///
        /// </summary>
        Sonic36,
        /// <summary>
        ///
        /// </summary>
        Sonic3620260827,
        /// <summary>
        ///
        /// </summary>
        SonicLatest,
        /// <summary>
        ///
        /// </summary>
        SonicPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSModelIDExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSModelID value)
        {
            return value switch
            {
                TTSModelID.Sonic3 => "sonic-3",
                TTSModelID.Sonic35 => "sonic-3.5",
                TTSModelID.Sonic36 => "sonic-3.6",
                TTSModelID.Sonic3620260827 => "sonic-3.6-2026-08-27",
                TTSModelID.SonicLatest => "sonic-latest",
                TTSModelID.SonicPreview => "sonic-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSModelID? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3" => TTSModelID.Sonic3,
                "sonic-3.5" => TTSModelID.Sonic35,
                "sonic-3.6" => TTSModelID.Sonic36,
                "sonic-3.6-2026-08-27" => TTSModelID.Sonic3620260827,
                "sonic-latest" => TTSModelID.SonicLatest,
                "sonic-preview" => TTSModelID.SonicPreview,
                _ => null,
            };
        }
    }
}