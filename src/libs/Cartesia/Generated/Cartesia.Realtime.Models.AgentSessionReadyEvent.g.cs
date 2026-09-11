
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Sent once after `session_create`, when the agent pipeline can accept audio. Reports the call record created for this session and the agent version the session is pinned to. Use `call_id` with the [calls API](/api-reference/agents/calls/get-call) to fetch the recording and transcript after the call.
    /// </summary>
    public sealed partial class AgentSessionReadyEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionReadyEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentSessionReadyEventType Type { get; set; }

        /// <summary>
        /// Identifier of the call record created for this session. Use it with the calls API to fetch the recording and transcript after the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The connected agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The agent version this session is pinned to, which is the version published when the connection opened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentVersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.Realtime.AgentSessionReadyEventAudio Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionReadyEvent" /> class.
        /// </summary>
        /// <param name="callId">
        /// Identifier of the call record created for this session. Use it with the calls API to fetch the recording and transcript after the call.
        /// </param>
        /// <param name="agentId">
        /// The connected agent.
        /// </param>
        /// <param name="agentVersionId">
        /// The agent version this session is pinned to, which is the version published when the connection opened.
        /// </param>
        /// <param name="audio"></param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionReadyEvent(
            string callId,
            string agentId,
            string agentVersionId,
            global::Cartesia.Realtime.AgentSessionReadyEventAudio audio,
            global::Cartesia.Realtime.AgentSessionReadyEventType type)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersionId = agentVersionId ?? throw new global::System.ArgumentNullException(nameof(agentVersionId));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionReadyEvent" /> class.
        /// </summary>
        public AgentSessionReadyEvent()
        {
        }

    }
}