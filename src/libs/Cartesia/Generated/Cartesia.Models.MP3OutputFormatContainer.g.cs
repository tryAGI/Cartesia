
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum MP3OutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MP3OutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MP3OutputFormatContainer value)
        {
            return value switch
            {
                MP3OutputFormatContainer.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MP3OutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => MP3OutputFormatContainer.Mp3,
                _ => null,
            };
        }
    }
}