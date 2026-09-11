
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Sends an `Authorization` header using a bearer token.
    /// </summary>
    public sealed partial class WebhookAuthenticationResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant2ModeJsonConverter))]
        public global::Cartesia.WebhookAuthenticationResponseVariant2Mode Mode { get; set; }

        /// <summary>
        /// A stored credential. `secret_value` is not returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.WebhookSecretResponse Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationResponseVariant2" /> class.
        /// </summary>
        /// <param name="token">
        /// A stored credential. `secret_value` is not returned.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAuthenticationResponseVariant2(
            global::Cartesia.WebhookSecretResponse token,
            global::Cartesia.WebhookAuthenticationResponseVariant2Mode mode)
        {
            this.Mode = mode;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationResponseVariant2" /> class.
        /// </summary>
        public WebhookAuthenticationResponseVariant2()
        {
        }

    }
}