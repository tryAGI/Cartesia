
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsCloseCommandTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsCloseCommandTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConfigCommandTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConfigCommandTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConnectedTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsConnectedTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnStartTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnStartTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnUpdateTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnUpdateTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnEagerEndTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnEagerEndTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnResumeTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnResumeTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnEndTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTTurnsTurnEndTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTErrorResponseTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.STTErrorResponseTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.SpeechToTextTurnsEncodingJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.SpeechToTextTurnsEncodingNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.SpeechToTextTurnsApiVersionJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.SpeechToTextTurnsApiVersionNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsCloseCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsCloseCommandType), TypeInfoPropertyName = "STTTurnsCloseCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandType), TypeInfoPropertyName = "STTTurnsConfigCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConfigCommandTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnectedType), TypeInfoPropertyName = "STTTurnsConnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStartType), TypeInfoPropertyName = "STTTurnsTurnStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdateType), TypeInfoPropertyName = "STTTurnsTurnUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEndType), TypeInfoPropertyName = "STTTurnsTurnEagerEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResumeType), TypeInfoPropertyName = "STTTurnsTurnResumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEndType), TypeInfoPropertyName = "STTTurnsTurnEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponseType), TypeInfoPropertyName = "STTErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding), TypeInfoPropertyName = "SpeechToTextTurnsEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsApiVersion), TypeInfoPropertyName = "SpeechToTextTurnsApiVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    public sealed partial class SpeechToTextTurnsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}