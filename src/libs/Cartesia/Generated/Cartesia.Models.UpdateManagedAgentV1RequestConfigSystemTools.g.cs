
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Built-in tools available to the agent.
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigSystemTools
    {
        /// <summary>
        /// Configuration for ending the call. Omit to keep the current setting or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? EndCall { get; set; }

        /// <summary>
        /// Configuration for sending DTMF tones. Omit to keep the current setting or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_dtmf")]
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? SendDtmf { get; set; }

        /// <summary>
        /// Configuration for transferring the call. Omit to keep the current setting or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? TransferToNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigSystemTools" /> class.
        /// </summary>
        /// <param name="endCall">
        /// Configuration for ending the call. Omit to keep the current setting or set to `null` to disable this tool.
        /// </param>
        /// <param name="sendDtmf">
        /// Configuration for sending DTMF tones. Omit to keep the current setting or set to `null` to disable this tool.
        /// </param>
        /// <param name="transferToNumber">
        /// Configuration for transferring the call. Omit to keep the current setting or set to `null` to disable this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1RequestConfigSystemTools(
            global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? endCall,
            global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? sendDtmf,
            global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? transferToNumber)
        {
            this.EndCall = endCall;
            this.SendDtmf = sendDtmf;
            this.TransferToNumber = transferToNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigSystemTools" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigSystemTools()
        {
        }

    }
}