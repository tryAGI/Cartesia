
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Runs a function in the connected client application.
    /// </summary>
    public enum ManagedClientToolV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedClientToolV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedClientToolV1Type value)
        {
            return value switch
            {
                ManagedClientToolV1Type.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedClientToolV1Type? ToEnum(string value)
        {
            return value switch
            {
                "client" => ManagedClientToolV1Type.Client,
                _ => null,
            };
        }
    }
}