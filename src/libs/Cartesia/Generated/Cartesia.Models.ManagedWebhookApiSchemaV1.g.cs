
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedWebhookApiSchemaV1
    {
        /// <summary>
        /// Authentication sent in the `Authorization` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationJsonConverter))]
        public global::Cartesia.WebhookAuthentication? Authentication { get; set; }

        /// <summary>
        /// The HTTP method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1MethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedWebhookApiSchemaV1Method Method { get; set; }

        /// <summary>
        /// Path parameters keyed by placeholder name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? PathParamsSchema { get; set; }

        /// <summary>
        /// Parameters sent in the request query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params_schema")]
        public global::Cartesia.WebhookQuerySchema? QueryParamsSchema { get; set; }

        /// <summary>
        /// A value sent in the JSON request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body_schema")]
        public global::Cartesia.WebhookBodyParam? RequestBodySchema { get; set; }

        /// <summary>
        /// Headers sent with every request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// The HTTPS endpoint to call. Use `{name}` for path parameters defined in `path_params_schema`.
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
        /// Initializes a new instance of the <see cref="ManagedWebhookApiSchemaV1" /> class.
        /// </summary>
        /// <param name="method">
        /// The HTTP method.
        /// </param>
        /// <param name="url">
        /// The HTTPS endpoint to call. Use `{name}` for path parameters defined in `path_params_schema`.
        /// </param>
        /// <param name="authentication">
        /// Authentication sent in the `Authorization` header.
        /// </param>
        /// <param name="pathParamsSchema">
        /// Path parameters keyed by placeholder name.
        /// </param>
        /// <param name="queryParamsSchema">
        /// Parameters sent in the request query string.
        /// </param>
        /// <param name="requestBodySchema">
        /// A value sent in the JSON request body.
        /// </param>
        /// <param name="requestHeaders">
        /// Headers sent with every request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedWebhookApiSchemaV1(
            global::Cartesia.ManagedWebhookApiSchemaV1Method method,
            string url,
            global::Cartesia.WebhookAuthentication? authentication,
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? pathParamsSchema,
            global::Cartesia.WebhookQuerySchema? queryParamsSchema,
            global::Cartesia.WebhookBodyParam? requestBodySchema,
            object? requestHeaders)
        {
            this.Authentication = authentication;
            this.Method = method;
            this.PathParamsSchema = pathParamsSchema;
            this.QueryParamsSchema = queryParamsSchema;
            this.RequestBodySchema = requestBodySchema;
            this.RequestHeaders = requestHeaders;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedWebhookApiSchemaV1" /> class.
        /// </summary>
        public ManagedWebhookApiSchemaV1()
        {
        }

    }
}