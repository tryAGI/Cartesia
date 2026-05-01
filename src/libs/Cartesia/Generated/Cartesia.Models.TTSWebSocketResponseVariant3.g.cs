
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSWebSocketResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant3TypeJsonConverter))]
        public global::Cartesia.TTSWebSocketResponseVariant3Type Type { get; set; }

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
        /// Whether generation is complete. Always `true` for done events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSWebSocketResponseVariant3" /> class.
        /// </summary>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.
        /// </param>
        /// <param name="statusCode">
        /// HTTP-style status code
        /// </param>
        /// <param name="done">
        /// Whether generation is complete. Always `true` for done events.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSWebSocketResponseVariant3(
            string contextId,
            int statusCode,
            bool done,
            global::Cartesia.TTSWebSocketResponseVariant3Type type)
        {
            this.Type = type;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.StatusCode = statusCode;
            this.Done = done;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSWebSocketResponseVariant3" /> class.
        /// </summary>
        public TTSWebSocketResponseVariant3()
        {
        }
    }
}