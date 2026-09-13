
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression), TypeInfoPropertyName = "CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentV1Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression), TypeInfoPropertyName = "ManagedAgentConfigV1AudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1AudioOutputBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Language))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentConfigV1Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSystemToolsV1))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedAgentVersionsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentVersionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedAgentModelsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1Pricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentModelV1PricingCurrency), TypeInfoPropertyName = "ManagedAgentModelV1PricingCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentOutboundCallItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentOutboundCallItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRequestRegion), TypeInfoPropertyName = "AgentCallBatchRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRegion), TypeInfoPropertyName = "AgentCallBatchRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchStatus), TypeInfoPropertyName = "AgentCallBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListAgentCallBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentCallBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Metric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Metric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateMetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListMetricResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentMetricResultStatus), TypeInfoPropertyName = "AgentMetricResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsCartesiaVersion), TypeInfoPropertyName = "PostV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion), TypeInfoPropertyName = "PatchV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion), TypeInfoPropertyName = "DeleteV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsByAgentIdVersionsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsModelsCartesiaVersion2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricsCartesiaVersion), TypeInfoPropertyName = "AgentsListMetricsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion), TypeInfoPropertyName = "AgentsCreateMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetMetricCartesiaVersion), TypeInfoPropertyName = "AgentsGetMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion), TypeInfoPropertyName = "AgentsDeleteMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion), TypeInfoPropertyName = "AgentsListMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion), TypeInfoPropertyName = "AgentsExportMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion), TypeInfoPropertyName = "AgentsAddMetricToAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion), TypeInfoPropertyName = "AgentsRemoveMetricFromAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCartesiaVersion), TypeInfoPropertyName = "AgentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCartesiaVersion), TypeInfoPropertyName = "AgentsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsUpdateCartesiaVersion), TypeInfoPropertyName = "AgentsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCartesiaVersion), TypeInfoPropertyName = "AgentsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsTemplatesCartesiaVersion), TypeInfoPropertyName = "AgentsTemplatesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion), TypeInfoPropertyName = "AgentsPhoneNumbersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion), TypeInfoPropertyName = "AgentsListDeploymentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion), TypeInfoPropertyName = "AgentsGetDeploymentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCancelCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Deployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigAudioInputNoiseSuppression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentPrimaryLanguageV1?), TypeInfoPropertyName = "NullableManagedAgentPrimaryLanguageV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsSendDtmfPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType?), TypeInfoPropertyName = "NullableCreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestinationType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallTelephonyAccountType?), TypeInfoPropertyName = "NullableAgentCallTelephonyAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallStatus?), TypeInfoPropertyName = "NullableAgentCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.EndReason?), TypeInfoPropertyName = "NullableEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyParamsConnectionType?), TypeInfoPropertyName = "NullableTelephonyParamsConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRequestRegion?), TypeInfoPropertyName = "NullableAgentCallBatchRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchRegion?), TypeInfoPropertyName = "NullableAgentCallBatchRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallBatchStatus?), TypeInfoPropertyName = "NullableAgentCallBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentMetricResultStatus?), TypeInfoPropertyName = "NullableAgentMetricResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsCartesiaVersion?), TypeInfoPropertyName = "NullablePostV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsByAgentIdCartesiaVersion?), TypeInfoPropertyName = "NullablePatchV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsByAgentIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteV1AgentsByAgentIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsByAgentIdVersionsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsByAgentIdVersionsByVersionIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsModelsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsModelsCartesiaVersion2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListMetricsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsCreateMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetMetricCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteMetricCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsDeleteMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsExportMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsAddMetricToAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsRemoveMetricFromAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsTemplatesCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsTemplatesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsPhoneNumbersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsListDeploymentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion?), TypeInfoPropertyName = "NullableAgentsGetDeploymentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentToolReferenceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentTranscript>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentOutboundCallItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCallBatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCallBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Metric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumberSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Deployment>))]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
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
                    typeToConvert == typeof(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression)

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

                    || typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus)

                    || typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus?)

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

                    || typeToConvert == typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus))
                {
                    return new global::Cartesia.JsonConverters.AgentMetricResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AgentMetricResultStatus?))
                {
                    return new global::Cartesia.JsonConverters.AgentMetricResultStatusNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}