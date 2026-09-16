
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Where to transfer the call.
    /// </summary>
    public sealed partial class ManagedAgentSystemToolsV1TransferToNumberTransferDestination
    {
        /// <summary>
        /// E.164 phone number or a single dynamic variable, such as `{{transfer_number}}`. Must resolve to a valid E.164 number when the tool runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// The destination type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationTypeJsonConverter))]
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1TransferToNumberTransferDestination" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// E.164 phone number or a single dynamic variable, such as `{{transfer_number}}`. Must resolve to a valid E.164 number when the tool runs.
        /// </param>
        /// <param name="type">
        /// The destination type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentSystemToolsV1TransferToNumberTransferDestination(
            string phoneNumber,
            global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType type)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1TransferToNumberTransferDestination" /> class.
        /// </summary>
        public ManagedAgentSystemToolsV1TransferToNumberTransferDestination()
        {
        }

    }
}