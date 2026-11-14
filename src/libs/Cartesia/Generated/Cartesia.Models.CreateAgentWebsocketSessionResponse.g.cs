
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentWebsocketSessionResponse
    {
        /// <summary>
        /// ID of the pre-created call. The `session_ready` event returns the same value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// WebSocket URL for this agent. Append the returned session token as the `access_token` query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Opaque, short-lived, single-use session token. Do not inspect or log it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Connection deadline, currently four minutes after creation. Use this timestamp rather than calculating the deadline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebsocketSessionResponse" /> class.
        /// </summary>
        /// <param name="callId">
        /// ID of the pre-created call. The `session_ready` event returns the same value.
        /// </param>
        /// <param name="url">
        /// WebSocket URL for this agent. Append the returned session token as the `access_token` query parameter.
        /// </param>
        /// <param name="token">
        /// Opaque, short-lived, single-use session token. Do not inspect or log it.
        /// </param>
        /// <param name="expiresAt">
        /// Connection deadline, currently four minutes after creation. Use this timestamp rather than calculating the deadline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentWebsocketSessionResponse(
            string callId,
            string url,
            string token,
            global::System.DateTime expiresAt)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebsocketSessionResponse" /> class.
        /// </summary>
        public CreateAgentWebsocketSessionResponse()
        {
        }

    }
}