
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Base model for a fine-tune. See [the docs](https://docs.cartesia.ai/api-reference/fine-tunes/create#body-model-id) for all options.
    /// </summary>
    public enum FineTuneBaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        Sonic320260112,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneBaseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneBaseModel value)
        {
            return value switch
            {
                FineTuneBaseModel.Sonic320260112 => "sonic-3-2026-01-12",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneBaseModel? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3-2026-01-12" => FineTuneBaseModel.Sonic320260112,
                _ => null,
            };
        }
    }
}