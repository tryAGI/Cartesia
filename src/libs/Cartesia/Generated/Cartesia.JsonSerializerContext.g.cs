
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
            typeof(global::Cartesia.JsonConverters.AgentCallStatusJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentCallStatusNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentMetricResultStatusJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentMetricResultStatusNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTuneStatusJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTuneStatusNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TimestampGranularityJsonConverter),

            typeof(global::Cartesia.JsonConverters.TimestampGranularityNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant1TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant1TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant2TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant2TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant3TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant3TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant4TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseVariant4TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.STTEncodingJsonConverter),

            typeof(global::Cartesia.JsonConverters.STTEncodingNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.ModelSpeedJsonConverter),

            typeof(global::Cartesia.JsonConverters.ModelSpeedNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant1TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant1TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant2TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant2TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant3TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant3TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant4TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant4TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant5TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant5TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant6TypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseVariant6TypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.WebSocketRawOutputFormatContainerJsonConverter),

            typeof(global::Cartesia.JsonConverters.WebSocketRawOutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.EmotionJsonConverter),

            typeof(global::Cartesia.JsonConverters.EmotionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEEventDiscriminatorTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEChunkEventTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEChunkEventTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEDoneEventTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEDoneEventTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEErrorEventTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEErrorEventTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerSSEErrorTypeJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerSSEErrorTypeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.SupportedLanguageJsonConverter),

            typeof(global::Cartesia.JsonConverters.SupportedLanguageNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatRAWOutputFormatContainerJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatRAWOutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatWAVOutputFormatContainerJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatWAVOutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatMP3OutputFormatContainerJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatMP3OutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.SSEOutputFormatContainerJsonConverter),

            typeof(global::Cartesia.JsonConverters.SSEOutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.RawEncodingJsonConverter),

            typeof(global::Cartesia.JsonConverters.RawEncodingNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSRequestVoiceSpecifierModeJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSRequestVoiceSpecifierModeNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatContainerJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeTargetLanguageJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeTargetLanguageNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeEnglishDialectJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeEnglishDialectNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeFrenchDialectJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeFrenchDialectNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeSpanishDialectJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeSpanishDialectNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizePortugueseDialectJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizePortugueseDialectNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.GenderPresentationJsonConverter),

            typeof(global::Cartesia.JsonConverters.GenderPresentationNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.GenderJsonConverter),

            typeof(global::Cartesia.JsonConverters.GenderNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceExpandOptionsJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceExpandOptionsNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.SttTranscribeRequestLanguageJsonConverter),

            typeof(global::Cartesia.JsonConverters.SttTranscribeRequestLanguageNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsUpdateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsUpdateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsDeleteCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsDeleteCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsTemplatesCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsTemplatesCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListCallsCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListCallsCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetCallCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetCallCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsDownloadCallAudioCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsDownloadCallAudioCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsPhoneNumbersCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsPhoneNumbersCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListMetricsCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListMetricsCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsCreateMetricCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsCreateMetricCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetMetricCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetMetricCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListMetricResultsCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListMetricResultsCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsExportMetricResultsCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsExportMetricResultsCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsAddMetricToAgentCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsAddMetricToAgentCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsRemoveMetricFromAgentCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsRemoveMetricFromAgentCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListDeploymentsCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsListDeploymentsCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetDeploymentCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AgentsGetDeploymentCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.ApiStatusGetCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.ApiStatusGetCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.AuthAccessTokenCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.AuthAccessTokenCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsListCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsListCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsCreateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsCreateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsGetCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsGetCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsUpdateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsUpdateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsDeleteCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsDeleteCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsListFilesCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsListFilesCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsUploadFileCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsUploadFileCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsDeleteFileCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.DatasetsDeleteFileCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesListCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesListCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesCreateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesCreateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesGetCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesGetCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesDeleteCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesDeleteCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesListVoicesCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.FineTunesListVoicesCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.InfillBytesCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.InfillBytesCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsListCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsListCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsCreateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsCreateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsGetCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsGetCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsUpdateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsUpdateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsDeleteCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.PronunciationDictsDeleteCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.SttTranscribeCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.SttTranscribeCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TtsBytesCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.TtsBytesCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.TtsSseCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.TtsSseCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerBytesCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerBytesCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerSseCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerSseCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesListCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesListCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesCloneCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesCloneCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesDeleteCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesDeleteCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesUpdateCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesUpdateCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesGetCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesGetCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesLocalizeCartesiaVersionJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoicesLocalizeCartesiaVersionNullableJsonConverter),

            typeof(global::Cartesia.JsonConverters.StreamingTranscriptionResponseJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketResponseJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSWebSocketRequestJsonConverter),

            typeof(global::Cartesia.JsonConverters.TTSSSEEventJsonConverter),

            typeof(global::Cartesia.JsonConverters.VoiceChangerSSEEventJsonConverter),

            typeof(global::Cartesia.JsonConverters.OutputFormatJsonConverter),

            typeof(global::Cartesia.JsonConverters.WAVOutputFormatJsonConverter),

            typeof(global::Cartesia.JsonConverters.LocalizeDialectJsonConverter),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>),

            typeof(global::Cartesia.JsonConverters.AllOfJsonConverter<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>),

            typeof(global::Cartesia.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LogEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LogMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCallStatus), TypeInfoPropertyName = "AgentCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentMetricResultStatus), TypeInfoPropertyName = "AgentMetricResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GitRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.TextChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Metric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateMetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Metric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListMetricResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Deployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.APIInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TokenGrant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedDatasetFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.S3UploadParamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneStatus), TypeInfoPropertyName = "FineTuneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTune))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateFineTuneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedFineTunes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.FineTune>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedVoices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedPronunciationDicts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TimestampGranularity), TypeInfoPropertyName = "TimestampGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponse), TypeInfoPropertyName = "StreamingTranscriptionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>), TypeInfoPropertyName = "AllOfStreamingTranscriptionResponseVariant12TranscriptMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant1Type), TypeInfoPropertyName = "StreamingTranscriptionResponseVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>), TypeInfoPropertyName = "AllOfStreamingTranscriptionResponseVariant22FlushDoneMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant2Type), TypeInfoPropertyName = "StreamingTranscriptionResponseVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FlushDoneMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>), TypeInfoPropertyName = "AllOfStreamingTranscriptionResponseVariant32DoneMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant3Type), TypeInfoPropertyName = "StreamingTranscriptionResponseVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DoneMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>), TypeInfoPropertyName = "AllOfStreamingTranscriptionResponseVariant42ErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.StreamingTranscriptionResponseVariant4Type), TypeInfoPropertyName = "StreamingTranscriptionResponseVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.STTEncoding), TypeInfoPropertyName = "STTEncoding2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CancelContextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebSocketRawOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebSocketRawOutputFormatContainer), TypeInfoPropertyName = "WebSocketRawOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding), TypeInfoPropertyName = "RawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSWebSocketRequest), TypeInfoPropertyName = "TTSWebSocketRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Emotion), TypeInfoPropertyName = "Emotion2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEventType), TypeInfoPropertyName = "TTSSSEChunkEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventType), TypeInfoPropertyName = "TTSSSETimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType), TypeInfoPropertyName = "TTSSSEPhonemeTimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEventType), TypeInfoPropertyName = "TTSSSEDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEventType), TypeInfoPropertyName = "TTSSSEErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEEvent), TypeInfoPropertyName = "VoiceChangerSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEErrorType), TypeInfoPropertyName = "VoiceChangerSSEErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>), TypeInfoPropertyName = "AllOfOutputFormatRAWOutputFormat2RawOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatRAWOutputFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatRAWOutputFormatContainer), TypeInfoPropertyName = "OutputFormatRAWOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>), TypeInfoPropertyName = "AllOfOutputFormatWAVOutputFormat2WAVOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatWAVOutputFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatWAVOutputFormatContainer), TypeInfoPropertyName = "OutputFormatWAVOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormat), TypeInfoPropertyName = "WAVOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>), TypeInfoPropertyName = "AllOfOutputFormatMP3OutputFormat2MP3OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatMP3OutputFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatMP3OutputFormatContainer), TypeInfoPropertyName = "OutputFormatMP3OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormatContainer), TypeInfoPropertyName = "SSEOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifierMode), TypeInfoPropertyName = "TTSRequestVoiceSpecifierMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer), TypeInfoPropertyName = "OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation), TypeInfoPropertyName = "GenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeTargetLanguage), TypeInfoPropertyName = "LocalizeTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeEnglishDialect), TypeInfoPropertyName = "LocalizeEnglishDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeFrenchDialect), TypeInfoPropertyName = "LocalizeFrenchDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeSpanishDialect), TypeInfoPropertyName = "LocalizeSpanishDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizePortugueseDialect), TypeInfoPropertyName = "LocalizePortugueseDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeDialect), TypeInfoPropertyName = "LocalizeDialect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Gender), TypeInfoPropertyName = "Gender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceExpandOptions), TypeInfoPropertyName = "VoiceExpandOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeRequestLanguage), TypeInfoPropertyName = "SttTranscribeRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCartesiaVersion), TypeInfoPropertyName = "AgentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCartesiaVersion), TypeInfoPropertyName = "AgentsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsUpdateCartesiaVersion), TypeInfoPropertyName = "AgentsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDeleteCartesiaVersion), TypeInfoPropertyName = "AgentsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsTemplatesCartesiaVersion), TypeInfoPropertyName = "AgentsTemplatesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListCallsCartesiaVersion), TypeInfoPropertyName = "AgentsListCallsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetCallCartesiaVersion), TypeInfoPropertyName = "AgentsGetCallCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsDownloadCallAudioCartesiaVersion), TypeInfoPropertyName = "AgentsDownloadCallAudioCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsPhoneNumbersCartesiaVersion), TypeInfoPropertyName = "AgentsPhoneNumbersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricsCartesiaVersion), TypeInfoPropertyName = "AgentsListMetricsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsCreateMetricCartesiaVersion), TypeInfoPropertyName = "AgentsCreateMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetMetricCartesiaVersion), TypeInfoPropertyName = "AgentsGetMetricCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListMetricResultsCartesiaVersion), TypeInfoPropertyName = "AgentsListMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsExportMetricResultsCartesiaVersion), TypeInfoPropertyName = "AgentsExportMetricResultsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsAddMetricToAgentCartesiaVersion), TypeInfoPropertyName = "AgentsAddMetricToAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsRemoveMetricFromAgentCartesiaVersion), TypeInfoPropertyName = "AgentsRemoveMetricFromAgentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsListDeploymentsCartesiaVersion), TypeInfoPropertyName = "AgentsListDeploymentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AgentsGetDeploymentCartesiaVersion), TypeInfoPropertyName = "AgentsGetDeploymentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ApiStatusGetCartesiaVersion), TypeInfoPropertyName = "ApiStatusGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AuthAccessTokenCartesiaVersion), TypeInfoPropertyName = "AuthAccessTokenCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListCartesiaVersion), TypeInfoPropertyName = "DatasetsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsCreateCartesiaVersion), TypeInfoPropertyName = "DatasetsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsGetCartesiaVersion), TypeInfoPropertyName = "DatasetsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUpdateCartesiaVersion), TypeInfoPropertyName = "DatasetsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteCartesiaVersion), TypeInfoPropertyName = "DatasetsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListFilesCartesiaVersion), TypeInfoPropertyName = "DatasetsListFilesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion), TypeInfoPropertyName = "DatasetsUploadFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion), TypeInfoPropertyName = "DatasetsDeleteFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListCartesiaVersion), TypeInfoPropertyName = "FineTunesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesCreateCartesiaVersion), TypeInfoPropertyName = "FineTunesCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesGetCartesiaVersion), TypeInfoPropertyName = "FineTunesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesDeleteCartesiaVersion), TypeInfoPropertyName = "FineTunesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion), TypeInfoPropertyName = "FineTunesListVoicesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesCartesiaVersion), TypeInfoPropertyName = "InfillBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsListCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SttTranscribeCartesiaVersion), TypeInfoPropertyName = "SttTranscribeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsBytesCartesiaVersion), TypeInfoPropertyName = "TtsBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsSseCartesiaVersion), TypeInfoPropertyName = "TtsSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion), TypeInfoPropertyName = "VoiceChangerBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseCartesiaVersion), TypeInfoPropertyName = "VoiceChangerSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesListCartesiaVersion), TypeInfoPropertyName = "VoicesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneCartesiaVersion), TypeInfoPropertyName = "VoicesCloneCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteCartesiaVersion), TypeInfoPropertyName = "VoicesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesUpdateCartesiaVersion), TypeInfoPropertyName = "VoicesUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesGetCartesiaVersion), TypeInfoPropertyName = "VoicesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesLocalizeCartesiaVersion), TypeInfoPropertyName = "VoicesLocalizeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Deployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumberSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.TextChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentTranscript>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Metric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.MetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.FineTune>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.VoiceExpandOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Deployment>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}