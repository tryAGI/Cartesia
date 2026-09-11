#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.SpeechToTextTurns.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.SpeechToTextTurns.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.SpeechToTextTurns.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? connected = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.Connected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected)}");
                connected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? turnStart = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.TurnStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart)}");
                turnStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? turnUpdate = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.TurnUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate)}");
                turnUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? turnEagerEnd = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.TurnEagerEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd)}");
                turnEagerEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? turnResume = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.TurnResume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume)}");
                turnResume = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? turnEnd = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.TurnEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd)}");
                turnEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.Realtime.SpeechToTextTurns.ServerEvent(
                discriminator?.Type,
                connected,

                turnStart,

                turnUpdate,

                turnEagerEnd,

                turnResume,

                turnEnd,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.SpeechToTextTurns.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Connected!, typeInfo);
            }
            else if (value.IsTurnStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnStart!, typeInfo);
            }
            else if (value.IsTurnUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnUpdate!, typeInfo);
            }
            else if (value.IsTurnEagerEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnEagerEnd!, typeInfo);
            }
            else if (value.IsTurnResume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnResume!, typeInfo);
            }
            else if (value.IsTurnEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnEnd!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}