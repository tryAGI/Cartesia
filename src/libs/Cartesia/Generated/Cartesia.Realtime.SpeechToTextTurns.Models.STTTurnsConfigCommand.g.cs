
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Change turn detection settings, keyterms, or language hints mid-stream
    /// </summary>
    public sealed partial class STTTurnsConfigCommand
    {
        /// <summary>
        /// Command type. Send this as a JSON formatted WebSocket text message to update model settings.<br/>
        /// Changes take effect right away, including for words not returned yet. There's no reply on success. An invalid message returns an `error` event, changes nothing, and leaves the connection open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConfigCommandTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandType Type { get; set; }

        /// <summary>
        /// Turn detection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandTurn? Turn { get; set; }

        /// <summary>
        /// `ink-preview` only. Replaces the session's keyterms. `[]` clears them, and leaving the field out keeps them. The limits are the same as at connect time.<br/>
        /// See [Change keyterms mid-stream](/use-the-api/stt/keyterms#change-keyterms-mid-stream).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// `ink-preview` only. Replaces the session's language hints, up to 6. `[]` clears them, and leaving the field out keeps them.<br/>
        /// See [Change hints mid-stream](/use-the-api/stt/languages#change-hints-mid-stream).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConfigCommand" /> class.
        /// </summary>
        /// <param name="type">
        /// Command type. Send this as a JSON formatted WebSocket text message to update model settings.<br/>
        /// Changes take effect right away, including for words not returned yet. There's no reply on success. An invalid message returns an `error` event, changes nothing, and leaves the connection open.
        /// </param>
        /// <param name="turn">
        /// Turn detection settings
        /// </param>
        /// <param name="keyterms">
        /// `ink-preview` only. Replaces the session's keyterms. `[]` clears them, and leaving the field out keeps them. The limits are the same as at connect time.<br/>
        /// See [Change keyterms mid-stream](/use-the-api/stt/keyterms#change-keyterms-mid-stream).
        /// </param>
        /// <param name="languageHints">
        /// `ink-preview` only. Replaces the session's language hints, up to 6. `[]` clears them, and leaving the field out keeps them.<br/>
        /// See [Change hints mid-stream](/use-the-api/stt/languages#change-hints-mid-stream).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsConfigCommand(
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandType type,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandTurn? turn,
            global::System.Collections.Generic.IList<string>? keyterms,
            global::System.Collections.Generic.IList<string>? languageHints)
        {
            this.Type = type;
            this.Turn = turn;
            this.Keyterms = keyterms;
            this.LanguageHints = languageHints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConfigCommand" /> class.
        /// </summary>
        public STTTurnsConfigCommand()
        {
        }

    }
}