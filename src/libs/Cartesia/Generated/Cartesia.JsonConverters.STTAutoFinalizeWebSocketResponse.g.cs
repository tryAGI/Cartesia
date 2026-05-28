#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class STTAutoFinalizeWebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.STTAutoFinalizeWebSocketResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.STTAutoFinalizeWebSocketResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.STTAutoFinalizeConnected? connected = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.Connected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeConnected> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeConnected)}");
                connected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTAutoFinalizeTurnStart? turnStart = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnStart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeTurnStart)}");
                turnStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTAutoFinalizeTurnUpdate? turnUpdate = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeTurnUpdate)}");
                turnUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTAutoFinalizeTurnEagerEnd? turnEagerEnd = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnEagerEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnEagerEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnEagerEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeTurnEagerEnd)}");
                turnEagerEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTAutoFinalizeTurnResume? turnResume = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnResume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnResume), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnResume> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeTurnResume)}");
                turnResume = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTAutoFinalizeTurnEnd? turnEnd = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.TurnEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTAutoFinalizeTurnEnd)}");
                turnEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.STTAutoFinalizeWebSocketResponse(
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
            global::Cartesia.STTAutoFinalizeWebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeConnected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTAutoFinalizeConnected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Connected!, typeInfo);
            }
            else if (value.IsTurnStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTAutoFinalizeTurnStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnStart!, typeInfo);
            }
            else if (value.IsTurnUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTAutoFinalizeTurnUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnUpdate!, typeInfo);
            }
            else if (value.IsTurnEagerEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnEagerEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnEagerEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTAutoFinalizeTurnEagerEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnEagerEnd!, typeInfo);
            }
            else if (value.IsTurnResume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnResume), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnResume?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTAutoFinalizeTurnResume).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnResume!, typeInfo);
            }
            else if (value.IsTurnEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTAutoFinalizeTurnEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTAutoFinalizeTurnEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTAutoFinalizeTurnEnd).Name}");
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