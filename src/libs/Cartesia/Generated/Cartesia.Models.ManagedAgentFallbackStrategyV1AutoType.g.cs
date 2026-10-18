
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ManagedAgentFallbackStrategyV1AutoType
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentFallbackStrategyV1AutoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentFallbackStrategyV1AutoType value)
        {
            return value switch
            {
                ManagedAgentFallbackStrategyV1AutoType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentFallbackStrategyV1AutoType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedAgentFallbackStrategyV1AutoType.Auto,
                _ => null,
            };
        }
    }
}