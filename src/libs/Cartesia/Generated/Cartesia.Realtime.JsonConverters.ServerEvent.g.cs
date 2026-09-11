#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.Realtime.AgentSessionReadyEvent? sessionReady = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.SessionReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentSessionReadyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentSessionReadyEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentSessionReadyEvent)}");
                sessionReady = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentAudioOutputEvent? audioOutput = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.AudioOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentAudioOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentAudioOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentAudioOutputEvent)}");
                audioOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentAudioOutputClearEvent? audioOutputClear = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.AudioOutputClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentAudioOutputClearEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentAudioOutputClearEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentAudioOutputClearEvent)}");
                audioOutputClear = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentDtmfOutputEvent? dtmfOutput = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.DtmfOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentDtmfOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentDtmfOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentDtmfOutputEvent)}");
                dtmfOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentClientToolCallEvent? clientToolCall = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.ClientToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentClientToolCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentClientToolCallEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentClientToolCallEvent)}");
                clientToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentTurnStartedEvent? turnStarted = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.TurnStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentTurnStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentTurnStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentTurnStartedEvent)}");
                turnStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? turnOutputTextDelta = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.TurnOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent)}");
                turnOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentTurnEndedEvent? turnEnded = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.TurnEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentTurnEndedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentTurnEndedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentTurnEndedEvent)}");
                turnEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.AgentErrorEvent? error = default;
            if (discriminator?.Type == global::Cartesia.Realtime.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.AgentErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.Realtime.ServerEvent(
                discriminator?.Type,
                sessionReady,

                audioOutput,

                audioOutputClear,

                dtmfOutput,

                clientToolCall,

                turnStarted,

                turnOutputTextDelta,

                turnEnded,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentSessionReadyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentSessionReadyEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentSessionReadyEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionReady!, typeInfo);
            }
            else if (value.IsAudioOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentAudioOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentAudioOutputEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentAudioOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioOutput!, typeInfo);
            }
            else if (value.IsAudioOutputClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentAudioOutputClearEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentAudioOutputClearEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentAudioOutputClearEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioOutputClear!, typeInfo);
            }
            else if (value.IsDtmfOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentDtmfOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentDtmfOutputEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentDtmfOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DtmfOutput!, typeInfo);
            }
            else if (value.IsClientToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentClientToolCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentClientToolCallEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentClientToolCallEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientToolCall!, typeInfo);
            }
            else if (value.IsTurnStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentTurnStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentTurnStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentTurnStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnStarted!, typeInfo);
            }
            else if (value.IsTurnOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnOutputTextDelta!, typeInfo);
            }
            else if (value.IsTurnEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentTurnEndedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentTurnEndedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentTurnEndedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnEnded!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.AgentErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.AgentErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.AgentErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}