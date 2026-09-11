
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Base model ID to fine-tune from<br/>
    /// Example: sonic-3.6-2026-08-27
    /// </summary>
    public enum CreateFineTuneRequestModelId
    {
        /// <summary>
        ///
        /// </summary>
        Sonic3620260827,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFineTuneRequestModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFineTuneRequestModelId value)
        {
            return value switch
            {
                CreateFineTuneRequestModelId.Sonic3620260827 => "sonic-3.6-2026-08-27",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTuneRequestModelId? ToEnum(string value)
        {
            return value switch
            {
                "sonic-3.6-2026-08-27" => CreateFineTuneRequestModelId.Sonic3620260827,
                _ => null,
            };
        }
    }
}