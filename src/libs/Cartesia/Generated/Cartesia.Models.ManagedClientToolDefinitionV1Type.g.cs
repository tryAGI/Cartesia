
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Runs a function in the connected client application.
    /// </summary>
    public enum ManagedClientToolDefinitionV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedClientToolDefinitionV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedClientToolDefinitionV1Type value)
        {
            return value switch
            {
                ManagedClientToolDefinitionV1Type.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedClientToolDefinitionV1Type? ToEnum(string value)
        {
            return value switch
            {
                "client" => ManagedClientToolDefinitionV1Type.Client,
                _ => null,
            };
        }
    }
}