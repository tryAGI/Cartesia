
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Acknowledgment for the `close` command
    /// </summary>
    public sealed partial class STTDoneResponse
    {
        /// <summary>
        /// Response type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTDoneResponseTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponseType Type { get; set; }

        /// <summary>
        /// Unique identifier for this WebSocket connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// `ink-preview` only. Languages detected in audio sent after the last `finalize`, highest confidence first. Detection looks at the most recent audio, so this can include earlier audio. Left out when no audio arrived since then.<br/>
        /// See [Detected languages](/use-the-api/stt/languages#detected-languages).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTDoneResponseLanguage>? Languages { get; set; }

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
        /// Initializes a new instance of the <see cref="STTDoneResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this WebSocket connection
        /// </param>
        /// <param name="type">
        /// Response type identifier
        /// </param>
        /// <param name="languages">
        /// `ink-preview` only. Languages detected in audio sent after the last `finalize`, highest confidence first. Detection looks at the most recent audio, so this can include earlier audio. Left out when no audio arrived since then.<br/>
        /// See [Detected languages](/use-the-api/stt/languages#detected-languages).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTDoneResponse(
            string requestId,
            global::Cartesia.Realtime.SpeechToText.STTDoneResponseType type,
            global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTDoneResponseLanguage>? languages)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTDoneResponse" /> class.
        /// </summary>
        public STTDoneResponse()
        {
        }

    }
}