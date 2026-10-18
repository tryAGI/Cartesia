
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ManagedAgentFallbackStrategyV1ExplicitType
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentFallbackStrategyV1ExplicitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentFallbackStrategyV1ExplicitType value)
        {
            return value switch
            {
                ManagedAgentFallbackStrategyV1ExplicitType.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentFallbackStrategyV1ExplicitType? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => ManagedAgentFallbackStrategyV1ExplicitType.Explicit,
                _ => null,
            };
        }
    }
}