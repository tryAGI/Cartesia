
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The telephony parameters associated with the call when the call is made via a phone. More details can also be returned depending on the provider.
    /// </summary>
    public sealed partial class TelephonyParams
    {
        /// <summary>
        /// The phone number of the caller. Present for phone calls; omitted for websocket connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// The phone number of the agent. Present for phone calls; omitted for websocket connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The SID of the telephony call from the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_sid")]
        public string? CallSid { get; set; }

        /// <summary>
        /// The direction of the call, e.g., `inbound` or `outbound`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public string? Direction { get; set; }

        /// <summary>
        /// Additional parameters associated with the telephony call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// Additional headers associated with the telephony call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The type of connection used for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TelephonyParamsConnectionTypeJsonConverter))]
        public global::Cartesia.TelephonyParamsConnectionType? ConnectionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyParams" /> class.
        /// </summary>
        /// <param name="to">
        /// The phone number of the caller. Present for phone calls; omitted for websocket connections.
        /// </param>
        /// <param name="from">
        /// The phone number of the agent. Present for phone calls; omitted for websocket connections.
        /// </param>
        /// <param name="callSid">
        /// The SID of the telephony call from the provider.
        /// </param>
        /// <param name="direction">
        /// The direction of the call, e.g., `inbound` or `outbound`.
        /// </param>
        /// <param name="parameters">
        /// Additional parameters associated with the telephony call.
        /// </param>
        /// <param name="headers">
        /// Additional headers associated with the telephony call.
        /// </param>
        /// <param name="connectionType">
        /// The type of connection used for the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelephonyParams(
            string? to,
            string? from,
            string? callSid,
            string? direction,
            global::System.Collections.Generic.Dictionary<string, string>? parameters,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::Cartesia.TelephonyParamsConnectionType? connectionType)
        {
            this.To = to;
            this.From = from;
            this.CallSid = callSid;
            this.Direction = direction;
            this.Parameters = parameters;
            this.Headers = headers;
            this.ConnectionType = connectionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyParams" /> class.
        /// </summary>
        public TelephonyParams()
        {
        }

    }
}