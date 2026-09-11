
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A secret credential. `secret_value` is write-only and is never returned.
    /// </summary>
    public sealed partial class WebhookSecret
    {
        /// <summary>
        /// A label for this credential. Do not include the secret itself because this field is stored as plain text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_description")]
        public string? SecretDescription { get; set; }

        /// <summary>
        /// The secret to store, such as an API key. This field is write-only. Omit it on update to keep the existing secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        public string? SecretValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookSecretTypeJsonConverter))]
        public global::Cartesia.WebhookSecretType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecret" /> class.
        /// </summary>
        /// <param name="secretDescription">
        /// A label for this credential. Do not include the secret itself because this field is stored as plain text.
        /// </param>
        /// <param name="secretValue">
        /// The secret to store, such as an API key. This field is write-only. Omit it on update to keep the existing secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSecret(
            string? secretDescription,
            string? secretValue,
            global::Cartesia.WebhookSecretType type)
        {
            this.SecretDescription = secretDescription;
            this.SecretValue = secretValue;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecret" /> class.
        /// </summary>
        public WebhookSecret()
        {
        }

    }
}