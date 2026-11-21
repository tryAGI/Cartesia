
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextSourceGenerationContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public byte[]? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFinalizeCommand? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTCloseCommand? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTConfigCommand? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTConfigCommandType? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseType? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseLanguage>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseLanguage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponseType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTDoneResponseLanguage>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponseLanguage? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponseType? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.SpeechToTextModel? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.SpeechToTextEncoding? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.SpeechToTextApiVersion? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEvent? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminator? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType? Type28 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseLanguage>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Realtime.SpeechToText.STTDoneResponseLanguage>? ListType3 { get; set; }
    }
}