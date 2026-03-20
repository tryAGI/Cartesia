
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormatContainer value)
        {
            return value switch
            {
                OutputFormatContainer.Raw => "raw",
                OutputFormatContainer.Wav => "wav",
                OutputFormatContainer.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => OutputFormatContainer.Raw,
                "wav" => OutputFormatContainer.Wav,
                "mp3" => OutputFormatContainer.Mp3,
                _ => null,
            };
        }
    }
}