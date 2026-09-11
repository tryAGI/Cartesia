
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A stored credential. `secret_value` is not returned.
    /// </summary>
    public sealed partial class WebhookSecretResponse
    {
        /// <summary>
        /// A label for this credential. Do not include the secret itself because this field is stored as plain text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_description")]
        public string? SecretDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookSecretResponseTypeJsonConverter))]
        public global::Cartesia.WebhookSecretResponseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecretResponse" /> class.
        /// </summary>
        /// <param name="secretDescription">
        /// A label for this credential. Do not include the secret itself because this field is stored as plain text.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSecretResponse(
            string? secretDescription,
            global::Cartesia.WebhookSecretResponseType type)
        {
            this.SecretDescription = secretDescription;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecretResponse" /> class.
        /// </summary>
        public WebhookSecretResponse()
        {
        }

    }
}