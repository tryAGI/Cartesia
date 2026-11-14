
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia
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
        public global::Cartesia.APIInfo? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListModelsResponse? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ModelCatalogEntry>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelCatalogEntry? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelCapability? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.STTMode>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTMode? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModelID? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifier? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormat? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationConfig? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WAVOutputFormat? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MP3OutputFormat? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawOutputFormat? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Emotion? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WAVOutputFormatContainer? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawEncoding? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MP3OutputFormatContainer? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawOutputFormatContainer? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSERequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SSEOutputFormat? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEvent? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEChunkEvent? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEvent? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEDoneEvent? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEErrorEvent? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminator? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminatorType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SSEOutputFormatContainer? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEChunkEventType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEventType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEventWordTimestamps? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEventType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEventPhonemeTimestamps? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEDoneEventType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEErrorEventType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTEncoding? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TimestampGranularity? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TranscriptionResponse? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TranscriptionResponseType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TranscriptionWord>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TranscriptionWord? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1Request? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfig? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudio? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioInput? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutput? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentDynamicVariablePlaceholdersV1? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentInitialMessageInterruptionsV1? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigLanguage? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentLanguageOrLocale>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ManagedAgentLanguagePresetsV1>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentLanguagePresetsV1? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigModel? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemTools? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCall? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSkipTurn? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetection? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentToolReferenceV1? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigTurn? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1Version? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, double?, bool?>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Auto? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1AutoType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1ExplicitType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Audio? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInput? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutput? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Language? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Model? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Turn? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentPrimaryLanguageV1? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LanguageOrLocale? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCall? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SkipTurn? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SkipTurnPreToolSpeech? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetection? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestination? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentsV1Response? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSummaryV1? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PublicErrorResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1Request? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfig? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudio? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInput? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutput? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigLanguage? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigModel? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemTools? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSkipTurn? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigTurn? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentVersionsV1Response? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentVersionV1? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentModelsV1Response? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1Pricing? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1PricingCurrency? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1Discriminator? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1DiscriminatorType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1Discriminator? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Response? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAssignment? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1ExecutionMode? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1PreToolSpeech? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1Type? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1ExecutionMode? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1PreToolSpeech? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1Type? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1Type? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1Type? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponse? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParam? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQuerySchema? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParam? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponse? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeader? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParam? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1Type? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthentication? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Method? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecret? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1Mode? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2Mode? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParamType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParam? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParamType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponseType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeaderType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItems? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItemsType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1Mode? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2Mode? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItems? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItemsType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedToolsV1Response? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1Request? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetCallsResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCall>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCall? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTranscript? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParams? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallTelephonyAccountType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallStatus? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.EndReason? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ToolCall? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParamsConnectionType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DynamicVariableUpdate? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItem? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItemResponse? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentDynamicVariableInputs? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequestRegion? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatch? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRegion? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchStatus? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRecipient? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAgentCallBatchesResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponseVariant2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponseAgent? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminator? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminatorType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponseType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyRegion? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponseType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponseType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBody? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderById? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberBody? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBody? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderById? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminator? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminatorType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponseType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkInboundDetails? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkOutboundDetails? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPMediaEncryption? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkTransport? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBody? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBody? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBody? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminator? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminatorType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBodyType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBodyType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InboundSIPTrunkConfig? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutboundSIPTrunkConfig? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPCredentials? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBody? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBody? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBody? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminator? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminatorType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBodyType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBodyType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateInboundSIPTrunkConfig? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateOutboundSIPTrunkConfig? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPCredentials? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateAgentWebSessionRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<string, double?, bool?>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSessionConfig? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateAgentWebrtcSessionResponse? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSessionConfigLanguage? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSessionConfigAudio? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSessionConfigAudioOutput? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateAgentWebsocketSessionResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricsResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Metric>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Metric? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateMetricRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricResultsResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.MetricResult>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MetricResult? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentMetricResultStatus? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenGrant? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenResponse? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenderPresentation? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceExpandOptions? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetVoicesResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Voice>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Voice? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceStatus? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccess? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccentsItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceVisibility? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAccentsResponse? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Accent>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Accent? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SupportedLanguage? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadata? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataAccess? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataVisibility? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequest? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum2? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnumType? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceAccent? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnumType? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AddVoiceAccentsRequest? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AttachVoiceAccent? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedPronunciationDicts? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDict? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictAccess? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictItem? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictVisibility? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum2? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnumType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum2? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnumType? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasets? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Dataset>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Dataset? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateDatasetRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateDatasetRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasetFiles? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetFile? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilePurpose? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.File? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFiles? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.File>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFineTunes? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTune>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTune? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneStatus? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneUserError? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateFineTuneRequest? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedVoices? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormatContainer? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageInterval? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsGroupBy? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsResponse? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBucket? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBreakdownSeries? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsResponse? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsBucket? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListApiKeysResponse? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ApiKey>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKey? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUser? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUserRole? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListUsersBadRequestError? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UnexpectedErrorResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetUserNotFoundError? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInvite? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteRole? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteStatus? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListInvitesBadRequestError? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateOrganizationInvitesRequest? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateInvitesBadRequestError? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetInviteNotFoundError? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TextChunk? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogEvent? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogMetric? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberSummary? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GitRepository? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSummary? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTemplate? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumber? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetTemplatesResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetAgentsResponse? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateAgentRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Deployment? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.S3UploadParamsResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FlushDoneMessage? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DoneMessage? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ErrorMessage? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTBatchModel? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeModel? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeModel? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModel? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillModel? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneBaseModel? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelSpeed? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponse? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1Type? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2Type? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3Type? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4Type? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WordTimestamps? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5Type? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6Type? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhonemeTimestamps? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminator? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminatorType? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketQueryParams? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommand? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommandType? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnected? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnectedType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStart? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStartType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdate? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdateType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEndType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResume? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResumeType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEnd? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEndType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponseType? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponse? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParams? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponse? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponseType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponse? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponseType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponseType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponse? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CancelContextRequest? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationRequest? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketRequest? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEChunk? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEDone? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEError? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEErrorType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceLocale? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeTargetLanguage? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeEnglishDialect? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeFrenchDialect? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeSpanishDialect? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizePortugueseDialect? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeDialect? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Gender? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequest? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestModel? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestLanguage? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DetectWatermarkRequest? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequest? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequestAccess? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadRequest? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequest? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequestModelId? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesRequest? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseRequest? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelsListCapability? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelsListCartesiaVersion? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsBytesCartesiaVersion? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsSseCartesiaVersion? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeCartesiaVersion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DetectWatermarkCartesiaVersion? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsCartesiaVersion? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsCartesiaVersion? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsModelsCartesiaVersion? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsToolsCartesiaVersion? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsType? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsCartesiaVersion? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdExpandItem? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallsCartesiaVersion? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateOutboundCallCartesiaVersion? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallCartesiaVersion? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCallCartesiaVersion? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallCartesiaVersion? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDownloadCallAudioCartesiaVersion? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateCallBatchCartesiaVersion? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallBatchesCartesiaVersion? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallBatchCartesiaVersion? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallBatchCartesiaVersion? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRetryCallBatchCartesiaVersion? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListCartesiaVersion? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListType? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersImportCartesiaVersion? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersGetCartesiaVersion? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersUpdateCartesiaVersion? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersDeleteCartesiaVersion? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersProvisionCartesiaVersion? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListCartesiaVersion? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListType? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersCreateCartesiaVersion? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersGetCartesiaVersion? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersUpdateCartesiaVersion? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersDeleteCartesiaVersion? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateAgentWebrtcSessionCartesiaVersion? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateAgentWebsocketSessionCartesiaVersion? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricsCartesiaVersion? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateMetricCartesiaVersion? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetMetricCartesiaVersion? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteMetricCartesiaVersion? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricResultsCartesiaVersion? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsExportMetricResultsCartesiaVersion? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsAddMetricToAgentCartesiaVersion? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AuthAccessTokenCartesiaVersion? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesListCartesiaVersion? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AccentsListCartesiaVersion? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneCartesiaVersion? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteCartesiaVersion? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesUpdateCartesiaVersion? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesGetCartesiaVersion? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesLocalizeCartesiaVersion? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesAddAccentsCartesiaVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteAccentCartesiaVersion? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsListCartesiaVersion? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsCreateCartesiaVersion? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsGetCartesiaVersion? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsUpdateCartesiaVersion? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsDeleteCartesiaVersion? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListCartesiaVersion? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsCreateCartesiaVersion? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsGetCartesiaVersion? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUpdateCartesiaVersion? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteCartesiaVersion? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListFilesCartesiaVersion? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileCartesiaVersion? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteFileCartesiaVersion? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadCartesiaVersion? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesListCartesiaVersion? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesGetCartesiaVersion? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDownloadCartesiaVersion? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteCartesiaVersion? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListCartesiaVersion? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesCreateCartesiaVersion? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesGetCartesiaVersion? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesDeleteCartesiaVersion? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListVoicesCartesiaVersion? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesCartesiaVersion? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsCartesiaVersion? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsCartesiaVersion? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysListCartesiaVersion? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysGetCartesiaVersion? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersCartesiaVersion? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesStatus? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesCartesiaVersion? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostOrganizationsInvitesCartesiaVersion? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCartesiaVersion? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCartesiaVersion? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsUpdateCartesiaVersion? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCartesiaVersion? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsTemplatesCartesiaVersion? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsPhoneNumbersCartesiaVersion? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListDeploymentsCartesiaVersion? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetDeploymentCartesiaVersion? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesCartesiaVersion? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseCartesiaVersion? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DetectWatermarkResponse? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallResponse? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListResponse? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteResponse? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersResponse? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesResponse? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Deployment>? Type670 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ModelCatalogEntry>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.STTMode>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.TranscriptionWord>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentLanguageOrLocale>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentToolReferenceV1>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSummaryV1>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentVersionV1>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentModelV1>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.WebhookAssignment>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AnyOf<string, double?, bool?>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedToolV1>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCall>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentTranscript>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ToolCall>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.DynamicVariableUpdate>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItemResponse>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCallBatchRecipient>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCallBatch>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Metric>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.MetricResult>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Voice>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.VoiceAccentsItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Accent>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AttachVoiceAccent>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PronunciationDict>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PronunciationDictItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Dataset>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.DatasetFile>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.File>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.FineTune>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.FineTuneUserError>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UsageCreditsBucket>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UsageAgentsBucket>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ApiKey>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumberSummary>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentTemplate>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentSummary>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.WordTimestamps>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.TimestampGranularity>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.VoiceExpandOptions>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumberResponse>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ProviderAccountResponse>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OrganizationUser>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OrganizationInvite>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumber>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Deployment>? ListType53 { get; set; }
    }
}