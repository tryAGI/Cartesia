
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Return only tools of this type.
    /// </summary>
    public enum GetV1AgentsToolsType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetV1AgentsToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV1AgentsToolsType value)
        {
            return value switch
            {
                GetV1AgentsToolsType.Client => "client",
                GetV1AgentsToolsType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV1AgentsToolsType? ToEnum(string value)
        {
            return value switch
            {
                "client" => GetV1AgentsToolsType.Client,
                "webhook" => GetV1AgentsToolsType.Webhook,
                _ => null,
            };
        }
    }
}