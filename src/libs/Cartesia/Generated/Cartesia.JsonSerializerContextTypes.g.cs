
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
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentToolReferenceV1? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigTurn? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1Version? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, double?, bool?>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Auto? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1AutoType? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1ExplicitType? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Audio? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInput? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Language? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Model? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Turn? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCall? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestination? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentsV1Response? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSummaryV1? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PublicErrorResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1Request? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfig? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudio? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInput? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutput? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigLanguage? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigModel? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemTools? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigTurn? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentVersionsV1Response? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentVersionV1? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentModelsV1Response? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1Pricing? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1PricingCurrency? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1Discriminator? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1DiscriminatorType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1Discriminator? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Response? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAssignment? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1ExecutionMode? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1PreToolSpeech? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1Type? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1ExecutionMode? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1PreToolSpeech? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1Type? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1Type? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1Type? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParam? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQuerySchema? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParam? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeader? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParam? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1Type? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthentication? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Method? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecret? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1Mode? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2Mode? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParamType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParam? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParamType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponseType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeaderType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItems? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItemsType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1Mode? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2Mode? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItems? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItemsType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedToolsV1Response? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1Request? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetCallsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCall>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCall? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTranscript? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParams? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallTelephonyAccountType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallStatus? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.EndReason? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ToolCall? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParamsConnectionType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DynamicVariableUpdate? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItem? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItemResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentDynamicVariableInputs? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequestRegion? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatch? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRegion? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchStatus? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRecipient? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAgentCallBatchesResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponseVariant2? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponseAgent? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponse? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminator? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminatorType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponseType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyRegion? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponseType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponseType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBody? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderById? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberBody? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberResponse? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBody? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderById? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminator? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminatorType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponseType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkInboundDetails? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkOutboundDetails? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPMediaEncryption? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkTransport? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBody? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBody? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBody? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminator? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminatorType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBodyType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBodyType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InboundSIPTrunkConfig? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutboundSIPTrunkConfig? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPCredentials? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBody? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBody? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBody? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminator? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminatorType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBodyType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBodyType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateInboundSIPTrunkConfig? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateOutboundSIPTrunkConfig? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPCredentials? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricsResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Metric>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Metric? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateMetricRequest? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricResultsResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.MetricResult>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MetricResult? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentMetricResultStatus? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenGrant? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenderPresentation? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceExpandOptions? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetVoicesResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Voice>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Voice? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceStatus? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccess? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccentsItem? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceVisibility? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccent? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAccentsResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Accent>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Accent? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SupportedLanguage? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadata? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataAccess? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataVisibility? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum2? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnumType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceAccent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum2? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnumType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AddVoiceAccentsRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AttachVoiceAccent? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedPronunciationDicts? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDict? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictAccess? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictItem? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictVisibility? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum2? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnumType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequest? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum2? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnumType? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasets? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Dataset>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Dataset? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateDatasetRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateDatasetRequest? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasetFiles? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetFile? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilePurpose? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.File? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFiles? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.File>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFineTunes? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTune>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTune? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneStatus? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneUserError? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateFineTuneRequest? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedVoices? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormatContainer? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageInterval? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsGroupBy? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsResponse? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBucket? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBreakdownSeries? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsResponse? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsBucket? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListApiKeysResponse? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ApiKey>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKey? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUser? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUserRole? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListUsersBadRequestError? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UnexpectedErrorResponse? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetUserNotFoundError? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInvite? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteRole? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteStatus? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListInvitesBadRequestError? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateOrganizationInvitesRequest? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateInvitesBadRequestError? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetInviteNotFoundError? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TextChunk? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogEvent? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogMetric? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberSummary? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GitRepository? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSummary? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTemplate? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumber? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetTemplatesResponse? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetAgentsResponse? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateAgentRequest? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Deployment? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.S3UploadParamsResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FlushDoneMessage? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DoneMessage? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ErrorMessage? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTBatchModel? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeModel? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeModel? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModel? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillModel? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneBaseModel? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelSpeed? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponse? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1Type? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2Type? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3Type? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4Type? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WordTimestamps? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5Type? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6Type? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhonemeTimestamps? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminator? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminatorType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketQueryParams? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommand? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommandType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketRequest? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnected? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnectedType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStart? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStartType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdate? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdateType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEndType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResume? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResumeType? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEnd? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEndType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponse? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponseType? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParams? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponseType? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponseType? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponseType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CancelContextRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketRequest? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEEvent? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEChunk? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEDone? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEError? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEErrorType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceLocale? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeTargetLanguage? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeEnglishDialect? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeFrenchDialect? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeSpanishDialect? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizePortugueseDialect? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeDialect? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Gender? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequest? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestModel? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestLanguage? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequest? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequestAccess? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileRequest? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequestModelId? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesRequest? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseRequest? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelsListCapability? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelsListCartesiaVersion? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsBytesCartesiaVersion? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsSseCartesiaVersion? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeCartesiaVersion? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsCartesiaVersion? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsCartesiaVersion? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsModelsCartesiaVersion? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsToolsCartesiaVersion? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsCartesiaVersion? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdExpandItem? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallsCartesiaVersion? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateOutboundCallCartesiaVersion? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallCartesiaVersion? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCallCartesiaVersion? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallCartesiaVersion? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDownloadCallAudioCartesiaVersion? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateCallBatchCartesiaVersion? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallBatchesCartesiaVersion? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallBatchCartesiaVersion? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallBatchCartesiaVersion? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRetryCallBatchCartesiaVersion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListCartesiaVersion? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersImportCartesiaVersion? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersGetCartesiaVersion? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersUpdateCartesiaVersion? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersDeleteCartesiaVersion? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersProvisionCartesiaVersion? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListCartesiaVersion? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListType? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersCreateCartesiaVersion? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersGetCartesiaVersion? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersUpdateCartesiaVersion? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersDeleteCartesiaVersion? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricsCartesiaVersion? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateMetricCartesiaVersion? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetMetricCartesiaVersion? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteMetricCartesiaVersion? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricResultsCartesiaVersion? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsExportMetricResultsCartesiaVersion? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsAddMetricToAgentCartesiaVersion? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AuthAccessTokenCartesiaVersion? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesListCartesiaVersion? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AccentsListCartesiaVersion? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneCartesiaVersion? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteCartesiaVersion? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesUpdateCartesiaVersion? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesGetCartesiaVersion? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesLocalizeCartesiaVersion? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesAddAccentsCartesiaVersion? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteAccentCartesiaVersion? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsListCartesiaVersion? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsCreateCartesiaVersion? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsGetCartesiaVersion? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsUpdateCartesiaVersion? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsDeleteCartesiaVersion? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListCartesiaVersion? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsCreateCartesiaVersion? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsGetCartesiaVersion? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUpdateCartesiaVersion? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteCartesiaVersion? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListFilesCartesiaVersion? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileCartesiaVersion? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteFileCartesiaVersion? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadCartesiaVersion? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesListCartesiaVersion? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesGetCartesiaVersion? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDownloadCartesiaVersion? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteCartesiaVersion? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListCartesiaVersion? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesCreateCartesiaVersion? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesGetCartesiaVersion? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesDeleteCartesiaVersion? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListVoicesCartesiaVersion? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesCartesiaVersion? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsCartesiaVersion? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsCartesiaVersion? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysListCartesiaVersion? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysGetCartesiaVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersCartesiaVersion? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesStatus? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesCartesiaVersion? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostOrganizationsInvitesCartesiaVersion? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCartesiaVersion? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCartesiaVersion? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsUpdateCartesiaVersion? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCartesiaVersion? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsTemplatesCartesiaVersion? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsPhoneNumbersCartesiaVersion? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListDeploymentsCartesiaVersion? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetDeploymentCartesiaVersion? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesCartesiaVersion? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseCartesiaVersion? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallResponse? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListResponse? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteResponse? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersResponse? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesResponse? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Deployment>? Type639 { get; set; }

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