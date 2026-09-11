
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Default Value: 2026-08-14<br/>
    /// Example: 2026-08-14
    /// </summary>
    public enum GetV1AgentsByAgentIdVersionsCartesiaVersion
    {
        /// <summary>
        ///
        /// </summary>
        x20260814,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetV1AgentsByAgentIdVersionsCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV1AgentsByAgentIdVersionsCartesiaVersion value)
        {
            return value switch
            {
                GetV1AgentsByAgentIdVersionsCartesiaVersion.x20260814 => "2026-08-14",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV1AgentsByAgentIdVersionsCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-08-14" => GetV1AgentsByAgentIdVersionsCartesiaVersion.x20260814,
                _ => null,
            };
        }
    }
}