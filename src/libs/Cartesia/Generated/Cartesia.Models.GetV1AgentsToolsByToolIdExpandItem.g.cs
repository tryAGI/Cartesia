
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum GetV1AgentsToolsByToolIdExpandItem
    {
        /// <summary>
        ///
        /// </summary>
        Agents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetV1AgentsToolsByToolIdExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV1AgentsToolsByToolIdExpandItem value)
        {
            return value switch
            {
                GetV1AgentsToolsByToolIdExpandItem.Agents => "agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV1AgentsToolsByToolIdExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "agents" => GetV1AgentsToolsByToolIdExpandItem.Agents,
                _ => null,
            };
        }
    }
}