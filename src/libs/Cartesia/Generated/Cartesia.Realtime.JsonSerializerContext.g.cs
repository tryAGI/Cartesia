
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventAudioInputFormatJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventAudioInputFormatNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventAudioOutputDeliveryJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionCreateEventAudioOutputDeliveryNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioInputEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioInputEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentDtmfInputEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentDtmfInputEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentClientToolResultEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentClientToolResultEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionReadyEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentSessionReadyEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioOutputEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioOutputEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioOutputClearEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentAudioOutputClearEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentDtmfOutputEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentDtmfOutputEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentClientToolCallEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentClientToolCallEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnStartedEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnStartedEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnStartedEventRoleJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnStartedEventRoleNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnOutputTextDeltaEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnOutputTextDeltaEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnOutputTextDeltaEventRoleJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnOutputTextDeltaEventRoleNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnEndedEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnEndedEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnEndedEventRoleJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentTurnEndedEventRoleNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentErrorEventTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentErrorEventTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentErrorEventCodeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AgentErrorEventCodeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.ServerEventJsonConverter),

            typeof(global::Cartesia.Realtime.JsonConverters.AnyOfJsonConverter<string, double?, bool?>),

            typeof(global::Cartesia.Realtime.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object>),

            typeof(global::Cartesia.Realtime.JsonConverters.AnyOfJsonConverter<string, double?, bool?>),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionCreateEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionCreateEventType), TypeInfoPropertyName = "AgentSessionCreateEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionCreateEventAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionCreateEventAudioInputFormat), TypeInfoPropertyName = "AgentSessionCreateEventAudioInputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionCreateEventAudioOutputDelivery), TypeInfoPropertyName = "AgentSessionCreateEventAudioOutputDelivery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AnyOf<string, double?, bool?>), TypeInfoPropertyName = "AnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentAudioInputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentAudioInputEventType), TypeInfoPropertyName = "AgentAudioInputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentDtmfInputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentDtmfInputEventType), TypeInfoPropertyName = "AgentDtmfInputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentClientToolResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentClientToolResultEventType), TypeInfoPropertyName = "AgentClientToolResultEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionReadyEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionReadyEventType), TypeInfoPropertyName = "AgentSessionReadyEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentSessionReadyEventAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentAudioOutputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentAudioOutputEventType), TypeInfoPropertyName = "AgentAudioOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentAudioOutputClearEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentAudioOutputClearEventType), TypeInfoPropertyName = "AgentAudioOutputClearEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentDtmfOutputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentDtmfOutputEventType), TypeInfoPropertyName = "AgentDtmfOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentClientToolCallEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentClientToolCallEventType), TypeInfoPropertyName = "AgentClientToolCallEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnStartedEventType), TypeInfoPropertyName = "AgentTurnStartedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnStartedEventRole), TypeInfoPropertyName = "AgentTurnStartedEventRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventType), TypeInfoPropertyName = "AgentTurnOutputTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventRole), TypeInfoPropertyName = "AgentTurnOutputTextDeltaEventRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnEndedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnEndedEventType), TypeInfoPropertyName = "AgentTurnEndedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnEndedEventRole), TypeInfoPropertyName = "AgentTurnEndedEventRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnEndedEventToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCallDynamicVariableUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentTurnEndedEventToolCallDynamicVariableUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AnyOf<string, double?, bool?, object>), TypeInfoPropertyName = "AnyOfStringDoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentErrorEventType), TypeInfoPropertyName = "AgentErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.AgentErrorEventCode), TypeInfoPropertyName = "AgentErrorEventCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Realtime.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Realtime.AgentTurnEndedEventToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Realtime.AgentTurnEndedEventToolCallDynamicVariableUpdate>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}