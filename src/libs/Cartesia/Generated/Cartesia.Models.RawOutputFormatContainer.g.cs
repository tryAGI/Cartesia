
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum RawOutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RawOutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RawOutputFormatContainer value)
        {
            return value switch
            {
                RawOutputFormatContainer.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RawOutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => RawOutputFormatContainer.Raw,
                _ => null,
            };
        }
    }
}