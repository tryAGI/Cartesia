
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Send a JSON encoded config command as a WebSocket text message to update model settings.
    /// </summary>
    public sealed partial class STTTurnsConfigCommand
    {
        /// <summary>
        /// Command type. Send this as a JSON encoded WebSocket text message to update model settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConfigCommandTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandType Type { get; set; }

        /// <summary>
        /// Turn detection settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandTurn? Turn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConfigCommand" /> class.
        /// </summary>
        /// <param name="type">
        /// Command type. Send this as a JSON encoded WebSocket text message to update model settings.
        /// </param>
        /// <param name="turn">
        /// Turn detection settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsConfigCommand(
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandType type,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandTurn? turn)
        {
            this.Type = type;
            this.Turn = turn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConfigCommand" /> class.
        /// </summary>
        public STTTurnsConfigCommand()
        {
        }

    }
}