
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Noise suppression applied to incoming audio. Use `off` to disable it, `auto` for the default level, or `max` for stronger suppression.
    /// </summary>
    public enum UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression
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
    public static class UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression value)
        {
            return value switch
            {
                UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Auto => "auto",
                UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Max => "max",
                UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? ToEnum(string value)
        {
            return value switch
            {
                "auto" => UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Auto,
                "max" => UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Max,
                "off" => UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression.Off,
                _ => null,
            };
        }
    }
}