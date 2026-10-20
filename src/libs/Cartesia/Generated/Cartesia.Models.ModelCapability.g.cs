
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Which speech API family the model belongs to.
    /// </summary>
    public enum ModelCapability
    {
        /// <summary>
        ///
        /// </summary>
        Stt,
        /// <summary>
        ///
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelCapabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelCapability value)
        {
            return value switch
            {
                ModelCapability.Stt => "stt",
                ModelCapability.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelCapability? ToEnum(string value)
        {
            return value switch
            {
                "stt" => ModelCapability.Stt,
                "tts" => ModelCapability.Tts,
                _ => null,
            };
        }
    }
}