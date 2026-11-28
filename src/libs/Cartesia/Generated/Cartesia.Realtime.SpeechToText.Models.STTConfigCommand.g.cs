
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    /// Change keyterms or language hints mid-stream (`ink-preview` only)
    /// </summary>
    public sealed partial class STTConfigCommand
    {
        /// <summary>
        /// Command type. Send this as a JSON formatted WebSocket text message. `ink-preview` only.<br/>
        /// Changes take effect right away, including for words not returned yet. There's no reply on success. An invalid message returns an `error` event, changes nothing, and leaves the connection open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTConfigCommandTypeJsonConverter))]
        public global::Cartesia.Realtime.SpeechToText.STTConfigCommandType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="STTConfigCommand" /> class.
        /// </summary>
        /// <param name="type">
        /// Command type. Send this as a JSON formatted WebSocket text message. `ink-preview` only.<br/>
        /// Changes take effect right away, including for words not returned yet. There's no reply on success. An invalid message returns an `error` event, changes nothing, and leaves the connection open.
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
        public STTConfigCommand(
            global::Cartesia.Realtime.SpeechToText.STTConfigCommandType type,
            global::System.Collections.Generic.IList<string>? keyterms,
            global::System.Collections.Generic.IList<string>? languageHints)
        {
            this.Type = type;
            this.Keyterms = keyterms;
            this.LanguageHints = languageHints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTConfigCommand" /> class.
        /// </summary>
        public STTConfigCommand()
        {
        }

    }
}