
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentWebrtcSessionResponse
    {
        /// <summary>
        /// ID of the pre-created call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// LiveKit server URL the browser connects to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Short-lived LiveKit participant token for the browser connection. Do not log it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// LiveKit room the browser joins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Room { get; set; }

        /// <summary>
        /// Connection deadline. Create a new session if the browser does not join before this time.
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
        /// Initializes a new instance of the <see cref="CreateAgentWebrtcSessionResponse" /> class.
        /// </summary>
        /// <param name="callId">
        /// ID of the pre-created call.
        /// </param>
        /// <param name="url">
        /// LiveKit server URL the browser connects to.
        /// </param>
        /// <param name="token">
        /// Short-lived LiveKit participant token for the browser connection. Do not log it.
        /// </param>
        /// <param name="room">
        /// LiveKit room the browser joins.
        /// </param>
        /// <param name="expiresAt">
        /// Connection deadline. Create a new session if the browser does not join before this time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentWebrtcSessionResponse(
            string callId,
            string url,
            string token,
            string room,
            global::System.DateTime expiresAt)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Room = room ?? throw new global::System.ArgumentNullException(nameof(room));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebrtcSessionResponse" /> class.
        /// </summary>
        public CreateAgentWebrtcSessionResponse()
        {
        }

    }
}