#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class STTTurnsWebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.STTTurnsWebSocketResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.STTTurnsWebSocketResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsWebSocketResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsWebSocketResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsWebSocketResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.STTTurnsConnected? connected = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.Connected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsConnected> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsConnected)}");
                connected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTTurnsTurnStart? turnStart = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.TurnStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnStart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsTurnStart)}");
                turnStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTTurnsTurnUpdate? turnUpdate = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.TurnUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsTurnUpdate)}");
                turnUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTTurnsTurnEagerEnd? turnEagerEnd = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.TurnEagerEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnEagerEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnEagerEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsTurnEagerEnd)}");
                turnEagerEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTTurnsTurnResume? turnResume = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.TurnResume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnResume), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnResume> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsTurnResume)}");
                turnResume = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTTurnsTurnEnd? turnEnd = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.TurnEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTTurnsTurnEnd)}");
                turnEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.STTTurnsWebSocketResponse(
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
            global::Cartesia.STTTurnsWebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsConnected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTTurnsConnected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Connected!, typeInfo);
            }
            else if (value.IsTurnStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTTurnsTurnStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnStart!, typeInfo);
            }
            else if (value.IsTurnUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTTurnsTurnUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnUpdate!, typeInfo);
            }
            else if (value.IsTurnEagerEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnEagerEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnEagerEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTTurnsTurnEagerEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnEagerEnd!, typeInfo);
            }
            else if (value.IsTurnResume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnResume), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnResume?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTTurnsTurnResume).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnResume!, typeInfo);
            }
            else if (value.IsTurnEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTTurnsTurnEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTTurnsTurnEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTTurnsTurnEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnEnd!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTErrorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTErrorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}