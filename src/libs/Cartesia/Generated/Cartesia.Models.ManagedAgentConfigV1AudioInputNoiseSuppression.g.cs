
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Noise suppression applied to incoming audio. Use `off` to disable it, `auto` for the default level, or `max` for stronger suppression.
    /// </summary>
    public enum ManagedAgentConfigV1AudioInputNoiseSuppression
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
    public static class ManagedAgentConfigV1AudioInputNoiseSuppressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentConfigV1AudioInputNoiseSuppression value)
        {
            return value switch
            {
                ManagedAgentConfigV1AudioInputNoiseSuppression.Auto => "auto",
                ManagedAgentConfigV1AudioInputNoiseSuppression.Max => "max",
                ManagedAgentConfigV1AudioInputNoiseSuppression.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentConfigV1AudioInputNoiseSuppression? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedAgentConfigV1AudioInputNoiseSuppression.Auto,
                "max" => ManagedAgentConfigV1AudioInputNoiseSuppression.Max,
                "off" => ManagedAgentConfigV1AudioInputNoiseSuppression.Off,
                _ => null,
            };
        }
    }
}