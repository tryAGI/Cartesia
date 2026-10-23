
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentSystemToolsV1
    {
        /// <summary>
        /// Configuration for ending the call. Set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::Cartesia.ManagedAgentSystemToolsV1EndCall? EndCall { get; set; }

        /// <summary>
        /// Configuration for sending DTMF tones. Set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_dtmf")]
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? SendDtmf { get; set; }

        /// <summary>
        /// Configuration for skipping the agent's turn. Set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::Cartesia.ManagedAgentSystemToolsV1SkipTurn? SkipTurn { get; set; }

        /// <summary>
        /// Configuration for detecting voicemail. Set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_detection")]
        public global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetection? VoicemailDetection { get; set; }

        /// <summary>
        /// Configuration for transferring the call. Set to `null` to disable this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? TransferToNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1" /> class.
        /// </summary>
        /// <param name="endCall">
        /// Configuration for ending the call. Set to `null` to disable this tool.
        /// </param>
        /// <param name="sendDtmf">
        /// Configuration for sending DTMF tones. Set to `null` to disable this tool.
        /// </param>
        /// <param name="skipTurn">
        /// Configuration for skipping the agent's turn. Set to `null` to disable this tool.
        /// </param>
        /// <param name="voicemailDetection">
        /// Configuration for detecting voicemail. Set to `null` to disable this tool.
        /// </param>
        /// <param name="transferToNumber">
        /// Configuration for transferring the call. Set to `null` to disable this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentSystemToolsV1(
            global::Cartesia.ManagedAgentSystemToolsV1EndCall? endCall,
            global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? sendDtmf,
            global::Cartesia.ManagedAgentSystemToolsV1SkipTurn? skipTurn,
            global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetection? voicemailDetection,
            global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? transferToNumber)
        {
            this.EndCall = endCall;
            this.SendDtmf = sendDtmf;
            this.SkipTurn = skipTurn;
            this.VoicemailDetection = voicemailDetection;
            this.TransferToNumber = transferToNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1" /> class.
        /// </summary>
        public ManagedAgentSystemToolsV1()
        {
        }

    }
}