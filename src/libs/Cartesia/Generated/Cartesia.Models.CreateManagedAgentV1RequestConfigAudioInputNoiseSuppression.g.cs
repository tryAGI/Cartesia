
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Noise suppression applied to incoming audio. Use `off` to disable it, `auto` for the default level, or `max` for stronger suppression.
    /// </summary>
    public enum CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateManagedAgentV1RequestConfigAudioInputNoiseSuppressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression value)
        {
            return value switch
            {
                CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Auto => "auto",
                CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Max => "max",
                CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Auto,
                "max" => CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Max,
                "off" => CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Off,
                _ => null,
            };
        }
    }
}