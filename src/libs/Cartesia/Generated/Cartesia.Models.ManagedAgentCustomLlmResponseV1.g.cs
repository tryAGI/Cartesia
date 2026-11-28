
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An OpenAI-compatible Chat Completions endpoint. Secret values are never returned.
    /// </summary>
    public sealed partial class ManagedAgentCustomLlmResponseV1
    {
        /// <summary>
        /// The credential sent in the `Authorization` header, or `null` for none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationResponseJsonConverter))]
        public global::Cartesia.WebhookAuthenticationResponse? Authentication { get; set; }

        /// <summary>
        /// The model ID sent as `model` in each request, or `null` if the endpoint chooses the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Headers included in each request. Secret values are never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Whether each request includes the call's dynamic variables in `cartesia_extra_body.dynamic_variables`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_call_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SendCallContext { get; set; }

        /// <summary>
        /// The HTTPS base URL of the Chat Completions compatible API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentCustomLlmResponseV1" /> class.
        /// </summary>
        /// <param name="sendCallContext">
        /// Whether each request includes the call's dynamic variables in `cartesia_extra_body.dynamic_variables`.
        /// </param>
        /// <param name="url">
        /// The HTTPS base URL of the Chat Completions compatible API.
        /// </param>
        /// <param name="authentication">
        /// The credential sent in the `Authorization` header, or `null` for none.
        /// </param>
        /// <param name="modelId">
        /// The model ID sent as `model` in each request, or `null` if the endpoint chooses the model.
        /// </param>
        /// <param name="requestHeaders">
        /// Headers included in each request. Secret values are never returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentCustomLlmResponseV1(
            bool sendCallContext,
            string url,
            global::Cartesia.WebhookAuthenticationResponse? authentication,
            string? modelId,
            object? requestHeaders)
        {
            this.Authentication = authentication;
            this.ModelId = modelId;
            this.RequestHeaders = requestHeaders;
            this.SendCallContext = sendCallContext;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentCustomLlmResponseV1" /> class.
        /// </summary>
        public ManagedAgentCustomLlmResponseV1()
        {
        }

    }
}