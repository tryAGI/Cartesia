
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSWebSocketResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant1TypeJsonConverter))]
        public global::Cartesia.TTSWebSocketResponseVariant1Type Type { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// HTTP-style status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Whether this is the final chunk for this context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Base64-encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Server-side processing time for this chunk in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepTime { get; set; }

        /// <summary>
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush_id")]
        public int? FlushId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSWebSocketResponseVariant1" /> class.
        /// </summary>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </param>
        /// <param name="statusCode">
        /// HTTP-style status code
        /// </param>
        /// <param name="done">
        /// Whether this is the final chunk for this context
        /// </param>
        /// <param name="data">
        /// Base64-encoded audio data
        /// </param>
        /// <param name="stepTime">
        /// Server-side processing time for this chunk in milliseconds
        /// </param>
        /// <param name="type"></param>
        /// <param name="flushId">
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSWebSocketResponseVariant1(
            string contextId,
            int statusCode,
            bool done,
            string data,
            double stepTime,
            global::Cartesia.TTSWebSocketResponseVariant1Type type,
            int? flushId)
        {
            this.Type = type;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.StatusCode = statusCode;
            this.Done = done;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.StepTime = stepTime;
            this.FlushId = flushId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSWebSocketResponseVariant1" /> class.
        /// </summary>
        public TTSWebSocketResponseVariant1()
        {
        }
    }
}