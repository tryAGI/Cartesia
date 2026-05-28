
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Sent as a JSON-encoded WebSocket text frame to close the session cleanly. All buffered audio will be processed by the model into events before the connection closes.
    /// </summary>
    public sealed partial class STTAutoFinalizeCloseCommand
    {
        /// <summary>
        /// Command type. Send this as a JSON-encoded WebSocket text frame to close the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.STTAutoFinalizeCloseCommandTypeJsonConverter))]
        public global::Cartesia.STTAutoFinalizeCloseCommandType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTAutoFinalizeCloseCommand" /> class.
        /// </summary>
        /// <param name="type">
        /// Command type. Send this as a JSON-encoded WebSocket text frame to close the session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTAutoFinalizeCloseCommand(
            global::Cartesia.STTAutoFinalizeCloseCommandType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTAutoFinalizeCloseCommand" /> class.
        /// </summary>
        public STTAutoFinalizeCloseCommand()
        {
        }

    }
}