
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The destination type.
    /// </summary>
    public enum ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentSystemToolsV1TransferToNumberTransferDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType value)
        {
            return value switch
            {
                ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType.Phone,
                _ => null,
            };
        }
    }
}