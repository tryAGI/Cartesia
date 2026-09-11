
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Use this to cancel a context, so that no more messages are generated for that context.
    /// </summary>
    public sealed partial class CancelRequest
    {
        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// See [Contexts](/use-the-api/tts-websocket/contexts) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// Whether to cancel the context, so that no more messages are generated for that context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Cancel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelRequest" /> class.
        /// </summary>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// See [Contexts](/use-the-api/tts-websocket/contexts) for details.
        /// </param>
        /// <param name="cancel">
        /// Whether to cancel the context, so that no more messages are generated for that context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelRequest(
            string contextId,
            bool cancel)
        {
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.Cancel = cancel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelRequest" /> class.
        /// </summary>
        public CancelRequest()
        {
        }

    }
}