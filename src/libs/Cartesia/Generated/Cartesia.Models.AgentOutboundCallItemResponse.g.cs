
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentOutboundCallItemResponse
    {
        /// <summary>
        /// Destination phone number for this outbound call, in E.164 format (e.g., `+14155559876`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// Agent call ID for tracking per-call information. This is absent when the request fails before Cartesia creates the call record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_call_id")]
        public string? AgentCallId { get; set; }

        /// <summary>
        /// Error for this destination when the provider could not start the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallItemResponse" /> class.
        /// </summary>
        /// <param name="number">
        /// Destination phone number for this outbound call, in E.164 format (e.g., `+14155559876`).
        /// </param>
        /// <param name="agentCallId">
        /// Agent call ID for tracking per-call information. This is absent when the request fails before Cartesia creates the call record.
        /// </param>
        /// <param name="error">
        /// Error for this destination when the provider could not start the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundCallItemResponse(
            string number,
            string? agentCallId,
            object? error)
        {
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.AgentCallId = agentCallId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundCallItemResponse" /> class.
        /// </summary>
        public AgentOutboundCallItemResponse()
        {
        }

    }
}