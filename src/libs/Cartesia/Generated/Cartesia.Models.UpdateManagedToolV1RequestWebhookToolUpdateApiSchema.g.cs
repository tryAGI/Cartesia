
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedToolV1RequestWebhookToolUpdateApiSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationJsonConverter))]
        public global::Cartesia.WebhookAuthentication? Authentication { get; set; }

        /// <summary>
        /// The HTTP method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethodJsonConverter))]
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? Method { get; set; }

        /// <summary>
        /// Path parameters keyed by placeholder name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? PathParamsSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params_schema")]
        public global::Cartesia.WebhookQuerySchema? QueryParamsSchema { get; set; }

        /// <summary>
        /// The schema for the JSON request body. The root must be an `object`. Only `POST`, `PUT`, and `PATCH` requests can include a body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body_schema")]
        public global::Cartesia.WebhookBodyParam? RequestBodySchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret>?>? RequestHeaders { get; set; }

        /// <summary>
        /// The HTTPS endpoint to call. Use `{name}` for path parameters defined in `path_params_schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedToolV1RequestWebhookToolUpdateApiSchema" /> class.
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="method">
        /// The HTTP method.
        /// </param>
        /// <param name="pathParamsSchema">
        /// Path parameters keyed by placeholder name.
        /// </param>
        /// <param name="queryParamsSchema"></param>
        /// <param name="requestBodySchema">
        /// The schema for the JSON request body. The root must be an `object`. Only `POST`, `PUT`, and `PATCH` requests can include a body.
        /// </param>
        /// <param name="requestHeaders"></param>
        /// <param name="url">
        /// The HTTPS endpoint to call. Use `{name}` for path parameters defined in `path_params_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedToolV1RequestWebhookToolUpdateApiSchema(
            global::Cartesia.WebhookAuthentication? authentication,
            global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? method,
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? pathParamsSchema,
            global::Cartesia.WebhookQuerySchema? queryParamsSchema,
            global::Cartesia.WebhookBodyParam? requestBodySchema,
            global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret>?>? requestHeaders,
            string? url)
        {
            this.Authentication = authentication;
            this.Method = method;
            this.PathParamsSchema = pathParamsSchema;
            this.QueryParamsSchema = queryParamsSchema;
            this.RequestBodySchema = requestBodySchema;
            this.RequestHeaders = requestHeaders;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedToolV1RequestWebhookToolUpdateApiSchema" /> class.
        /// </summary>
        public UpdateManagedToolV1RequestWebhookToolUpdateApiSchema()
        {
        }

    }
}