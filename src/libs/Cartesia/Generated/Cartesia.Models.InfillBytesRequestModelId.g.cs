
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The ID of the model to use for generating audio
    /// </summary>
    public enum InfillBytesRequestModelId
    {
        /// <summary>
        ///
        /// </summary>
        Sonic3,
        /// <summary>
        ///
        /// </summary>
        Sonic320260112,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InfillBytesRequestModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InfillBytesRequestModelId value)
        {
            return value switch
            {
                InfillBytesRequestModelId.Sonic3 => "sonic-3",
                InfillBytesRequestModelId.Sonic320260112 => "sonic-3-2026-01-12",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InfillBytesRequestModelId? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3" => InfillBytesRequestModelId.Sonic3,
                "sonic-3-2026-01-12" => InfillBytesRequestModelId.Sonic320260112,
                _ => null,
            };
        }
    }
}