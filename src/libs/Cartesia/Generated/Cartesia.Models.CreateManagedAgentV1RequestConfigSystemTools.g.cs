
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Built-in tools available to the agent.
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigSystemTools
    {
        /// <summary>
        /// Configuration for ending the call. Omit or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCall? EndCall { get; set; }

        /// <summary>
        /// Configuration for sending DTMF tones. Omit or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_dtmf")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmf? SendDtmf { get; set; }

        /// <summary>
        /// Configuration for skipping the agent's turn. Omit or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSkipTurn? SkipTurn { get; set; }

        /// <summary>
        /// Configuration for detecting voicemail. Omit or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_detection")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetection? VoicemailDetection { get; set; }

        /// <summary>
        /// Configuration for transferring the call. Omit or set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber? TransferToNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemTools" /> class.
        /// </summary>
        /// <param name="endCall">
        /// Configuration for ending the call. Omit or set to `null` to disable this tool.
        /// </param>
        /// <param name="sendDtmf">
        /// Configuration for sending DTMF tones. Omit or set to `null` to disable this tool.
        /// </param>
        /// <param name="skipTurn">
        /// Configuration for skipping the agent's turn. Omit or set to `null` to disable this tool.
        /// </param>
        /// <param name="voicemailDetection">
        /// Configuration for detecting voicemail. Omit or set to `null` to disable this tool.
        /// </param>
        /// <param name="transferToNumber">
        /// Configuration for transferring the call. Omit or set to `null` to disable this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigSystemTools(
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCall? endCall,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmf? sendDtmf,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSkipTurn? skipTurn,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetection? voicemailDetection,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber? transferToNumber)
        {
            this.EndCall = endCall;
            this.SendDtmf = sendDtmf;
            this.SkipTurn = skipTurn;
            this.VoicemailDetection = voicemailDetection;
            this.TransferToNumber = transferToNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemTools" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigSystemTools()
        {
        }

    }
}