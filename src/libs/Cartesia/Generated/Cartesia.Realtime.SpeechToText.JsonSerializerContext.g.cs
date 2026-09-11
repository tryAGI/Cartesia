
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTFinalizeCommandJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTFinalizeCommandNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTCloseCommandJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTCloseCommandNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTTranscriptResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTTranscriptResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTFlushDoneResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTFlushDoneResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTDoneResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTDoneResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTErrorResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.STTErrorResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.SpeechToTextModelJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.SpeechToTextModelNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.SpeechToTextEncodingJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.SpeechToTextEncodingNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.SpeechToTextApiVersionJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.SpeechToTextApiVersionNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToText.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTFinalizeCommand), TypeInfoPropertyName = "STTFinalizeCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTCloseCommand), TypeInfoPropertyName = "STTCloseCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseType), TypeInfoPropertyName = "STTTranscriptResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponseType), TypeInfoPropertyName = "STTFlushDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTDoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTDoneResponseType), TypeInfoPropertyName = "STTDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.STTErrorResponseType), TypeInfoPropertyName = "STTErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.SpeechToTextModel), TypeInfoPropertyName = "SpeechToTextModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.SpeechToTextEncoding), TypeInfoPropertyName = "SpeechToTextEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.SpeechToTextApiVersion), TypeInfoPropertyName = "SpeechToTextApiVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponseWord>))]
    public sealed partial class SpeechToTextSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}