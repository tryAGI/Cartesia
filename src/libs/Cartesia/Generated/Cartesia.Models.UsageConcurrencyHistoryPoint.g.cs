
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The highest concurrency seen in one five-minute bucket.<br/>
    /// The requests and WebSockets counters overlap, because work over a WebSocket counts in both. Don't add them together.
    /// </summary>
    public sealed partial class UsageConcurrencyHistoryPoint
    {
        /// <summary>
        /// Start of the five-minute bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTs { get; set; }

        /// <summary>
        /// End of the five-minute bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTs { get; set; }

        /// <summary>
        /// Concurrent TTS generations. Counts toward your TTS concurrency limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtsRequests { get; set; }

        /// <summary>
        /// Open TTS WebSocket connections. Counts toward your TTS WebSocket limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_websockets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtsWebsockets { get; set; }

        /// <summary>
        /// Concurrent transcription streams. Counts toward your STT concurrency limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SttRequests { get; set; }

        /// <summary>
        /// Open STT WebSocket connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_websockets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SttWebsockets { get; set; }

        /// <summary>
        /// Concurrent agent calls, inbound, web and outbound together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageConcurrencyHistoryPoint" /> class.
        /// </summary>
        /// <param name="startTs">
        /// Start of the five-minute bucket.
        /// </param>
        /// <param name="endTs">
        /// End of the five-minute bucket.
        /// </param>
        /// <param name="ttsRequests">
        /// Concurrent TTS generations. Counts toward your TTS concurrency limit.
        /// </param>
        /// <param name="ttsWebsockets">
        /// Open TTS WebSocket connections. Counts toward your TTS WebSocket limit.
        /// </param>
        /// <param name="sttRequests">
        /// Concurrent transcription streams. Counts toward your STT concurrency limit.
        /// </param>
        /// <param name="sttWebsockets">
        /// Open STT WebSocket connections.
        /// </param>
        /// <param name="agentCalls">
        /// Concurrent agent calls, inbound, web and outbound together.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageConcurrencyHistoryPoint(
            global::System.DateTime startTs,
            global::System.DateTime endTs,
            int ttsRequests,
            int ttsWebsockets,
            int sttRequests,
            int sttWebsockets,
            int agentCalls)
        {
            this.StartTs = startTs;
            this.EndTs = endTs;
            this.TtsRequests = ttsRequests;
            this.TtsWebsockets = ttsWebsockets;
            this.SttRequests = sttRequests;
            this.SttWebsockets = sttWebsockets;
            this.AgentCalls = agentCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageConcurrencyHistoryPoint" /> class.
        /// </summary>
        public UsageConcurrencyHistoryPoint()
        {
        }

    }
}