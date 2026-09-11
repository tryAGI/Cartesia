
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Acknowledgment for the `finalize` command
    /// </summary>
    public sealed partial class STTFlushDoneResponse
    {
        /// <summary>
        /// Response type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTFlushDoneResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseType Type { get; set; }

        /// <summary>
        /// Unique identifier for this websocket connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Has no meaning for this message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTFlushDoneResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this websocket connection
        /// </param>
        /// <param name="type">
        /// Response type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTFlushDoneResponse(
            string requestId,
            global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseType type)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTFlushDoneResponse" /> class.
        /// </summary>
        public STTFlushDoneResponse()
        {
        }

    }
}