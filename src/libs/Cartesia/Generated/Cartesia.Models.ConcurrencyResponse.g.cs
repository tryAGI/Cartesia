
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Your concurrency now, with the limit each counter counts against.<br/>
    /// The requests and WebSockets counters overlap, because work over a WebSocket counts in both. Don't add them together.
    /// </summary>
    public sealed partial class ConcurrencyResponse
    {
        /// <summary>
        /// Concurrent TTS generations, against your TTS concurrency limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.LiveConcurrencyCount TtsRequests { get; set; }

        /// <summary>
        /// Open TTS WebSocket connections, against your TTS WebSocket limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_websockets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.LiveConcurrencyCount TtsWebsockets { get; set; }

        /// <summary>
        /// Concurrent transcription streams, against your STT concurrency limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.LiveConcurrencyCount SttRequests { get; set; }

        /// <summary>
        /// Open STT WebSocket connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_websockets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.LiveConcurrencyCount SttWebsockets { get; set; }

        /// <summary>
        /// Inbound and web agent calls, including calls still connecting, against your inbound call limit. Null when these calls can't be counted, such as when your account has no inbound call limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_inbound_calls")]
        public global::Cartesia.LiveConcurrencyCount? AgentInboundCalls { get; set; }

        /// <summary>
        /// Outbound agent calls, including calls still connecting, against your outbound call limit. Null when these calls can't be counted, such as when your account has no outbound call limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_outbound_calls")]
        public global::Cartesia.LiveConcurrencyCount? AgentOutboundCalls { get; set; }

        /// <summary>
        /// Inbound, web and outbound agent calls together, as in Get Concurrency History. `limit` is always null, because each direction has its own limit. Null when either direction is null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_calls")]
        public global::Cartesia.LiveConcurrencyCount? AgentCalls { get; set; }

        /// <summary>
        /// When the reading was taken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AsOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyResponse" /> class.
        /// </summary>
        /// <param name="ttsRequests">
        /// Concurrent TTS generations, against your TTS concurrency limit.
        /// </param>
        /// <param name="ttsWebsockets">
        /// Open TTS WebSocket connections, against your TTS WebSocket limit.
        /// </param>
        /// <param name="sttRequests">
        /// Concurrent transcription streams, against your STT concurrency limit.
        /// </param>
        /// <param name="sttWebsockets">
        /// Open STT WebSocket connections.
        /// </param>
        /// <param name="asOf">
        /// When the reading was taken.
        /// </param>
        /// <param name="agentInboundCalls">
        /// Inbound and web agent calls, including calls still connecting, against your inbound call limit. Null when these calls can't be counted, such as when your account has no inbound call limit.
        /// </param>
        /// <param name="agentOutboundCalls">
        /// Outbound agent calls, including calls still connecting, against your outbound call limit. Null when these calls can't be counted, such as when your account has no outbound call limit.
        /// </param>
        /// <param name="agentCalls">
        /// Inbound, web and outbound agent calls together, as in Get Concurrency History. `limit` is always null, because each direction has its own limit. Null when either direction is null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyResponse(
            global::Cartesia.LiveConcurrencyCount ttsRequests,
            global::Cartesia.LiveConcurrencyCount ttsWebsockets,
            global::Cartesia.LiveConcurrencyCount sttRequests,
            global::Cartesia.LiveConcurrencyCount sttWebsockets,
            global::System.DateTime asOf,
            global::Cartesia.LiveConcurrencyCount? agentInboundCalls,
            global::Cartesia.LiveConcurrencyCount? agentOutboundCalls,
            global::Cartesia.LiveConcurrencyCount? agentCalls)
        {
            this.TtsRequests = ttsRequests ?? throw new global::System.ArgumentNullException(nameof(ttsRequests));
            this.TtsWebsockets = ttsWebsockets ?? throw new global::System.ArgumentNullException(nameof(ttsWebsockets));
            this.SttRequests = sttRequests ?? throw new global::System.ArgumentNullException(nameof(sttRequests));
            this.SttWebsockets = sttWebsockets ?? throw new global::System.ArgumentNullException(nameof(sttWebsockets));
            this.AgentInboundCalls = agentInboundCalls;
            this.AgentOutboundCalls = agentOutboundCalls;
            this.AgentCalls = agentCalls;
            this.AsOf = asOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyResponse" /> class.
        /// </summary>
        public ConcurrencyResponse()
        {
        }

    }
}