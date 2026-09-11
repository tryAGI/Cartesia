
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The parameters schema type. Always `object`.
    /// </summary>
    public enum ManagedClientToolParametersV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedClientToolParametersV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedClientToolParametersV1Type value)
        {
            return value switch
            {
                ManagedClientToolParametersV1Type.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedClientToolParametersV1Type? ToEnum(string value)
        {
            return value switch
            {
                "object" => ManagedClientToolParametersV1Type.Object,
                _ => null,
            };
        }
    }
}