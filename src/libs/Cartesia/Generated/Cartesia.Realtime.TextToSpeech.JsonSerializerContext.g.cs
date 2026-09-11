
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestModelIdJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestModelIdNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestOutputFormatContainerJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestOutputFormatContainerNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestOutputFormatEncodingJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestOutputFormatEncodingNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestLanguageJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestLanguageNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestLocaleJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestLocaleNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestGenerationConfigEmotionJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationRequestGenerationConfigEmotionNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.ChunkResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.ChunkResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.FlushDoneResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.FlushDoneResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationDoneResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.GenerationDoneResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.TimestampsResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.TimestampsResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.PhonemeTimestampsResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.PhonemeTimestampsResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.TTSErrorResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.TTSErrorResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.ServerEventJsonConverter),

            typeof(global::Cartesia.Realtime.TextToSpeech.JsonConverters.OneOfJsonConverter<string, global::Cartesia.Realtime.TextToSpeech.GenerationRequestVoice>),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestModelId), TypeInfoPropertyName = "GenerationRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.OneOf<string, global::Cartesia.Realtime.TextToSpeech.GenerationRequestVoice>), TypeInfoPropertyName = "OneOfStringGenerationRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatContainer), TypeInfoPropertyName = "GenerationRequestOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding), TypeInfoPropertyName = "GenerationRequestOutputFormatEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestLanguage), TypeInfoPropertyName = "GenerationRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale), TypeInfoPropertyName = "GenerationRequestLocale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequestGenerationConfigEmotion), TypeInfoPropertyName = "GenerationRequestGenerationConfigEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.CancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.ChunkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.ChunkResponseType), TypeInfoPropertyName = "ChunkResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponseType), TypeInfoPropertyName = "FlushDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponseType), TypeInfoPropertyName = "GenerationDoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponseType), TypeInfoPropertyName = "TimestampsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponseWordTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponseType), TypeInfoPropertyName = "PhonemeTimestampsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponsePhonemeTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponseType), TypeInfoPropertyName = "TTSErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    public sealed partial class TextToSpeechSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}