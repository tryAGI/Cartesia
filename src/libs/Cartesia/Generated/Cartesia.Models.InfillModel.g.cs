
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Infill models. See [the docs](https://docs.cartesia.ai/api-reference/infill/bytes#body-model-id) for all options.
    /// </summary>
    public enum InfillModel
    {
        /// <summary>
        /// 
        /// </summary>
        Sonic3,
        /// <summary>
        /// 
        /// </summary>
        Sonic320251027,
        /// <summary>
        /// 
        /// </summary>
        Sonic320260112,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InfillModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InfillModel value)
        {
            return value switch
            {
                InfillModel.Sonic3 => "sonic-3",
                InfillModel.Sonic320251027 => "sonic-3-2025-10-27",
                InfillModel.Sonic320260112 => "sonic-3-2026-01-12",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InfillModel? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3" => InfillModel.Sonic3,
                "sonic-3-2025-10-27" => InfillModel.Sonic320251027,
                "sonic-3-2026-01-12" => InfillModel.Sonic320260112,
                _ => null,
            };
        }
    }
}