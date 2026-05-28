
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Acknowledgment that buffered audio has been processed in response to a `finalize` command.<br/>
    /// Example: {"type":"flush_done","request_id":"b67e1c5d-2f4c-4c3d-9f82-96eb4d2f12a8"}
    /// </summary>
    public sealed partial class STTManualFinalizeFlushDoneResponse
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTManualFinalizeFlushDoneResponseTypeJsonConverter))]
        public global::Cartesia.STTManualFinalizeFlushDoneResponseType Type { get; set; }

        /// <summary>
        /// Unique identifier for this WebSocket connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTManualFinalizeFlushDoneResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this WebSocket connection.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTManualFinalizeFlushDoneResponse(
            string requestId,
            global::Cartesia.STTManualFinalizeFlushDoneResponseType type)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTManualFinalizeFlushDoneResponse" /> class.
        /// </summary>
        public STTManualFinalizeFlushDoneResponse()
        {
        }

    }
}