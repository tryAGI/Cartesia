
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionResponse
    {
        /// <summary>
        /// The message type. Always `transcript` for a batch transcription response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TranscriptionResponseTypeJsonConverter))]
        public global::Cartesia.TranscriptionResponseType Type { get; set; }

        /// <summary>
        /// Unique identifier for this transcription request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Not used for batch transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// The specified language of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The duration of the input audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Word-level timestamps showing the start and end time of each word. Only included when `[word]` is passed into `timestamp_granularities[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Cartesia.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
        /// <param name="type">
        /// The message type. Always `transcript` for a batch transcription response.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this transcription request.
        /// </param>
        /// <param name="language">
        /// The specified language of the input audio.
        /// </param>
        /// <param name="duration">
        /// The duration of the input audio in seconds.
        /// </param>
        /// <param name="words">
        /// Word-level timestamps showing the start and end time of each word. Only included when `[word]` is passed into `timestamp_granularities[]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionResponse(
            string text,
            global::Cartesia.TranscriptionResponseType type,
            string? requestId,
            string? language,
            double? duration,
            global::System.Collections.Generic.IList<global::Cartesia.TranscriptionWord>? words)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Language = language;
            this.Duration = duration;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        public TranscriptionResponse()
        {
        }

    }
}