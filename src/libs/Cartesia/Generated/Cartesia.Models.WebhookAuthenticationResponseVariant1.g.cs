
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Sends an `Authorization` header using HTTP Basic authentication.
    /// </summary>
    public sealed partial class WebhookAuthenticationResponseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant1ModeJsonConverter))]
        public global::Cartesia.WebhookAuthenticationResponseVariant1Mode Mode { get; set; }

        /// <summary>
        /// A stored credential. `secret_value` is not returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.WebhookSecretResponse Password { get; set; }

        /// <summary>
        /// The username. It cannot contain a colon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationResponseVariant1" /> class.
        /// </summary>
        /// <param name="password">
        /// A stored credential. `secret_value` is not returned.
        /// </param>
        /// <param name="username">
        /// The username. It cannot contain a colon.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAuthenticationResponseVariant1(
            global::Cartesia.WebhookSecretResponse password,
            string username,
            global::Cartesia.WebhookAuthenticationResponseVariant1Mode mode)
        {
            this.Mode = mode;
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationResponseVariant1" /> class.
        /// </summary>
        public WebhookAuthenticationResponseVariant1()
        {
        }

    }
}