
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.APIInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSModelID), TypeInfoPropertyName = "TTSModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifier), TypeInfoPropertyName = "TTSRequestVoiceSpecifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Emotion), TypeInfoPropertyName = "Emotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormatContainer), TypeInfoPropertyName = "WAVOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding), TypeInfoPropertyName = "RawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormatContainer), TypeInfoPropertyName = "MP3OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormatContainer), TypeInfoPropertyName = "RawOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSERequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEvent), TypeInfoPropertyName = "TTSSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEventDiscriminatorType), TypeInfoPropertyName = "TTSSSEEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormatContainer), TypeInfoPropertyName = "SSEOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEventType), TypeInfoPropertyName = "TTSSSEChunkEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventType), TypeInfoPropertyName = "TTSSSETimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventWordTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType), TypeInfoPropertyName = "TTSSSEPhonemeTimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventPhonemeTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEventType), TypeInfoPropertyName = "TTSSSEDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEventType), TypeInfoPropertyName = "TTSSSEErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTEncoding), TypeInfoPropertyName = "STTEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TimestampGranularity), TypeInfoPropertyName = "TimestampGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptionResponseType), TypeInfoPropertyName = "TranscriptionResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression), TypeInfoPropertyName = "CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentDynamicVariablePlaceholdersV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1), TypeInfoPropertyName = "ManagedAgentPrimaryLanguageV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech), TypeInfoPropertyName = "CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmf))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech), TypeInfoPropertyName = "CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech), TypeInfoPropertyName = "CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType), TypeInfoPropertyName = "CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentToolReferenceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentV1Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, double?, bool?>), TypeInfoPropertyName = "AnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression), TypeInfoPropertyName = "ManagedAgentConfigV1AudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Language))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Turn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech), TypeInfoPropertyName = "ManagedAgentSystemToolsV1EndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmf))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech), TypeInfoPropertyName = "ManagedAgentSystemToolsV1SendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech), TypeInfoPropertyName = "ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType), TypeInfoPropertyName = "ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedAgentsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PublicErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression), TypeInfoPropertyName = "UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioOutputBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech), TypeInfoPropertyName = "UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmf))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech), TypeInfoPropertyName = "UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech), TypeInfoPropertyName = "UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType), TypeInfoPropertyName = "UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedAgentVersionsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentVersionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedAgentModelsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1Pricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency), TypeInfoPropertyName = "ManagedAgentModelV1PricingCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1), TypeInfoPropertyName = "ManagedToolDefinitionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1), TypeInfoPropertyName = "ManagedToolV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1DiscriminatorType), TypeInfoPropertyName = "ManagedToolV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType), TypeInfoPropertyName = "ManagedToolDefinitionV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.WebhookAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode), TypeInfoPropertyName = "ManagedWebhookToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech), TypeInfoPropertyName = "ManagedWebhookToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1Type), TypeInfoPropertyName = "ManagedWebhookToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1ExecutionMode), TypeInfoPropertyName = "ManagedClientToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolParametersV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech), TypeInfoPropertyName = "ManagedClientToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1Type), TypeInfoPropertyName = "ManagedClientToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode), TypeInfoPropertyName = "ManagedWebhookToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech), TypeInfoPropertyName = "ManagedWebhookToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type), TypeInfoPropertyName = "ManagedWebhookToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode), TypeInfoPropertyName = "ManagedClientToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech), TypeInfoPropertyName = "ManagedClientToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1Type), TypeInfoPropertyName = "ManagedClientToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponse), TypeInfoPropertyName = "WebhookAuthenticationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod), TypeInfoPropertyName = "ManagedWebhookApiSchemaV1ResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookPathParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQuerySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookBodyParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>), TypeInfoPropertyName = "AnyOfStringWebhookSecretResponseWebhookDynamicVariableHeader2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookDynamicVariableHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolParametersV1Type), TypeInfoPropertyName = "ManagedClientToolParametersV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthentication), TypeInfoPropertyName = "WebhookAuthentication2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method), TypeInfoPropertyName = "ManagedWebhookApiSchemaV1Method2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>), TypeInfoPropertyName = "AnyOfStringWebhookSecretWebhookDynamicVariableHeader2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode), TypeInfoPropertyName = "WebhookAuthenticationResponseVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode), TypeInfoPropertyName = "WebhookAuthenticationResponseVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookPathParamType), TypeInfoPropertyName = "WebhookPathParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookBodyParamType), TypeInfoPropertyName = "WebhookBodyParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretResponseType), TypeInfoPropertyName = "WebhookSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookDynamicVariableHeaderType), TypeInfoPropertyName = "WebhookDynamicVariableHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamItemsType), TypeInfoPropertyName = "ClientToolParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamType), TypeInfoPropertyName = "ClientToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant1Mode), TypeInfoPropertyName = "WebhookAuthenticationVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant2Mode), TypeInfoPropertyName = "WebhookAuthenticationVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretType), TypeInfoPropertyName = "WebhookSecretType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamItemsType), TypeInfoPropertyName = "WebhookQueryParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamType), TypeInfoPropertyName = "WebhookQueryParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedToolsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1Request), TypeInfoPropertyName = "UpdateManagedToolV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod), TypeInfoPropertyName = "UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode), TypeInfoPropertyName = "UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech), TypeInfoPropertyName = "UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode), TypeInfoPropertyName = "UpdateManagedToolV1RequestClientToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech), TypeInfoPropertyName = "UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallTelephonyAccountType), TypeInfoPropertyName = "AgentCallTelephonyAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallStatus), TypeInfoPropertyName = "AgentCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.EndReason), TypeInfoPropertyName = "EndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyParamsConnectionType), TypeInfoPropertyName = "TelephonyParamsConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.DynamicVariableUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DynamicVariableUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentDynamicVariableInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRequestRegion), TypeInfoPropertyName = "AgentCallBatchRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRegion), TypeInfoPropertyName = "AgentCallBatchRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchStatus), TypeInfoPropertyName = "AgentCallBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListAgentCallBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberResponse), TypeInfoPropertyName = "PhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponse), TypeInfoPropertyName = "ProviderResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberBaseResponseAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CartesiaProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkEmbeddedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponseDiscriminatorType), TypeInfoPropertyName = "ProviderResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponseType), TypeInfoPropertyName = "TwilioProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyRegion), TypeInfoPropertyName = "TelephonyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CartesiaProviderResponseType), TypeInfoPropertyName = "CartesiaProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkEmbeddedResponseType), TypeInfoPropertyName = "SIPTrunkEmbeddedResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>), TypeInfoPropertyName = "OneOfImportPhoneNumberBodyProviderByIdImportPhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType), TypeInfoPropertyName = "ImportPhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvisionPhoneNumberBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvisionPhoneNumberResponse), TypeInfoPropertyName = "ProvisionPhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>), TypeInfoPropertyName = "OneOfUpdatePhoneNumberBodyProviderByIdUpdatePhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType), TypeInfoPropertyName = "UpdatePhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponse), TypeInfoPropertyName = "ProviderAccountResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType), TypeInfoPropertyName = "ProviderAccountResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkProviderResponseType), TypeInfoPropertyName = "SIPTrunkProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkInboundDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkOutboundDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPMediaEncryption), TypeInfoPropertyName = "SIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkTransport), TypeInfoPropertyName = "SIPTrunkTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBody), TypeInfoPropertyName = "CreateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateTwilioProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateSIPProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBodyDiscriminatorType), TypeInfoPropertyName = "CreateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateTwilioProviderBodyType), TypeInfoPropertyName = "CreateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateSIPProviderBodyType), TypeInfoPropertyName = "CreateSIPProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBody), TypeInfoPropertyName = "UpdateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateTwilioProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPTrunkProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType), TypeInfoPropertyName = "UpdateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateTwilioProviderBodyType), TypeInfoPropertyName = "UpdateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType), TypeInfoPropertyName = "UpdateSIPTrunkProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateInboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateOutboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Metric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Metric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateMetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListMetricResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentMetricResultStatus), TypeInfoPropertyName = "AgentMetricResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TokenGrant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation), TypeInfoPropertyName = "GenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceExpandOptions), TypeInfoPropertyName = "VoiceExpandOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceStatus), TypeInfoPropertyName = "VoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccess), TypeInfoPropertyName = "VoiceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccentsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceVisibility), TypeInfoPropertyName = "VoiceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccent), TypeInfoPropertyName = "VoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListAccentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Accent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Accent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataAccess), TypeInfoPropertyName = "VoiceMetadataAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataVisibility), TypeInfoPropertyName = "VoiceMetadataVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>), TypeInfoPropertyName = "OneOfUpdateVoiceRequestAccessEnumUpdateVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnum), TypeInfoPropertyName = "UpdateVoiceRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType), TypeInfoPropertyName = "UpdateVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceAccent), TypeInfoPropertyName = "LocalizeVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>), TypeInfoPropertyName = "OneOfLocalizeVoiceRequestAccessEnumLocalizeVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum), TypeInfoPropertyName = "LocalizeVoiceRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType), TypeInfoPropertyName = "LocalizeVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AddVoiceAccentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AttachVoiceAccent), TypeInfoPropertyName = "AttachVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedPronunciationDicts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictAccess), TypeInfoPropertyName = "PronunciationDictAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictVisibility), TypeInfoPropertyName = "PronunciationDictVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>), TypeInfoPropertyName = "OneOfCreatePronunciationDictRequestAccessEnumCreatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum), TypeInfoPropertyName = "CreatePronunciationDictRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType), TypeInfoPropertyName = "CreatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>), TypeInfoPropertyName = "OneOfUpdatePronunciationDictRequestAccessEnumUpdatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum), TypeInfoPropertyName = "UpdatePronunciationDictRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType), TypeInfoPropertyName = "UpdatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedDatasetFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilePurpose), TypeInfoPropertyName = "FilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedFineTunes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.FineTune>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTune))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneStatus), TypeInfoPropertyName = "FineTuneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneUserError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateFineTuneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedVoices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer), TypeInfoPropertyName = "OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageInterval), TypeInfoPropertyName = "UsageInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsGroupBy), TypeInfoPropertyName = "UsageCreditsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>), TypeInfoPropertyName = "OneOfUsageCreditsBucketUsageCreditsBreakdownSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsBreakdownSeries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationUserRole), TypeInfoPropertyName = "OrganizationUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListUsersBadRequestError), TypeInfoPropertyName = "ListUsersBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UnexpectedErrorResponse), TypeInfoPropertyName = "UnexpectedErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetUserNotFoundError), TypeInfoPropertyName = "GetUserNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteRole), TypeInfoPropertyName = "OrganizationInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteStatus), TypeInfoPropertyName = "OrganizationInviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListInvitesBadRequestError), TypeInfoPropertyName = "ListInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateOrganizationInvitesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateInvitesBadRequestError), TypeInfoPropertyName = "CreateInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetInviteNotFoundError), TypeInfoPropertyName = "GetInviteNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LogEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LogMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GitRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Deployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.S3UploadParamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FlushDoneMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DoneMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTBatchModel), TypeInfoPropertyName = "STTBatchModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeModel), TypeInfoPropertyName = "STTAutoFinalizeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeModel), TypeInfoPropertyName = "STTManualFinalizeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSModel), TypeInfoPropertyName = "TTSModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillModel), TypeInfoPropertyName = "InfillModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneBaseModel), TypeInfoPropertyName = "FineTuneBaseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ModelSpeed), TypeInfoPropertyName = "ModelSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponse), TypeInfoPropertyName = "TTSWebSocketResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant1Type), TypeInfoPropertyName = "TTSWebSocketResponseVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant2Type), TypeInfoPropertyName = "TTSWebSocketResponseVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant3Type), TypeInfoPropertyName = "TTSWebSocketResponseVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant4Type), TypeInfoPropertyName = "TTSWebSocketResponseVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WordTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant5Type), TypeInfoPropertyName = "TTSWebSocketResponseVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant6Type), TypeInfoPropertyName = "TTSWebSocketResponseVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhonemeTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseDiscriminatorType), TypeInfoPropertyName = "TTSWebSocketResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeCloseCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeCloseCommandType), TypeInfoPropertyName = "STTAutoFinalizeCloseCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketRequest), TypeInfoPropertyName = "STTAutoFinalizeWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeConnected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeConnectedType), TypeInfoPropertyName = "STTAutoFinalizeConnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnStartType), TypeInfoPropertyName = "STTAutoFinalizeTurnStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnUpdateType), TypeInfoPropertyName = "STTAutoFinalizeTurnUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnEagerEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnEagerEndType), TypeInfoPropertyName = "STTAutoFinalizeTurnEagerEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnResume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnResumeType), TypeInfoPropertyName = "STTAutoFinalizeTurnResumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnEndType), TypeInfoPropertyName = "STTAutoFinalizeTurnEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTErrorResponseType), TypeInfoPropertyName = "STTErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketResponse), TypeInfoPropertyName = "STTAutoFinalizeWebSocketResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType), TypeInfoPropertyName = "STTAutoFinalizeWebSocketResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage), TypeInfoPropertyName = "STTManualFinalizeWebSocketQueryParamsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketRequest), TypeInfoPropertyName = "STTManualFinalizeWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeTranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeTranscriptResponseType), TypeInfoPropertyName = "STTManualFinalizeTranscriptResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.WordTimestamps>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeFlushDoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeFlushDoneResponseType), TypeInfoPropertyName = "STTManualFinalizeFlushDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeDoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeDoneResponseType), TypeInfoPropertyName = "STTManualFinalizeDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketResponse), TypeInfoPropertyName = "STTManualFinalizeWebSocketResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType), TypeInfoPropertyName = "STTManualFinalizeWebSocketResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CancelContextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketRequest), TypeInfoPropertyName = "TTSWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEEvent), TypeInfoPropertyName = "VoiceChangerSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEErrorType), TypeInfoPropertyName = "VoiceChangerSSEErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeTargetLanguage), TypeInfoPropertyName = "LocalizeTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeEnglishDialect), TypeInfoPropertyName = "LocalizeEnglishDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeFrenchDialect), TypeInfoPropertyName = "LocalizeFrenchDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeSpanishDialect), TypeInfoPropertyName = "LocalizeSpanishDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizePortugueseDialect), TypeInfoPropertyName = "LocalizePortugueseDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeDialect), TypeInfoPropertyName = "LocalizeDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Gender), TypeInfoPropertyName = "Gender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequestModel), TypeInfoPropertyName = "SttTranscribeRequestModel2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequestLanguage), TypeInfoPropertyName = "SttTranscribeRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequestAccess), TypeInfoPropertyName = "VoicesCloneRequestAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequestModelId), TypeInfoPropertyName = "InfillBytesRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsBytesCartesiaVersion), TypeInfoPropertyName = "TtsBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsSseCartesiaVersion), TypeInfoPropertyName = "TtsSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeCartesiaVersion), TypeInfoPropertyName = "SttTranscribeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsCartesiaVersion), TypeInfoPropertyName = "PostV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion), TypeInfoPropertyName = "PatchV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion), TypeInfoPropertyName = "DeleteV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsByAgentIdVersionsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsModelsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion), TypeInfoPropertyName = "PostV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsType), TypeInfoPropertyName = "GetV1AgentsToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem), TypeInfoPropertyName = "GetV1AgentsToolsByToolIdExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion), TypeInfoPropertyName = "PatchV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion), TypeInfoPropertyName = "DeleteV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCallsCartesiaVersion), TypeInfoPropertyName = "AgentsListCallsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateOutboundCallCartesiaVersion), TypeInfoPropertyName = "AgentsCreateOutboundCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCallCartesiaVersion), TypeInfoPropertyName = "AgentsGetCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCallCartesiaVersion), TypeInfoPropertyName = "AgentsDeleteCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCancelCallCartesiaVersion), TypeInfoPropertyName = "AgentsCancelCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion), TypeInfoPropertyName = "AgentsDownloadCallAudioCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateCallBatchCartesiaVersion), TypeInfoPropertyName = "AgentsCreateCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCallBatchesCartesiaVersion), TypeInfoPropertyName = "AgentsListCallBatchesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCallBatchCartesiaVersion), TypeInfoPropertyName = "AgentsGetCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCancelCallBatchCartesiaVersion), TypeInfoPropertyName = "AgentsCancelCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRetryCallBatchCartesiaVersion), TypeInfoPropertyName = "AgentsRetryCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListType), TypeInfoPropertyName = "PhoneNumbersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersImportCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersProvisionCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListCartesiaVersion), TypeInfoPropertyName = "ProvidersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListType), TypeInfoPropertyName = "ProvidersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersCreateCartesiaVersion), TypeInfoPropertyName = "ProvidersCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersGetCartesiaVersion), TypeInfoPropertyName = "ProvidersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersUpdateCartesiaVersion), TypeInfoPropertyName = "ProvidersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersDeleteCartesiaVersion), TypeInfoPropertyName = "ProvidersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricsCartesiaVersion), TypeInfoPropertyName = "AgentsListMetricsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion), TypeInfoPropertyName = "AgentsCreateMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetMetricCartesiaVersion), TypeInfoPropertyName = "AgentsGetMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion), TypeInfoPropertyName = "AgentsDeleteMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion), TypeInfoPropertyName = "AgentsListMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion), TypeInfoPropertyName = "AgentsExportMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion), TypeInfoPropertyName = "AgentsAddMetricToAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion), TypeInfoPropertyName = "AgentsRemoveMetricFromAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AuthAccessTokenCartesiaVersion), TypeInfoPropertyName = "AuthAccessTokenCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesListCartesiaVersion), TypeInfoPropertyName = "VoicesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AccentsListCartesiaVersion), TypeInfoPropertyName = "AccentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneCartesiaVersion), TypeInfoPropertyName = "VoicesCloneCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteCartesiaVersion), TypeInfoPropertyName = "VoicesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesUpdateCartesiaVersion), TypeInfoPropertyName = "VoicesUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesGetCartesiaVersion), TypeInfoPropertyName = "VoicesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesLocalizeCartesiaVersion), TypeInfoPropertyName = "VoicesLocalizeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion), TypeInfoPropertyName = "VoicesAddAccentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion), TypeInfoPropertyName = "VoicesDeleteAccentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsListCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListCartesiaVersion), TypeInfoPropertyName = "DatasetsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsCreateCartesiaVersion), TypeInfoPropertyName = "DatasetsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsGetCartesiaVersion), TypeInfoPropertyName = "DatasetsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUpdateCartesiaVersion), TypeInfoPropertyName = "DatasetsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteCartesiaVersion), TypeInfoPropertyName = "DatasetsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListFilesCartesiaVersion), TypeInfoPropertyName = "DatasetsListFilesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion), TypeInfoPropertyName = "DatasetsUploadFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion), TypeInfoPropertyName = "DatasetsDeleteFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesUploadCartesiaVersion), TypeInfoPropertyName = "FilesUploadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesListCartesiaVersion), TypeInfoPropertyName = "FilesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesGetCartesiaVersion), TypeInfoPropertyName = "FilesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDownloadCartesiaVersion), TypeInfoPropertyName = "FilesDownloadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDeleteCartesiaVersion), TypeInfoPropertyName = "FilesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListCartesiaVersion), TypeInfoPropertyName = "FineTunesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesCreateCartesiaVersion), TypeInfoPropertyName = "FineTunesCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesGetCartesiaVersion), TypeInfoPropertyName = "FineTunesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesDeleteCartesiaVersion), TypeInfoPropertyName = "FineTunesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion), TypeInfoPropertyName = "FineTunesListVoicesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesCartesiaVersion), TypeInfoPropertyName = "InfillBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsCartesiaVersion), TypeInfoPropertyName = "UsageCreditsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsCartesiaVersion), TypeInfoPropertyName = "UsageAgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ApiKeysListCartesiaVersion), TypeInfoPropertyName = "ApiKeysListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ApiKeysGetCartesiaVersion), TypeInfoPropertyName = "ApiKeysGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsUsersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion), TypeInfoPropertyName = "DeleteOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesStatus), TypeInfoPropertyName = "GetOrganizationsInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion), TypeInfoPropertyName = "PostOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion), TypeInfoPropertyName = "DeleteOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCartesiaVersion), TypeInfoPropertyName = "AgentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCartesiaVersion), TypeInfoPropertyName = "AgentsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsUpdateCartesiaVersion), TypeInfoPropertyName = "AgentsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCartesiaVersion), TypeInfoPropertyName = "AgentsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsTemplatesCartesiaVersion), TypeInfoPropertyName = "AgentsTemplatesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion), TypeInfoPropertyName = "AgentsPhoneNumbersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion), TypeInfoPropertyName = "AgentsListDeploymentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion), TypeInfoPropertyName = "AgentsGetDeploymentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion), TypeInfoPropertyName = "VoiceChangerBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseCartesiaVersion), TypeInfoPropertyName = "VoiceChangerSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCancelCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Deployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSModelID?), TypeInfoPropertyName = "NullableTTSModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifier?), TypeInfoPropertyName = "NullableTTSRequestVoiceSpecifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormat?), TypeInfoPropertyName = "NullableOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Emotion?), TypeInfoPropertyName = "NullableEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormatContainer?), TypeInfoPropertyName = "NullableWAVOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding?), TypeInfoPropertyName = "NullableRawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormatContainer?), TypeInfoPropertyName = "NullableMP3OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormatContainer?), TypeInfoPropertyName = "NullableRawOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEvent?), TypeInfoPropertyName = "NullableTTSSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEventDiscriminatorType?), TypeInfoPropertyName = "NullableTTSSSEEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormatContainer?), TypeInfoPropertyName = "NullableSSEOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEventType?), TypeInfoPropertyName = "NullableTTSSSEChunkEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventType?), TypeInfoPropertyName = "NullableTTSSSETimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType?), TypeInfoPropertyName = "NullableTTSSSEPhonemeTimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEventType?), TypeInfoPropertyName = "NullableTTSSSEDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEventType?), TypeInfoPropertyName = "NullableTTSSSEErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTEncoding?), TypeInfoPropertyName = "NullableSTTEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TimestampGranularity?), TypeInfoPropertyName = "NullableTimestampGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptionResponseType?), TypeInfoPropertyName = "NullableTranscriptionResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigAudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1?), TypeInfoPropertyName = "NullableManagedAgentPrimaryLanguageV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression?), TypeInfoPropertyName = "NullableManagedAgentConfigV1AudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech?), TypeInfoPropertyName = "NullableManagedAgentSystemToolsV1EndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech?), TypeInfoPropertyName = "NullableManagedAgentSystemToolsV1SendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech?), TypeInfoPropertyName = "NullableManagedAgentSystemToolsV1TransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType?), TypeInfoPropertyName = "NullableManagedAgentSystemToolsV1TransferToNumberTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression?), TypeInfoPropertyName = "NullableUpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?), TypeInfoPropertyName = "NullableUpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency?), TypeInfoPropertyName = "NullableManagedAgentModelV1PricingCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1?), TypeInfoPropertyName = "NullableManagedToolDefinitionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1?), TypeInfoPropertyName = "NullableManagedToolV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1DiscriminatorType?), TypeInfoPropertyName = "NullableManagedToolV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType?), TypeInfoPropertyName = "NullableManagedToolDefinitionV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedWebhookToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedWebhookToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1Type?), TypeInfoPropertyName = "NullableManagedWebhookToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedClientToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedClientToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1Type?), TypeInfoPropertyName = "NullableManagedClientToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedWebhookToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedWebhookToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type?), TypeInfoPropertyName = "NullableManagedWebhookToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedClientToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedClientToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1Type?), TypeInfoPropertyName = "NullableManagedClientToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponse?), TypeInfoPropertyName = "NullableWebhookAuthenticationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod?), TypeInfoPropertyName = "NullableManagedWebhookApiSchemaV1ResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>?), TypeInfoPropertyName = "NullableAnyOfStringWebhookSecretResponseWebhookDynamicVariableHeader2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolParametersV1Type?), TypeInfoPropertyName = "NullableManagedClientToolParametersV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthentication?), TypeInfoPropertyName = "NullableWebhookAuthentication2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method?), TypeInfoPropertyName = "NullableManagedWebhookApiSchemaV1Method2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>?), TypeInfoPropertyName = "NullableAnyOfStringWebhookSecretWebhookDynamicVariableHeader2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationResponseVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationResponseVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookPathParamType?), TypeInfoPropertyName = "NullableWebhookPathParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookBodyParamType?), TypeInfoPropertyName = "NullableWebhookBodyParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretResponseType?), TypeInfoPropertyName = "NullableWebhookSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookDynamicVariableHeaderType?), TypeInfoPropertyName = "NullableWebhookDynamicVariableHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamItemsType?), TypeInfoPropertyName = "NullableClientToolParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamType?), TypeInfoPropertyName = "NullableClientToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant1Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant2Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretType?), TypeInfoPropertyName = "NullableWebhookSecretType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamItemsType?), TypeInfoPropertyName = "NullableWebhookQueryParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamType?), TypeInfoPropertyName = "NullableWebhookQueryParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1Request?), TypeInfoPropertyName = "NullableUpdateManagedToolV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestWebhookToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestClientToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestClientToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallTelephonyAccountType?), TypeInfoPropertyName = "NullableAgentCallTelephonyAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallStatus?), TypeInfoPropertyName = "NullableAgentCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.EndReason?), TypeInfoPropertyName = "NullableEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyParamsConnectionType?), TypeInfoPropertyName = "NullableTelephonyParamsConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRequestRegion?), TypeInfoPropertyName = "NullableAgentCallBatchRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRegion?), TypeInfoPropertyName = "NullableAgentCallBatchRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchStatus?), TypeInfoPropertyName = "NullableAgentCallBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberResponse?), TypeInfoPropertyName = "NullablePhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponse?), TypeInfoPropertyName = "NullableProviderResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponseDiscriminatorType?), TypeInfoPropertyName = "NullableProviderResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponseType?), TypeInfoPropertyName = "NullableTwilioProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyRegion?), TypeInfoPropertyName = "NullableTelephonyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CartesiaProviderResponseType?), TypeInfoPropertyName = "NullableCartesiaProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkEmbeddedResponseType?), TypeInfoPropertyName = "NullableSIPTrunkEmbeddedResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>?), TypeInfoPropertyName = "NullableOneOfImportPhoneNumberBodyProviderByIdImportPhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType?), TypeInfoPropertyName = "NullableImportPhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvisionPhoneNumberResponse?), TypeInfoPropertyName = "NullableProvisionPhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>?), TypeInfoPropertyName = "NullableOneOfUpdatePhoneNumberBodyProviderByIdUpdatePhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType?), TypeInfoPropertyName = "NullableUpdatePhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponse?), TypeInfoPropertyName = "NullableProviderAccountResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType?), TypeInfoPropertyName = "NullableProviderAccountResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkProviderResponseType?), TypeInfoPropertyName = "NullableSIPTrunkProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPMediaEncryption?), TypeInfoPropertyName = "NullableSIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkTransport?), TypeInfoPropertyName = "NullableSIPTrunkTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBody?), TypeInfoPropertyName = "NullableCreateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBodyDiscriminatorType?), TypeInfoPropertyName = "NullableCreateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateTwilioProviderBodyType?), TypeInfoPropertyName = "NullableCreateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateSIPProviderBodyType?), TypeInfoPropertyName = "NullableCreateSIPProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBody?), TypeInfoPropertyName = "NullableUpdateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateTwilioProviderBodyType?), TypeInfoPropertyName = "NullableUpdateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType?), TypeInfoPropertyName = "NullableUpdateSIPTrunkProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentMetricResultStatus?), TypeInfoPropertyName = "NullableAgentMetricResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation?), TypeInfoPropertyName = "NullableGenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceExpandOptions?), TypeInfoPropertyName = "NullableVoiceExpandOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceStatus?), TypeInfoPropertyName = "NullableVoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccess?), TypeInfoPropertyName = "NullableVoiceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceVisibility?), TypeInfoPropertyName = "NullableVoiceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccent?), TypeInfoPropertyName = "NullableVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage?), TypeInfoPropertyName = "NullableSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataAccess?), TypeInfoPropertyName = "NullableVoiceMetadataAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataVisibility?), TypeInfoPropertyName = "NullableVoiceMetadataVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfUpdateVoiceRequestAccessEnumUpdateVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnum?), TypeInfoPropertyName = "NullableUpdateVoiceRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType?), TypeInfoPropertyName = "NullableUpdateVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceAccent?), TypeInfoPropertyName = "NullableLocalizeVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfLocalizeVoiceRequestAccessEnumLocalizeVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum?), TypeInfoPropertyName = "NullableLocalizeVoiceRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType?), TypeInfoPropertyName = "NullableLocalizeVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AttachVoiceAccent?), TypeInfoPropertyName = "NullableAttachVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictAccess?), TypeInfoPropertyName = "NullablePronunciationDictAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictVisibility?), TypeInfoPropertyName = "NullablePronunciationDictVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfCreatePronunciationDictRequestAccessEnumCreatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum?), TypeInfoPropertyName = "NullableCreatePronunciationDictRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType?), TypeInfoPropertyName = "NullableCreatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfUpdatePronunciationDictRequestAccessEnumUpdatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum?), TypeInfoPropertyName = "NullableUpdatePronunciationDictRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType?), TypeInfoPropertyName = "NullableUpdatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilePurpose?), TypeInfoPropertyName = "NullableFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneStatus?), TypeInfoPropertyName = "NullableFineTuneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer?), TypeInfoPropertyName = "NullableOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageInterval?), TypeInfoPropertyName = "NullableUsageInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsGroupBy?), TypeInfoPropertyName = "NullableUsageCreditsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>?), TypeInfoPropertyName = "NullableOneOfUsageCreditsBucketUsageCreditsBreakdownSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationUserRole?), TypeInfoPropertyName = "NullableOrganizationUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListUsersBadRequestError?), TypeInfoPropertyName = "NullableListUsersBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UnexpectedErrorResponse?), TypeInfoPropertyName = "NullableUnexpectedErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetUserNotFoundError?), TypeInfoPropertyName = "NullableGetUserNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteRole?), TypeInfoPropertyName = "NullableOrganizationInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteStatus?), TypeInfoPropertyName = "NullableOrganizationInviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListInvitesBadRequestError?), TypeInfoPropertyName = "NullableListInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateInvitesBadRequestError?), TypeInfoPropertyName = "NullableCreateInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetInviteNotFoundError?), TypeInfoPropertyName = "NullableGetInviteNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTBatchModel?), TypeInfoPropertyName = "NullableSTTBatchModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeModel?), TypeInfoPropertyName = "NullableSTTAutoFinalizeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeModel?), TypeInfoPropertyName = "NullableSTTManualFinalizeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSModel?), TypeInfoPropertyName = "NullableTTSModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillModel?), TypeInfoPropertyName = "NullableInfillModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneBaseModel?), TypeInfoPropertyName = "NullableFineTuneBaseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ModelSpeed?), TypeInfoPropertyName = "NullableModelSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponse?), TypeInfoPropertyName = "NullableTTSWebSocketResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant1Type?), TypeInfoPropertyName = "NullableTTSWebSocketResponseVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant2Type?), TypeInfoPropertyName = "NullableTTSWebSocketResponseVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant3Type?), TypeInfoPropertyName = "NullableTTSWebSocketResponseVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant4Type?), TypeInfoPropertyName = "NullableTTSWebSocketResponseVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant5Type?), TypeInfoPropertyName = "NullableTTSWebSocketResponseVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseVariant6Type?), TypeInfoPropertyName = "NullableTTSWebSocketResponseVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketResponseDiscriminatorType?), TypeInfoPropertyName = "NullableTTSWebSocketResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeCloseCommandType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeCloseCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketRequest?), TypeInfoPropertyName = "NullableSTTAutoFinalizeWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeConnectedType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeConnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnStartType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeTurnStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnUpdateType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeTurnUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnEagerEndType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeTurnEagerEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnResumeType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeTurnResumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeTurnEndType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeTurnEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTErrorResponseType?), TypeInfoPropertyName = "NullableSTTErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketResponse?), TypeInfoPropertyName = "NullableSTTAutoFinalizeWebSocketResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType?), TypeInfoPropertyName = "NullableSTTAutoFinalizeWebSocketResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage?), TypeInfoPropertyName = "NullableSTTManualFinalizeWebSocketQueryParamsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketRequest?), TypeInfoPropertyName = "NullableSTTManualFinalizeWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeTranscriptResponseType?), TypeInfoPropertyName = "NullableSTTManualFinalizeTranscriptResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeFlushDoneResponseType?), TypeInfoPropertyName = "NullableSTTManualFinalizeFlushDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeDoneResponseType?), TypeInfoPropertyName = "NullableSTTManualFinalizeDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketResponse?), TypeInfoPropertyName = "NullableSTTManualFinalizeWebSocketResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType?), TypeInfoPropertyName = "NullableSTTManualFinalizeWebSocketResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketRequest?), TypeInfoPropertyName = "NullableTTSWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEEvent?), TypeInfoPropertyName = "NullableVoiceChangerSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEErrorType?), TypeInfoPropertyName = "NullableVoiceChangerSSEErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeTargetLanguage?), TypeInfoPropertyName = "NullableLocalizeTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeEnglishDialect?), TypeInfoPropertyName = "NullableLocalizeEnglishDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeFrenchDialect?), TypeInfoPropertyName = "NullableLocalizeFrenchDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeSpanishDialect?), TypeInfoPropertyName = "NullableLocalizeSpanishDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizePortugueseDialect?), TypeInfoPropertyName = "NullableLocalizePortugueseDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeDialect?), TypeInfoPropertyName = "NullableLocalizeDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Gender?), TypeInfoPropertyName = "NullableGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequestModel?), TypeInfoPropertyName = "NullableSttTranscribeRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequestLanguage?), TypeInfoPropertyName = "NullableSttTranscribeRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequestAccess?), TypeInfoPropertyName = "NullableVoicesCloneRequestAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequestModelId?), TypeInfoPropertyName = "NullableInfillBytesRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsBytesCartesiaVersion?), TypeInfoPropertyName = "NullableTtsBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsSseCartesiaVersion?), TypeInfoPropertyName = "NullableTtsSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeCartesiaVersion?), TypeInfoPropertyName = "NullableSttTranscribeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsCartesiaVersion?), TypeInfoPropertyName = "NullablePostV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion?), TypeInfoPropertyName = "NullablePatchV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsByAgentIdVersionsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsModelsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion?), TypeInfoPropertyName = "NullablePostV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsType?), TypeInfoPropertyName = "NullableGetV1AgentsToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem?), TypeInfoPropertyName = "NullableGetV1AgentsToolsByToolIdExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion?), TypeInfoPropertyName = "NullablePatchV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCallsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListCallsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateOutboundCallCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsCreateOutboundCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCallCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCallCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsDeleteCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCancelCallCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsCancelCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsDownloadCallAudioCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateCallBatchCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsCreateCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCallBatchesCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListCallBatchesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCallBatchCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCancelCallBatchCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsCancelCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRetryCallBatchCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsRetryCallBatchCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListType?), TypeInfoPropertyName = "NullablePhoneNumbersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersImportCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersProvisionCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListType?), TypeInfoPropertyName = "NullableProvidersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersCreateCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersGetCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListMetricsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsCreateMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetMetricCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsDeleteMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsExportMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsAddMetricToAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsRemoveMetricFromAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AuthAccessTokenCartesiaVersion?), TypeInfoPropertyName = "NullableAuthAccessTokenCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesListCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AccentsListCartesiaVersion?), TypeInfoPropertyName = "NullableAccentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesCloneCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesGetCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesLocalizeCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesLocalizeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesAddAccentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesDeleteAccentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsListCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsCreateCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsGetCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListFilesCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsListFilesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsUploadFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsDeleteFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesUploadCartesiaVersion?), TypeInfoPropertyName = "NullableFilesUploadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesListCartesiaVersion?), TypeInfoPropertyName = "NullableFilesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesGetCartesiaVersion?), TypeInfoPropertyName = "NullableFilesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDownloadCartesiaVersion?), TypeInfoPropertyName = "NullableFilesDownloadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableFilesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesCreateCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesGetCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesListVoicesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesCartesiaVersion?), TypeInfoPropertyName = "NullableInfillBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsCartesiaVersion?), TypeInfoPropertyName = "NullableUsageCreditsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsCartesiaVersion?), TypeInfoPropertyName = "NullableUsageAgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ApiKeysListCartesiaVersion?), TypeInfoPropertyName = "NullableApiKeysListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ApiKeysGetCartesiaVersion?), TypeInfoPropertyName = "NullableApiKeysGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsUsersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesStatus?), TypeInfoPropertyName = "NullableGetOrganizationsInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion?), TypeInfoPropertyName = "NullablePostOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsTemplatesCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsTemplatesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsPhoneNumbersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListDeploymentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetDeploymentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion?), TypeInfoPropertyName = "NullableVoiceChangerBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseCartesiaVersion?), TypeInfoPropertyName = "NullableVoiceChangerSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentToolReferenceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.WebhookAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AnyOf<string, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedToolV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentTranscript>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.DynamicVariableUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCallBatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCallBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Metric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.VoiceAccentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Accent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AttachVoiceAccent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.FineTune>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.FineTuneUserError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.UsageCreditsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.UsageAgentsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumberSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.WordTimestamps>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.VoiceExpandOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ProviderAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.OrganizationUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.OrganizationInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Deployment>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Cartesia.JsonConverters.TTSRequestVoiceSpecifierJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.OutputFormatJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.TTSSSEEventJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ManagedToolV1JsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ManagedToolDefinitionV1JsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.WebhookAuthenticationResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.WebhookAuthenticationJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.PhoneNumberResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ProviderResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ProvisionPhoneNumberResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ProviderAccountResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.CreateProviderBodyJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.UpdateProviderBodyJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ListUsersBadRequestErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.UnexpectedErrorResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.GetUserNotFoundErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ListInvitesBadRequestErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.CreateInvitesBadRequestErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.GetInviteNotFoundErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.TTSWebSocketResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.STTAutoFinalizeWebSocketRequestJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.STTAutoFinalizeWebSocketResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.TTSWebSocketRequestJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.VoiceChangerSSEEventJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.LocalizeDialectJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, global::Cartesia.WebhookSecretResponse, global::Cartesia.WebhookDynamicVariableHeader>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, global::Cartesia.WebhookSecret, global::Cartesia.WebhookDynamicVariableHeader>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>());
            options.Converters.Add(new global::Cartesia.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Cartesia.TTSModelID)

                    || typeToConvert == typeof(global::Cartesia.TTSModelID?)

                    || typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.Emotion)

                    || typeToConvert == typeof(global::Cartesia.Emotion?)

                    || typeToConvert == typeof(global::Cartesia.RawEncoding)

                    || typeToConvert == typeof(global::Cartesia.RawEncoding?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType?)

                    || typeToConvert == typeof(global::Cartesia.STTEncoding)

                    || typeToConvert == typeof(global::Cartesia.STTEncoding?)

                    || typeToConvert == typeof(global::Cartesia.TimestampGranularity)

                    || typeToConvert == typeof(global::Cartesia.TimestampGranularity?)

                    || typeToConvert == typeof(global::Cartesia.TranscriptionResponseType)

                    || typeToConvert == typeof(global::Cartesia.TranscriptionResponseType?)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression?)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType)

                    || typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency)

                    || typeToConvert == typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency?)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookPathParamType)

                    || typeToConvert == typeof(global::Cartesia.WebhookPathParamType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookBodyParamType)

                    || typeToConvert == typeof(global::Cartesia.WebhookBodyParamType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookDynamicVariableHeaderType)

                    || typeToConvert == typeof(global::Cartesia.WebhookDynamicVariableHeaderType?)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType?)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamType)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretType)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamType)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.AgentCallTelephonyAccountType)

                    || typeToConvert == typeof(global::Cartesia.AgentCallTelephonyAccountType?)

                    || typeToConvert == typeof(global::Cartesia.TelephonyParamsConnectionType)

                    || typeToConvert == typeof(global::Cartesia.TelephonyParamsConnectionType?)

                    || typeToConvert == typeof(global::Cartesia.AgentCallStatus)

                    || typeToConvert == typeof(global::Cartesia.AgentCallStatus?)

                    || typeToConvert == typeof(global::Cartesia.EndReason)

                    || typeToConvert == typeof(global::Cartesia.EndReason?)

                    || typeToConvert == typeof(global::Cartesia.AgentCallBatchRequestRegion)

                    || typeToConvert == typeof(global::Cartesia.AgentCallBatchRequestRegion?)

                    || typeToConvert == typeof(global::Cartesia.AgentCallBatchRegion)

                    || typeToConvert == typeof(global::Cartesia.AgentCallBatchRegion?)

                    || typeToConvert == typeof(global::Cartesia.AgentCallBatchStatus)

                    || typeToConvert == typeof(global::Cartesia.AgentCallBatchStatus?)

                    || typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType?)

                    || typeToConvert == typeof(global::Cartesia.TelephonyRegion)

                    || typeToConvert == typeof(global::Cartesia.TelephonyRegion?)

                    || typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType)

                    || typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType?)

                    || typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType)

                    || typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType?)

                    || typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.SIPMediaEncryption)

                    || typeToConvert == typeof(global::Cartesia.SIPMediaEncryption?)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkTransport)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkTransport?)

                    || typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus)

                    || typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus?)

                    || typeToConvert == typeof(global::Cartesia.GenderPresentation)

                    || typeToConvert == typeof(global::Cartesia.GenderPresentation?)

                    || typeToConvert == typeof(global::Cartesia.VoiceExpandOptions)

                    || typeToConvert == typeof(global::Cartesia.VoiceExpandOptions?)

                    || typeToConvert == typeof(global::Cartesia.VoiceStatus)

                    || typeToConvert == typeof(global::Cartesia.VoiceStatus?)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccess)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccess?)

                    || typeToConvert == typeof(global::Cartesia.VoiceVisibility)

                    || typeToConvert == typeof(global::Cartesia.VoiceVisibility?)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.SupportedLanguage)

                    || typeToConvert == typeof(global::Cartesia.SupportedLanguage?)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess?)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility?)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.AttachVoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.AttachVoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictAccess)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictAccess?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility?)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.FilePurpose)

                    || typeToConvert == typeof(global::Cartesia.FilePurpose?)

                    || typeToConvert == typeof(global::Cartesia.FineTuneStatus)

                    || typeToConvert == typeof(global::Cartesia.FineTuneStatus?)

                    || typeToConvert == typeof(global::Cartesia.OutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.OutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.UsageInterval)

                    || typeToConvert == typeof(global::Cartesia.UsageInterval?)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy?)

                    || typeToConvert == typeof(global::Cartesia.OrganizationUserRole)

                    || typeToConvert == typeof(global::Cartesia.OrganizationUserRole?)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteRole)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteRole?)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus?)

                    || typeToConvert == typeof(global::Cartesia.STTBatchModel)

                    || typeToConvert == typeof(global::Cartesia.STTBatchModel?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeModel)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeModel?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeModel)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeModel?)

                    || typeToConvert == typeof(global::Cartesia.TTSModel)

                    || typeToConvert == typeof(global::Cartesia.TTSModel?)

                    || typeToConvert == typeof(global::Cartesia.InfillModel)

                    || typeToConvert == typeof(global::Cartesia.InfillModel?)

                    || typeToConvert == typeof(global::Cartesia.FineTuneBaseModel)

                    || typeToConvert == typeof(global::Cartesia.FineTuneBaseModel?)

                    || typeToConvert == typeof(global::Cartesia.ModelSpeed)

                    || typeToConvert == typeof(global::Cartesia.ModelSpeed?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant1Type)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant1Type?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant2Type)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant2Type?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant3Type)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant3Type?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant4Type)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant4Type?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant5Type)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant5Type?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant6Type)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant6Type?)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeCloseCommandType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeCloseCommandType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeConnectedType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeConnectedType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnStartType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnStartType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnUpdateType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnUpdateType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEagerEndType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEagerEndType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnResumeType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnResumeType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEndType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEndType?)

                    || typeToConvert == typeof(global::Cartesia.STTErrorResponseType)

                    || typeToConvert == typeof(global::Cartesia.STTErrorResponseType?)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketRequest)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketRequest?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeTranscriptResponseType)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeTranscriptResponseType?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeFlushDoneResponseType)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeFlushDoneResponseType?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeDoneResponseType)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeDoneResponseType?)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeTargetLanguage)

                    || typeToConvert == typeof(global::Cartesia.LocalizeTargetLanguage?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeEnglishDialect)

                    || typeToConvert == typeof(global::Cartesia.LocalizeEnglishDialect?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeFrenchDialect)

                    || typeToConvert == typeof(global::Cartesia.LocalizeFrenchDialect?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeSpanishDialect)

                    || typeToConvert == typeof(global::Cartesia.LocalizeSpanishDialect?)

                    || typeToConvert == typeof(global::Cartesia.LocalizePortugueseDialect)

                    || typeToConvert == typeof(global::Cartesia.LocalizePortugueseDialect?)

                    || typeToConvert == typeof(global::Cartesia.Gender)

                    || typeToConvert == typeof(global::Cartesia.Gender?)

                    || typeToConvert == typeof(global::Cartesia.SttTranscribeRequestModel)

                    || typeToConvert == typeof(global::Cartesia.SttTranscribeRequestModel?)

                    || typeToConvert == typeof(global::Cartesia.SttTranscribeRequestLanguage)

                    || typeToConvert == typeof(global::Cartesia.SttTranscribeRequestLanguage?)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess?)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId?)

                    || typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.SttTranscribeCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.SttTranscribeCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PostV1AgentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PostV1AgentsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsListCallsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsListCallsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsCreateOutboundCallCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsCreateOutboundCallCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetCallCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetCallCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsDeleteCallCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsDeleteCallCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsCancelCallCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsCancelCallCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsCreateCallBatchCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsCreateCallBatchCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsListCallBatchesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsListCallBatchesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetCallBatchCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetCallBatchCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsCancelCallBatchCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsCancelCallBatchCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsRetryCallBatchCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsRetryCallBatchCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListType)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListType?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListType)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListType?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsListMetricsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsListMetricsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetMetricCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetMetricCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AuthAccessTokenCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AuthAccessTokenCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ApiKeysListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ApiKeysListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ApiKeysGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ApiKeysGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsTemplatesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsTemplatesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.TTSModelID))
                {
                    return new global::Cartesia.JsonConverters.TTSModelIDJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSModelID?))
                {
                    return new global::Cartesia.JsonConverters.TTSModelIDNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.WAVOutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.WAVOutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.MP3OutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.MP3OutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.RawOutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.RawOutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.Emotion))
                {
                    return new global::Cartesia.JsonConverters.EmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.Emotion?))
                {
                    return new global::Cartesia.JsonConverters.EmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawEncoding))
                {
                    return new global::Cartesia.JsonConverters.RawEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawEncoding?))
                {
                    return new global::Cartesia.JsonConverters.RawEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.SSEOutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.SSEOutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEChunkEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEChunkEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTEncoding))
                {
                    return new global::Cartesia.JsonConverters.STTEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTEncoding?))
                {
                    return new global::Cartesia.JsonConverters.STTEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TimestampGranularity))
                {
                    return new global::Cartesia.JsonConverters.TimestampGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TimestampGranularity?))
                {
                    return new global::Cartesia.JsonConverters.TimestampGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TranscriptionResponseType))
                {
                    return new global::Cartesia.JsonConverters.TranscriptionResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TranscriptionResponseType?))
                {
                    return new global::Cartesia.JsonConverters.TranscriptionResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppressionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression?))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppressionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?))
                {
                    return new global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentPrimaryLanguageV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentPrimaryLanguageV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentConfigV1AudioInputNoiseSuppressionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentConfigV1AudioInputNoiseSuppressionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1EndCallPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1EndCallPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1EndCallPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1SendDtmfPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1SendDtmfPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationType?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1TransferToNumberTransferDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppressionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppressionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentModelV1PricingCurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency?))
                {
                    return new global::Cartesia.JsonConverters.ManagedAgentModelV1PricingCurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolV1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolV1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolDefinitionV1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolDefinitionV1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1ResponseMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1ResponseMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolParametersV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolParametersV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1MethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1MethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant2ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookPathParamType))
                {
                    return new global::Cartesia.JsonConverters.WebhookPathParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookPathParamType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookPathParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookBodyParamType))
                {
                    return new global::Cartesia.JsonConverters.WebhookBodyParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookBodyParamType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookBodyParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookDynamicVariableHeaderType))
                {
                    return new global::Cartesia.JsonConverters.WebhookDynamicVariableHeaderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookDynamicVariableHeaderType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookDynamicVariableHeaderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType?))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamType))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamType?))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant2ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretType))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamType))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdateExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdateExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallTelephonyAccountType))
                {
                    return new global::Cartesia.JsonConverters.AgentCallTelephonyAccountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallTelephonyAccountType?))
                {
                    return new global::Cartesia.JsonConverters.AgentCallTelephonyAccountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyParamsConnectionType))
                {
                    return new global::Cartesia.JsonConverters.TelephonyParamsConnectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyParamsConnectionType?))
                {
                    return new global::Cartesia.JsonConverters.TelephonyParamsConnectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallStatus))
                {
                    return new global::Cartesia.JsonConverters.AgentCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallStatus?))
                {
                    return new global::Cartesia.JsonConverters.AgentCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.EndReason))
                {
                    return new global::Cartesia.JsonConverters.EndReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.EndReason?))
                {
                    return new global::Cartesia.JsonConverters.EndReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallBatchRequestRegion))
                {
                    return new global::Cartesia.JsonConverters.AgentCallBatchRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallBatchRequestRegion?))
                {
                    return new global::Cartesia.JsonConverters.AgentCallBatchRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallBatchRegion))
                {
                    return new global::Cartesia.JsonConverters.AgentCallBatchRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallBatchRegion?))
                {
                    return new global::Cartesia.JsonConverters.AgentCallBatchRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallBatchStatus))
                {
                    return new global::Cartesia.JsonConverters.AgentCallBatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentCallBatchStatus?))
                {
                    return new global::Cartesia.JsonConverters.AgentCallBatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ProviderResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ProviderResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.TwilioProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.TwilioProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.CartesiaProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.CartesiaProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkEmbeddedResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType?))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkEmbeddedResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyRegion))
                {
                    return new global::Cartesia.JsonConverters.TelephonyRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyRegion?))
                {
                    return new global::Cartesia.JsonConverters.TelephonyRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType))
                {
                    return new global::Cartesia.JsonConverters.ImportPhoneNumberBodyProviderByTwilioAccountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType?))
                {
                    return new global::Cartesia.JsonConverters.ImportPhoneNumberBodyProviderByTwilioAccountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType))
                {
                    return new global::Cartesia.JsonConverters.UpdatePhoneNumberBodyProviderByTwilioAccountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType?))
                {
                    return new global::Cartesia.JsonConverters.UpdatePhoneNumberBodyProviderByTwilioAccountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ProviderAccountResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ProviderAccountResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPMediaEncryption))
                {
                    return new global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPMediaEncryption?))
                {
                    return new global::Cartesia.JsonConverters.SIPMediaEncryptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkTransport))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkTransport?))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.CreateProviderBodyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.CreateProviderBodyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.CreateTwilioProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.CreateTwilioProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.CreateSIPProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.CreateSIPProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.UpdateProviderBodyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateProviderBodyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.UpdateTwilioProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateTwilioProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.UpdateSIPTrunkProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateSIPTrunkProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus))
                {
                    return new global::Cartesia.JsonConverters.AgentMetricResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus?))
                {
                    return new global::Cartesia.JsonConverters.AgentMetricResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GenderPresentation))
                {
                    return new global::Cartesia.JsonConverters.GenderPresentationJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GenderPresentation?))
                {
                    return new global::Cartesia.JsonConverters.GenderPresentationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceExpandOptions))
                {
                    return new global::Cartesia.JsonConverters.VoiceExpandOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceExpandOptions?))
                {
                    return new global::Cartesia.JsonConverters.VoiceExpandOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceStatus))
                {
                    return new global::Cartesia.JsonConverters.VoiceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceStatus?))
                {
                    return new global::Cartesia.JsonConverters.VoiceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccess))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccess?))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceVisibility))
                {
                    return new global::Cartesia.JsonConverters.VoiceVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceVisibility?))
                {
                    return new global::Cartesia.JsonConverters.VoiceVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccent))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccentJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccent?))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SupportedLanguage))
                {
                    return new global::Cartesia.JsonConverters.SupportedLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SupportedLanguage?))
                {
                    return new global::Cartesia.JsonConverters.SupportedLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess?))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility?))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceAccentJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceAccentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AttachVoiceAccent))
                {
                    return new global::Cartesia.JsonConverters.AttachVoiceAccentJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AttachVoiceAccent?))
                {
                    return new global::Cartesia.JsonConverters.AttachVoiceAccentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictAccess))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictAccess?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilePurpose))
                {
                    return new global::Cartesia.JsonConverters.FilePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilePurpose?))
                {
                    return new global::Cartesia.JsonConverters.FilePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTuneStatus))
                {
                    return new global::Cartesia.JsonConverters.FineTuneStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTuneStatus?))
                {
                    return new global::Cartesia.JsonConverters.FineTuneStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.OutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.OutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageInterval))
                {
                    return new global::Cartesia.JsonConverters.UsageIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageInterval?))
                {
                    return new global::Cartesia.JsonConverters.UsageIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy?))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationUserRole))
                {
                    return new global::Cartesia.JsonConverters.OrganizationUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationUserRole?))
                {
                    return new global::Cartesia.JsonConverters.OrganizationUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteRole))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteRole?))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus?))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTBatchModel))
                {
                    return new global::Cartesia.JsonConverters.STTBatchModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTBatchModel?))
                {
                    return new global::Cartesia.JsonConverters.STTBatchModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeModel))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeModel?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeModel))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeModel?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSModel))
                {
                    return new global::Cartesia.JsonConverters.TTSModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSModel?))
                {
                    return new global::Cartesia.JsonConverters.TTSModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillModel))
                {
                    return new global::Cartesia.JsonConverters.InfillModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillModel?))
                {
                    return new global::Cartesia.JsonConverters.InfillModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTuneBaseModel))
                {
                    return new global::Cartesia.JsonConverters.FineTuneBaseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTuneBaseModel?))
                {
                    return new global::Cartesia.JsonConverters.FineTuneBaseModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ModelSpeed))
                {
                    return new global::Cartesia.JsonConverters.ModelSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ModelSpeed?))
                {
                    return new global::Cartesia.JsonConverters.ModelSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant1Type))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant1Type?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant2Type))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant2Type?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant3Type))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant3Type?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant4Type))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant4Type?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant5Type))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant5Type?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant6Type))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseVariant6Type?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSWebSocketResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.TTSWebSocketResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeCloseCommandType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeCloseCommandTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeCloseCommandType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeCloseCommandTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeConnectedType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeConnectedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeConnectedType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeConnectedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnStartType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnStartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnStartType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnStartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnUpdateType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnUpdateType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEagerEndType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnEagerEndTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEagerEndType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnEagerEndTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnResumeType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnResumeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnResumeType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnResumeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEndType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnEndTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeTurnEndType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeTurnEndTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTErrorResponseType))
                {
                    return new global::Cartesia.JsonConverters.STTErrorResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTErrorResponseType?))
                {
                    return new global::Cartesia.JsonConverters.STTErrorResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeWebSocketResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.STTAutoFinalizeWebSocketResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketQueryParamsLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketQueryParamsLanguage?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketQueryParamsLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketRequest))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketRequest?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeTranscriptResponseType))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeTranscriptResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeTranscriptResponseType?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeTranscriptResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeFlushDoneResponseType))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeFlushDoneResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeFlushDoneResponseType?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeFlushDoneResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeDoneResponseType))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeDoneResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeDoneResponseType?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeDoneResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.STTManualFinalizeWebSocketResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSSEErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType?))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSSEErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeTargetLanguage))
                {
                    return new global::Cartesia.JsonConverters.LocalizeTargetLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeTargetLanguage?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeTargetLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeEnglishDialect))
                {
                    return new global::Cartesia.JsonConverters.LocalizeEnglishDialectJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeEnglishDialect?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeEnglishDialectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeFrenchDialect))
                {
                    return new global::Cartesia.JsonConverters.LocalizeFrenchDialectJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeFrenchDialect?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeFrenchDialectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeSpanishDialect))
                {
                    return new global::Cartesia.JsonConverters.LocalizeSpanishDialectJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeSpanishDialect?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeSpanishDialectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizePortugueseDialect))
                {
                    return new global::Cartesia.JsonConverters.LocalizePortugueseDialectJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizePortugueseDialect?))
                {
                    return new global::Cartesia.JsonConverters.LocalizePortugueseDialectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.Gender))
                {
                    return new global::Cartesia.JsonConverters.GenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.Gender?))
                {
                    return new global::Cartesia.JsonConverters.GenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SttTranscribeRequestModel))
                {
                    return new global::Cartesia.JsonConverters.SttTranscribeRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SttTranscribeRequestModel?))
                {
                    return new global::Cartesia.JsonConverters.SttTranscribeRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SttTranscribeRequestLanguage))
                {
                    return new global::Cartesia.JsonConverters.SttTranscribeRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SttTranscribeRequestLanguage?))
                {
                    return new global::Cartesia.JsonConverters.SttTranscribeRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneRequestAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess?))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneRequestAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesRequestModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId?))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesRequestModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.TtsBytesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.TtsBytesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.TtsSseCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.TtsSseCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SttTranscribeCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.SttTranscribeCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SttTranscribeCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.SttTranscribeCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostV1AgentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PostV1AgentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostV1AgentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PostV1AgentsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsByAgentIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsByAgentIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PatchV1AgentsByAgentIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PatchV1AgentsByAgentIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteV1AgentsByAgentIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteV1AgentsByAgentIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsByAgentIdVersionsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsByAgentIdVersionsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsModelsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsModelsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PostV1AgentsToolsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PostV1AgentsToolsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PatchV1AgentsToolsByToolIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PatchV1AgentsToolsByToolIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteV1AgentsToolsByToolIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteV1AgentsToolsByToolIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListCallsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsListCallsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListCallsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsListCallsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCreateOutboundCallCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsCreateOutboundCallCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCreateOutboundCallCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsCreateOutboundCallCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetCallCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetCallCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetCallCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetCallCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDeleteCallCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsDeleteCallCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDeleteCallCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsDeleteCallCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCancelCallCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsCancelCallCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCancelCallCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsCancelCallCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsDownloadCallAudioCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsDownloadCallAudioCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCreateCallBatchCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsCreateCallBatchCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCreateCallBatchCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsCreateCallBatchCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListCallBatchesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsListCallBatchesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListCallBatchesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsListCallBatchesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetCallBatchCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetCallBatchCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetCallBatchCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetCallBatchCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCancelCallBatchCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsCancelCallBatchCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCancelCallBatchCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsCancelCallBatchCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsRetryCallBatchCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsRetryCallBatchCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsRetryCallBatchCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsRetryCallBatchCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListType))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListType?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersImportCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersImportCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersProvisionCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersProvisionCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListType))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListType?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListMetricsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsListMetricsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListMetricsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsListMetricsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsCreateMetricCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsCreateMetricCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetMetricCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetMetricCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetMetricCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetMetricCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsDeleteMetricCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsDeleteMetricCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsListMetricResultsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsListMetricResultsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsExportMetricResultsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsExportMetricResultsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsAddMetricToAgentCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsAddMetricToAgentCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsRemoveMetricFromAgentCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsRemoveMetricFromAgentCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AuthAccessTokenCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AuthAccessTokenCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AuthAccessTokenCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AuthAccessTokenCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AccentsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AccentsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesLocalizeCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesLocalizeCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesAddAccentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesAddAccentsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteAccentCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteAccentCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListFilesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListFilesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUploadFileCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUploadFileCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteFileCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteFileCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesUploadCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesUploadCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesDownloadCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesDownloadCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListVoicesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListVoicesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.UsageAgentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.UsageAgentsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ApiKeysListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ApiKeysListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ApiKeysListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ApiKeysListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ApiKeysGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ApiKeysGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ApiKeysGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ApiKeysGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsUsersByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsUsersByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PostOrganizationsInvitesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PostOrganizationsInvitesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsInvitesByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsInvitesByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsTemplatesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsTemplatesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsTemplatesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsTemplatesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsPhoneNumbersCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsPhoneNumbersCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsListDeploymentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsListDeploymentsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetDeploymentCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AgentsGetDeploymentCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerBytesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerBytesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSseCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSseCartesiaVersionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}