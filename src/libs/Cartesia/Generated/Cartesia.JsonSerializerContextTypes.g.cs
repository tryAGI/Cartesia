
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
        public global::Cartesia.TTSRequest? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModelID? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifier? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormat? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationConfig? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WAVOutputFormat? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MP3OutputFormat? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawOutputFormat? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Emotion? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WAVOutputFormatContainer? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawEncoding? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MP3OutputFormatContainer? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawOutputFormatContainer? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSERequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SSEOutputFormat? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEvent? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEChunkEvent? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEvent? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEvent? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEDoneEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEErrorEvent? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminator? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminatorType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SSEOutputFormatContainer? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEChunkEventType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEventType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEventWordTimestamps? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type40 { get; set; }
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
        public global::Cartesia.CreateManagedAgentV1RequestConfigLanguage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentPrimaryLanguageV1? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigModel? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemTools? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCall? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSkipTurn? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetection? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentToolReferenceV1? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigTurn? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1Version? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, double?, bool?>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Auto? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1AutoType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1ExplicitType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Audio? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInput? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutput? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Language? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Model? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Turn? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCall? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SkipTurn? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SkipTurnPreToolSpeech? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetection? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1VoicemailDetectionPreToolSpeech? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestination? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentsV1Response? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSummaryV1? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PublicErrorResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1Request? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfig? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudio? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInput? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutput? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigLanguage? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigModel? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemTools? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSkipTurn? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSkipTurnPreToolSpeech? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetection? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsVoicemailDetectionPreToolSpeech? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigTurn? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentVersionsV1Response? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentVersionV1? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentModelsV1Response? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1Pricing? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1PricingCurrency? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1Discriminator? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1DiscriminatorType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1Discriminator? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Response? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAssignment? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1ExecutionMode? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1PreToolSpeech? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1Type? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1ExecutionMode? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1PreToolSpeech? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1Type? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1Type? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1Type? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParam? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQuerySchema? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParam? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeader? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParam? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1Type? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthentication? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Method? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecret? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1Mode? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2Mode? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParamType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParam? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParamType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponseType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeaderType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItems? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItemsType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1Mode? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2Mode? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItems? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItemsType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedToolsV1Response? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1Request? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetCallsResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCall>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCall? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTranscript? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParams? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallTelephonyAccountType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallStatus? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.EndReason? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ToolCall? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParamsConnectionType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DynamicVariableUpdate? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItem? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItemResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentDynamicVariableInputs? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequest? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequestRegion? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatch? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRegion? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchStatus? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRecipient? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAgentCallBatchesResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponseVariant2? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponse? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponseAgent? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminator? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminatorType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponseType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyRegion? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponseType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponseType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBody? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderById? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberBody? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBody? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderById? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminator? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminatorType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponseType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkInboundDetails? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkOutboundDetails? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPMediaEncryption? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkTransport? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBody? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBody? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBody? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminator? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminatorType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBodyType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBodyType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InboundSIPTrunkConfig? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutboundSIPTrunkConfig? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPCredentials? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBody? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBody? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBody? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminator? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminatorType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBodyType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBodyType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateInboundSIPTrunkConfig? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateOutboundSIPTrunkConfig? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPCredentials? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricsResponse? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Metric>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Metric? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateMetricRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricResultsResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.MetricResult>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MetricResult? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentMetricResultStatus? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenGrant? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenderPresentation? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceExpandOptions? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetVoicesResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Voice>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Voice? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceStatus? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccess? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccentsItem? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceVisibility? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccent? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAccentsResponse? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Accent>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Accent? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SupportedLanguage? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadata? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataAccess? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataVisibility? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequest? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnumType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequest? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceAccent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum2? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnumType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AddVoiceAccentsRequest? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AttachVoiceAccent? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedPronunciationDicts? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDict? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictAccess? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictItem? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictVisibility? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequest? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum2? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnumType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequest? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnumType? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasets? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Dataset>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Dataset? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateDatasetRequest? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateDatasetRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasetFiles? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetFile? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilePurpose? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.File? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFiles? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.File>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFineTunes? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTune>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTune? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneStatus? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneUserError? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateFineTuneRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedVoices? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormatContainer? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageInterval? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsGroupBy? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBucket? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBreakdownSeries? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsResponse? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsBucket? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListApiKeysResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ApiKey>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKey? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUser? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUserRole? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListUsersBadRequestError? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UnexpectedErrorResponse? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetUserNotFoundError? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInvite? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteRole? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteStatus? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListInvitesBadRequestError? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateOrganizationInvitesRequest? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateInvitesBadRequestError? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetInviteNotFoundError? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TextChunk? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogEvent? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogMetric? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberSummary? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GitRepository? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSummary? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTemplate? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumber? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetTemplatesResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetAgentsResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateAgentRequest? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Deployment? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.S3UploadParamsResponse? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FlushDoneMessage? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DoneMessage? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ErrorMessage? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTBatchModel? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeModel? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeModel? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModel? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillModel? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneBaseModel? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelSpeed? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1Type? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2Type? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3Type? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4Type? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WordTimestamps? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5Type? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6Type? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhonemeTimestamps? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminator? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminatorType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketQueryParams? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommand? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommandType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketRequest? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnected? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnectedType? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStart? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStartType? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdate? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdateType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEndType? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResume? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResumeType? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEnd? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEndType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponse? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponseType? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponse? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParams? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponseType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponseType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponse? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponseType? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CancelContextRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEEvent? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEChunk? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEDone? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEError? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEErrorType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceLocale? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeTargetLanguage? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeEnglishDialect? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeFrenchDialect? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeSpanishDialect? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizePortugueseDialect? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeDialect? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Gender? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequest? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestModel? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestLanguage? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequest? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequestAccess? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileRequest? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadRequest? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequest? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequestModelId? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseRequest? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelsListCapability? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelsListCartesiaVersion? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsBytesCartesiaVersion? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsSseCartesiaVersion? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeCartesiaVersion? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsCartesiaVersion? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsCartesiaVersion? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsModelsCartesiaVersion? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsToolsCartesiaVersion? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsCartesiaVersion? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdExpandItem? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallsCartesiaVersion? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateOutboundCallCartesiaVersion? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallCartesiaVersion? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCallCartesiaVersion? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallCartesiaVersion? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDownloadCallAudioCartesiaVersion? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateCallBatchCartesiaVersion? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallBatchesCartesiaVersion? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallBatchCartesiaVersion? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallBatchCartesiaVersion? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRetryCallBatchCartesiaVersion? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListCartesiaVersion? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListType? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersImportCartesiaVersion? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersGetCartesiaVersion? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersUpdateCartesiaVersion? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersDeleteCartesiaVersion? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersProvisionCartesiaVersion? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListCartesiaVersion? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListType? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersCreateCartesiaVersion? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersGetCartesiaVersion? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersUpdateCartesiaVersion? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersDeleteCartesiaVersion? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricsCartesiaVersion? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateMetricCartesiaVersion? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetMetricCartesiaVersion? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteMetricCartesiaVersion? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricResultsCartesiaVersion? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsExportMetricResultsCartesiaVersion? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsAddMetricToAgentCartesiaVersion? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AuthAccessTokenCartesiaVersion? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesListCartesiaVersion? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AccentsListCartesiaVersion? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneCartesiaVersion? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteCartesiaVersion? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesUpdateCartesiaVersion? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesGetCartesiaVersion? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesLocalizeCartesiaVersion? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesAddAccentsCartesiaVersion? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteAccentCartesiaVersion? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsListCartesiaVersion? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsCreateCartesiaVersion? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsGetCartesiaVersion? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsUpdateCartesiaVersion? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsDeleteCartesiaVersion? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListCartesiaVersion? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsCreateCartesiaVersion? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsGetCartesiaVersion? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUpdateCartesiaVersion? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteCartesiaVersion? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListFilesCartesiaVersion? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileCartesiaVersion? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteFileCartesiaVersion? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadCartesiaVersion? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesListCartesiaVersion? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesGetCartesiaVersion? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDownloadCartesiaVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteCartesiaVersion? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListCartesiaVersion? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesCreateCartesiaVersion? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesGetCartesiaVersion? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesDeleteCartesiaVersion? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListVoicesCartesiaVersion? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesCartesiaVersion? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsCartesiaVersion? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsCartesiaVersion? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysListCartesiaVersion? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysGetCartesiaVersion? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersCartesiaVersion? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesStatus? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesCartesiaVersion? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostOrganizationsInvitesCartesiaVersion? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCartesiaVersion? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCartesiaVersion? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsUpdateCartesiaVersion? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCartesiaVersion? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsTemplatesCartesiaVersion? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsPhoneNumbersCartesiaVersion? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListDeploymentsCartesiaVersion? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetDeploymentCartesiaVersion? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesCartesiaVersion? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseCartesiaVersion? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallResponse? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListResponse? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteResponse? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersResponse? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Deployment>? Type651 { get; set; }

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
        public global::System.Collections.Generic.List<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentToolReferenceV1>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSummaryV1>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentVersionV1>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentModelV1>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.WebhookAssignment>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AnyOf<string, double?, bool?>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedToolV1>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCall>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentTranscript>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ToolCall>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.DynamicVariableUpdate>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItemResponse>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCallBatchRecipient>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCallBatch>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Metric>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.MetricResult>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Voice>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.VoiceAccentsItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Accent>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AttachVoiceAccent>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PronunciationDict>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PronunciationDictItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Dataset>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.DatasetFile>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.File>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.FineTune>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.FineTuneUserError>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UsageCreditsBucket>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UsageAgentsBucket>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ApiKey>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumberSummary>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentTemplate>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentSummary>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.WordTimestamps>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.TimestampGranularity>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.VoiceExpandOptions>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumberResponse>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ProviderAccountResponse>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OrganizationUser>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OrganizationInvite>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumber>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Deployment>? ListType52 { get; set; }
    }
}