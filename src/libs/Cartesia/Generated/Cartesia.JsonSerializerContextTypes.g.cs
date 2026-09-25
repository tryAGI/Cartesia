
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
        public global::Cartesia.TTSRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModelID? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifier? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormat? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationConfig? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WAVOutputFormat? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MP3OutputFormat? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawOutputFormat? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Emotion? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WAVOutputFormatContainer? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawEncoding? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MP3OutputFormatContainer? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.RawOutputFormatContainer? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSERequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SSEOutputFormat? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEvent? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEChunkEvent? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEvent? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEvent? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEDoneEvent? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEErrorEvent? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminator? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminatorType? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SSEOutputFormatContainer? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEChunkEventType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEventType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSETimestampsEventWordTimestamps? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEventType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEPhonemeTimestampsEventPhonemeTimestamps? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEDoneEventType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSSSEErrorEventType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTEncoding? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TimestampGranularity? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TranscriptionResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TranscriptionResponseType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TranscriptionWord>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TranscriptionWord? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1Request? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudio? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioInput? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutput? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentDynamicVariablePlaceholdersV1? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigLanguage? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentPrimaryLanguageV1? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigModel? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemTools? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCall? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentToolReferenceV1? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateManagedAgentV1RequestConfigTurn? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1Version? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, double?, bool?>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Audio? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInput? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutput? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Language? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Model? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Turn? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCall? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestination? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentsV1Response? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSummaryV1? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PublicErrorResponse? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1Request? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudio? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInput? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutput? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigLanguage? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigModel? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemTools? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigTurn? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentVersionsV1Response? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentVersionV1? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentModelsV1Response? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1Pricing? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1PricingCurrency? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1Discriminator? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1DiscriminatorType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1Discriminator? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Response? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAssignment? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1ExecutionMode? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1PreToolSpeech? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1Type? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1ExecutionMode? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1PreToolSpeech? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1Type? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1Type? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1Type? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParam? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQuerySchema? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParam? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeader? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParam? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1Type? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthentication? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Method? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecret? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1Mode? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2Mode? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParamType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParam? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParamType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponseType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeaderType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItems? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItemsType? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1Mode? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2Mode? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItems? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItemsType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedToolsV1Response? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1Request? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetCallsResponse? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCall>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCall? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTranscript? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParams? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallTelephonyAccountType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallStatus? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.EndReason? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ToolCall? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParamsConnectionType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DynamicVariableUpdate? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItem? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItemResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentDynamicVariableInputs? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequestRegion? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatch? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRegion? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchStatus? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRecipient? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAgentCallBatchesResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponse? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponseVariant2? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponseAgent? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminator? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminatorType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponseType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyRegion? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponseType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponseType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBody? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderById? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberBody? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBody? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderById? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponse? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminator? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminatorType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponseType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkInboundDetails? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkOutboundDetails? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPMediaEncryption? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkTransport? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBody? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBody? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBody? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminator? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminatorType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBodyType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBodyType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InboundSIPTrunkConfig? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutboundSIPTrunkConfig? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPCredentials? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBody? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBody? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBody? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminatorType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBodyType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBodyType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateInboundSIPTrunkConfig? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateOutboundSIPTrunkConfig? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPCredentials? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricsResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Metric>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Metric? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateMetricRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricResultsResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.MetricResult>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MetricResult? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentMetricResultStatus? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenGrant? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenderPresentation? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceExpandOptions? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetVoicesResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Voice>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Voice? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceStatus? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccess? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccentsItem? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceVisibility? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccent? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAccentsResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Accent>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Accent? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SupportedLanguage? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadata? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataAccess? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataVisibility? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum2? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnumType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequest? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceAccent? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum2? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnumType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AddVoiceAccentsRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AttachVoiceAccent? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedPronunciationDicts? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDict? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictAccess? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictItem? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictVisibility? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequest? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum2? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnumType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnumType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasets? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Dataset>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Dataset? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateDatasetRequest? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateDatasetRequest? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasetFiles? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetFile? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilePurpose? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.File? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFiles? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.File>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFineTunes? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTune>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTune? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneStatus? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneUserError? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateFineTuneRequest? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedVoices? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormatContainer? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageInterval? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsGroupBy? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsResponse? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBucket? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBreakdownSeries? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsResponse? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsBucket? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListApiKeysResponse? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ApiKey>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKey? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUser? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUserRole? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListUsersBadRequestError? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UnexpectedErrorResponse? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetUserNotFoundError? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInvite? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteRole? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteStatus? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListInvitesBadRequestError? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateOrganizationInvitesRequest? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateInvitesBadRequestError? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetInviteNotFoundError? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TextChunk? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogEvent? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogMetric? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberSummary? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GitRepository? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSummary? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTemplate? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumber? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetTemplatesResponse? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetAgentsResponse? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateAgentRequest? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Deployment? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.S3UploadParamsResponse? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FlushDoneMessage? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DoneMessage? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ErrorMessage? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTBatchModel? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeModel? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeModel? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModel? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneBaseModel? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelSpeed? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1Type? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2Type? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3Type? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4Type? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WordTimestamps? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5Type? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6Type? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhonemeTimestamps? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminator? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminatorType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketQueryParams? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommand? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommandType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnected? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnectedType? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStart? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStartType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdate? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdateType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEndType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResume? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResumeType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEnd? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEndType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponse? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponseType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponse? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParams? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponse? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponseType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponse? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponseType? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponseType? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponse? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CancelContextRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEEvent? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEChunk? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEDone? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEError? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEErrorType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceLocale? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeTargetLanguage? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeEnglishDialect? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeFrenchDialect? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeSpanishDialect? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizePortugueseDialect? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeDialect? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Gender? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestModel? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestLanguage? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequestAccess? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequestModelId? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseRequest? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsBytesCartesiaVersion? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsSseCartesiaVersion? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeCartesiaVersion? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsCartesiaVersion? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsCartesiaVersion? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsModelsCartesiaVersion? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsToolsCartesiaVersion? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsCartesiaVersion? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdExpandItem? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallsCartesiaVersion? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateOutboundCallCartesiaVersion? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallCartesiaVersion? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCallCartesiaVersion? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallCartesiaVersion? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDownloadCallAudioCartesiaVersion? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateCallBatchCartesiaVersion? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallBatchesCartesiaVersion? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallBatchCartesiaVersion? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallBatchCartesiaVersion? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRetryCallBatchCartesiaVersion? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListCartesiaVersion? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersImportCartesiaVersion? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersGetCartesiaVersion? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersUpdateCartesiaVersion? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersDeleteCartesiaVersion? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersProvisionCartesiaVersion? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListCartesiaVersion? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListType? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersCreateCartesiaVersion? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersGetCartesiaVersion? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersUpdateCartesiaVersion? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersDeleteCartesiaVersion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricsCartesiaVersion? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateMetricCartesiaVersion? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetMetricCartesiaVersion? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteMetricCartesiaVersion? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricResultsCartesiaVersion? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsExportMetricResultsCartesiaVersion? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsAddMetricToAgentCartesiaVersion? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AuthAccessTokenCartesiaVersion? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesListCartesiaVersion? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AccentsListCartesiaVersion? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneCartesiaVersion? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteCartesiaVersion? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesUpdateCartesiaVersion? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesGetCartesiaVersion? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesLocalizeCartesiaVersion? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesAddAccentsCartesiaVersion? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteAccentCartesiaVersion? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsListCartesiaVersion? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsCreateCartesiaVersion? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsGetCartesiaVersion? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsUpdateCartesiaVersion? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsDeleteCartesiaVersion? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListCartesiaVersion? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsCreateCartesiaVersion? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsGetCartesiaVersion? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUpdateCartesiaVersion? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteCartesiaVersion? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListFilesCartesiaVersion? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileCartesiaVersion? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteFileCartesiaVersion? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadCartesiaVersion? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesListCartesiaVersion? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesGetCartesiaVersion? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDownloadCartesiaVersion? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteCartesiaVersion? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListCartesiaVersion? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesCreateCartesiaVersion? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesGetCartesiaVersion? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesDeleteCartesiaVersion? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListVoicesCartesiaVersion? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesCartesiaVersion? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsCartesiaVersion? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsCartesiaVersion? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysListCartesiaVersion? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysGetCartesiaVersion? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersCartesiaVersion? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesStatus? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesCartesiaVersion? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostOrganizationsInvitesCartesiaVersion? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCartesiaVersion? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCartesiaVersion? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsUpdateCartesiaVersion? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCartesiaVersion? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsTemplatesCartesiaVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsPhoneNumbersCartesiaVersion? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListDeploymentsCartesiaVersion? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetDeploymentCartesiaVersion? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesCartesiaVersion? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseCartesiaVersion? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallResponse? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListResponse? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersResponse? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesResponse? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Deployment>? Type626 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.TranscriptionWord>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentToolReferenceV1>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSummaryV1>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentVersionV1>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedAgentModelV1>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.WebhookAssignment>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AnyOf<string, double?, bool?>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ManagedToolV1>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCall>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentTranscript>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ToolCall>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.DynamicVariableUpdate>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItemResponse>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCallBatchRecipient>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentCallBatch>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Metric>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.MetricResult>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Voice>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.VoiceAccentsItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Accent>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AttachVoiceAccent>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PronunciationDict>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PronunciationDictItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Dataset>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.DatasetFile>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.File>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.FineTune>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.FineTuneUserError>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UsageCreditsBucket>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.UsageAgentsBucket>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ApiKey>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumberSummary>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentTemplate>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.AgentSummary>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.WordTimestamps>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.TimestampGranularity>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.VoiceExpandOptions>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumberResponse>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.ProviderAccountResponse>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OrganizationUser>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.OrganizationInvite>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.PhoneNumber>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Deployment>? ListType50 { get; set; }
    }
}