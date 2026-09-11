
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
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
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseType? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseType? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponseType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponse? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponseType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.SpeechToTextModel? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.SpeechToTextEncoding? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.SpeechToTextApiVersion? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEvent? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminator? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType? Type21 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>? ListType0 { get; set; }
    }
}