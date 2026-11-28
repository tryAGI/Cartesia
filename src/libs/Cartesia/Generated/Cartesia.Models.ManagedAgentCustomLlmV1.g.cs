
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An OpenAI-compatible Chat Completions endpoint. Requires `model.id` to be `custom_llm`.
    /// </summary>
    public sealed partial class ManagedAgentCustomLlmV1
    {
        /// <summary>
        /// Bearer or Basic authentication. Omit for no authentication, or use a secret in `request_headers`. Do not combine this field with an `Authorization` request header. Credentials and usernames must use printable ASCII; credentials are limited to 16 KiB each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationJsonConverter))]
        public global::Cartesia.WebhookAuthentication? Authentication { get; set; }

        /// <summary>
        /// Optional model ID sent as `model` in requests to your endpoint. If unset, the `model` field is omitted.<br/>
        /// Example: acme-support-v1
        /// </summary>
        /// <example>acme-support-v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Headers included in each request, at most 32. Names are case-insensitively unique and use up to 128 letters, digits, hyphens, or underscores. Values are printable ASCII, up to 16 KiB each. `Accept`, `Accept-Encoding`, `Idempotency-Key`, `Host`, `Content-Type`, `Content-Length`, and hop-by-hop headers are reserved, and an `Authorization` header must be a secret. Secret values are never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Include custom and available system dynamic variables in `cartesia_extra_body.dynamic_variables`<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_call_context")]
        public bool? SendCallContext { get; set; }

        /// <summary>
        /// Public HTTPS API base URL. Cartesia appends `/chat/completions`; omit this suffix, query parameters, fragments, and embedded credentials. Redirects are not followed.<br/>
        /// Example: https://llm.example.com/v1
        /// </summary>
        /// <example>https://llm.example.com/v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentCustomLlmV1" /> class.
        /// </summary>
        /// <param name="url">
        /// Public HTTPS API base URL. Cartesia appends `/chat/completions`; omit this suffix, query parameters, fragments, and embedded credentials. Redirects are not followed.<br/>
        /// Example: https://llm.example.com/v1
        /// </param>
        /// <param name="authentication">
        /// Bearer or Basic authentication. Omit for no authentication, or use a secret in `request_headers`. Do not combine this field with an `Authorization` request header. Credentials and usernames must use printable ASCII; credentials are limited to 16 KiB each.
        /// </param>
        /// <param name="modelId">
        /// Optional model ID sent as `model` in requests to your endpoint. If unset, the `model` field is omitted.<br/>
        /// Example: acme-support-v1
        /// </param>
        /// <param name="requestHeaders">
        /// Headers included in each request, at most 32. Names are case-insensitively unique and use up to 128 letters, digits, hyphens, or underscores. Values are printable ASCII, up to 16 KiB each. `Accept`, `Accept-Encoding`, `Idempotency-Key`, `Host`, `Content-Type`, `Content-Length`, and hop-by-hop headers are reserved, and an `Authorization` header must be a secret. Secret values are never returned.
        /// </param>
        /// <param name="sendCallContext">
        /// Include custom and available system dynamic variables in `cartesia_extra_body.dynamic_variables`<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentCustomLlmV1(
            string url,
            global::Cartesia.WebhookAuthentication? authentication,
            string? modelId,
            object? requestHeaders,
            bool? sendCallContext)
        {
            this.Authentication = authentication;
            this.ModelId = modelId;
            this.RequestHeaders = requestHeaders;
            this.SendCallContext = sendCallContext;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentCustomLlmV1" /> class.
        /// </summary>
        public ManagedAgentCustomLlmV1()
        {
        }

    }
}