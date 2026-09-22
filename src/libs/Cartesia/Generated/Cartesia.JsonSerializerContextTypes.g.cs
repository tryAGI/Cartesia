
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
        public global::Cartesia.ManagedAgentV1? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentV1Version? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, double?, bool?>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Audio? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInput? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutput? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Language? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentConfigV1Model? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCall? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmf? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestination? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentsV1Response? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentSummaryV1? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PublicErrorResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1Request? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfig? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudio? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInput? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutput? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigLanguage? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigModel? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemTools? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentVersionsV1Response? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentVersionV1? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedAgentModelsV1Response? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1Pricing? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentModelV1PricingCurrency? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1Discriminator? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolV1DiscriminatorType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1Discriminator? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Response? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAssignment? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1ExecutionMode? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1PreToolSpeech? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolV1Type? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1ExecutionMode? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1PreToolSpeech? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolV1Type? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1Type? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1Type? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParam? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQuerySchema? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParam? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeader? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParam? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolParametersV1Type? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthentication? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookApiSchemaV1Method? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecret? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1Mode? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2Mode? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookPathParamType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParam? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookBodyParamType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretResponseType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookDynamicVariableHeaderType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItems? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamItemsType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ClientToolParamType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1Mode? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2Mode? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookSecretType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItems? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamItemsType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookQueryParamType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListManagedToolsV1Response? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1Request? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetCallsResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCall>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCall? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTranscript? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParams? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallTelephonyAccountType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallStatus? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.EndReason? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ToolCall>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ToolCall? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyParamsConnectionType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DynamicVariableUpdate? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItem? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentOutboundCallItemResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentDynamicVariableInputs? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRequestRegion? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatch? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRegion? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentCallBatchRecipient? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAgentCallBatchesResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponseVariant2? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponseAgent? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminatorType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponseType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TelephonyRegion? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponseType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponseType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBody? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderById? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberBody? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvisionPhoneNumberResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBody? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderById? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminator? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminatorType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponseType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkInboundDetails? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkOutboundDetails? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPMediaEncryption? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkTransport? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBody? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBody? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBody? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminator? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminatorType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBodyType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBodyType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InboundSIPTrunkConfig? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutboundSIPTrunkConfig? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPCredentials? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBody? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBody? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBody? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminator? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminatorType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBodyType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBodyType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateInboundSIPTrunkConfig? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateOutboundSIPTrunkConfig? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPCredentials? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricsResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Metric>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Metric? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateMetricRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListMetricResultsResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.MetricResult>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.MetricResult? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentMetricResultStatus? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenGrant? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TokenResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenderPresentation? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceExpandOptions? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetVoicesResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Voice>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Voice? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceStatus? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccess? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccentsItem? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceVisibility? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceAccent? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListAccentsResponse? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Accent>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Accent? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SupportedLanguage? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadata? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataAccess? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceMetadataVisibility? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnum2? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateVoiceRequestAccessEnumType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceAccent? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnum2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeVoiceRequestAccessEnumType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AddVoiceAccentsRequest? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AttachVoiceAccent? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedPronunciationDicts? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDict? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictAccess? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictItem? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictVisibility? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnum2? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreatePronunciationDictRequestAccessEnumType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequest? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnum2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdatePronunciationDictRequestAccessEnumType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasets? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Dataset>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Dataset? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateDatasetRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateDatasetRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedDatasetFiles? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetFile? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilePurpose? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.File? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFiles? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.File>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedFineTunes? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTune>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTune? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneStatus? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneUserError? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateFineTuneRequest? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PaginatedVoices? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OutputFormatContainer? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageInterval? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsGroupBy? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBucket? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsBreakdownSeries? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsResponse? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsBucket? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListApiKeysResponse? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ApiKey>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKey? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUser? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationUserRole? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListUsersBadRequestError? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UnexpectedErrorResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetUserNotFoundError? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInvite? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteRole? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.OrganizationInviteStatus? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ListInvitesBadRequestError? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateOrganizationInvitesRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateInvitesBadRequestError? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetInviteNotFoundError? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TextChunk? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogEvent? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LogMetric? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberSummary? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GitRepository? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentSummary? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentTemplate? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumber? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetTemplatesResponse? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetAgentsResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateAgentRequest? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Deployment? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.S3UploadParamsResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FlushDoneMessage? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DoneMessage? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ErrorMessage? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTBatchModel? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeModel? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeModel? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSModel? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillModel? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTuneBaseModel? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ModelSpeed? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponse? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant1Type? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant2Type? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant3Type? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant4Type? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WordTimestamps? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant5Type? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseVariant6Type? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhonemeTimestamps? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminator? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketResponseDiscriminatorType? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketQueryParams? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommand? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommandType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketRequest? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnected? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnectedType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStart? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStartType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdate? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdateType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEndType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResume? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResumeType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEnd? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEndType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponse? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTErrorResponseType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponse? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParams? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponse? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeTranscriptResponseType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponse? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeFlushDoneResponseType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponse? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeDoneResponseType? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponse? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CancelContextRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GenerationRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSWebSocketRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEEvent? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEChunk? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEDone? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEError? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSSEErrorType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceLocale? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeTargetLanguage? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeEnglishDialect? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeFrenchDialect? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeSpanishDialect? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizePortugueseDialect? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LocalizeDialect? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Gender? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequest? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestModel? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeRequestLanguage? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequest? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneRequestAccess? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesRequestModelId? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsBytesCartesiaVersion? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TtsSseCartesiaVersion? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SttTranscribeCartesiaVersion? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsCartesiaVersion? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsCartesiaVersion? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsModelsCartesiaVersion? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostV1AgentsToolsCartesiaVersion? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsCartesiaVersion? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdExpandItem? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallsCartesiaVersion? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateOutboundCallCartesiaVersion? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallCartesiaVersion? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCallCartesiaVersion? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallCartesiaVersion? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDownloadCallAudioCartesiaVersion? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateCallBatchCartesiaVersion? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCallBatchesCartesiaVersion? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCallBatchCartesiaVersion? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallBatchCartesiaVersion? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRetryCallBatchCartesiaVersion? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListCartesiaVersion? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersImportCartesiaVersion? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersGetCartesiaVersion? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersUpdateCartesiaVersion? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersDeleteCartesiaVersion? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersProvisionCartesiaVersion? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListCartesiaVersion? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersListType? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersCreateCartesiaVersion? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersGetCartesiaVersion? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersUpdateCartesiaVersion? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProvidersDeleteCartesiaVersion? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricsCartesiaVersion? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCreateMetricCartesiaVersion? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetMetricCartesiaVersion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteMetricCartesiaVersion? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListMetricResultsCartesiaVersion? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsExportMetricResultsCartesiaVersion? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsAddMetricToAgentCartesiaVersion? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AuthAccessTokenCartesiaVersion? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesListCartesiaVersion? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AccentsListCartesiaVersion? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesCloneCartesiaVersion? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteCartesiaVersion? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesUpdateCartesiaVersion? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesGetCartesiaVersion? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesLocalizeCartesiaVersion? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesAddAccentsCartesiaVersion? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoicesDeleteAccentCartesiaVersion? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsListCartesiaVersion? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsCreateCartesiaVersion? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsGetCartesiaVersion? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsUpdateCartesiaVersion? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PronunciationDictsDeleteCartesiaVersion? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListCartesiaVersion? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsCreateCartesiaVersion? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsGetCartesiaVersion? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUpdateCartesiaVersion? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteCartesiaVersion? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsListFilesCartesiaVersion? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsUploadFileCartesiaVersion? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DatasetsDeleteFileCartesiaVersion? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesUploadCartesiaVersion? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesListCartesiaVersion? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesGetCartesiaVersion? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDownloadCartesiaVersion? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteCartesiaVersion? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListCartesiaVersion? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesCreateCartesiaVersion? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesGetCartesiaVersion? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesDeleteCartesiaVersion? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FineTunesListVoicesCartesiaVersion? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.InfillBytesCartesiaVersion? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageCreditsCartesiaVersion? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UsageAgentsCartesiaVersion? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysListCartesiaVersion? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ApiKeysGetCartesiaVersion? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersCartesiaVersion? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesStatus? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesCartesiaVersion? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PostOrganizationsInvitesCartesiaVersion? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListCartesiaVersion? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetCartesiaVersion? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsUpdateCartesiaVersion? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsDeleteCartesiaVersion? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsTemplatesCartesiaVersion? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsPhoneNumbersCartesiaVersion? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsListDeploymentsCartesiaVersion? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsGetDeploymentCartesiaVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerBytesCartesiaVersion? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.VoiceChangerSseCartesiaVersion? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.AgentsCancelCallResponse? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumbersListResponse? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.FilesDeleteResponse? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsUsersResponse? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.GetOrganizationsInvitesResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Deployment>? Type623 { get; set; }

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