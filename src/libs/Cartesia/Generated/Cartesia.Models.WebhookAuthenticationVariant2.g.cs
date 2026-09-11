
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Sends an `Authorization` header using a bearer token.
    /// </summary>
    public sealed partial class WebhookAuthenticationVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationVariant2ModeJsonConverter))]
        public global::Cartesia.WebhookAuthenticationVariant2Mode Mode { get; set; }

        /// <summary>
        /// A secret credential. `secret_value` is write-only and is never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.WebhookSecret Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationVariant2" /> class.
        /// </summary>
        /// <param name="token">
        /// A secret credential. `secret_value` is write-only and is never returned.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAuthenticationVariant2(
            global::Cartesia.WebhookSecret token,
            global::Cartesia.WebhookAuthenticationVariant2Mode mode)
        {
            this.Mode = mode;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationVariant2" /> class.
        /// </summary>
        public WebhookAuthenticationVariant2()
        {
        }

    }
}