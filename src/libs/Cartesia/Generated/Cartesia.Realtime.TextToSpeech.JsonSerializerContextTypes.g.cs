
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.TextToSpeech
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
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestModelId? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.OneOf<string, global::Cartesia.Realtime.TextToSpeech.GenerationRequestVoice>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestVoice? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormat? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestLanguage? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestGenerationConfig? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationRequestGenerationConfigEmotion? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.CancelRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ChunkResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ChunkResponseType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.FlushDoneResponseType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponseType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TimestampsResponseType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TimestampsResponseWordTimestamps? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponseType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponsePhonemeTimestamps? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TTSErrorResponseType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ServerEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminator? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType? Type34 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType1 { get; set; }
    }
}