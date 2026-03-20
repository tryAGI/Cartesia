
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Use `generation_config.speed` for sonic-3.<br/>
    /// Speed setting for the model. Defaults to `normal`.<br/>
    /// This feature is experimental and may not work for all voices.<br/>
    /// Influences the speed of the generated speech. Faster speeds may reduce hallucination rate.<br/>
    /// Default Value: normal
    /// </summary>
    public enum ModelSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Slow,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelSpeed value)
        {
            return value switch
            {
                ModelSpeed.Slow => "slow",
                ModelSpeed.Normal => "normal",
                ModelSpeed.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelSpeed? ToEnum(string value)
        {
            return value switch
            {
                "slow" => ModelSpeed.Slow,
                "normal" => ModelSpeed.Normal,
                "fast" => ModelSpeed.Fast,
                _ => null,
            };
        }
    }
}