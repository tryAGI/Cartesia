
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The destination type.
    /// </summary>
    public enum CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType value)
        {
            return value switch
            {
                CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType.Phone,
                _ => null,
            };
        }
    }
}