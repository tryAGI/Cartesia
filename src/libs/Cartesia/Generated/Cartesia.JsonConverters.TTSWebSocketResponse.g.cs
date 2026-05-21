#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class TTSWebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.TTSWebSocketResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.TTSWebSocketResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.TTSWebSocketResponseVariant1? chunk = default;
            if (discriminator?.Type == global::Cartesia.TTSWebSocketResponseDiscriminatorType.Chunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseVariant1)}");
                chunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSWebSocketResponseVariant2? flushDone = default;
            if (discriminator?.Type == global::Cartesia.TTSWebSocketResponseDiscriminatorType.FlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseVariant2)}");
                flushDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSWebSocketResponseVariant3? done = default;
            if (discriminator?.Type == global::Cartesia.TTSWebSocketResponseDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseVariant3)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSWebSocketResponseVariant4? timestamps = default;
            if (discriminator?.Type == global::Cartesia.TTSWebSocketResponseDiscriminatorType.Timestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseVariant4)}");
                timestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSWebSocketResponseVariant5? error = default;
            if (discriminator?.Type == global::Cartesia.TTSWebSocketResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseVariant5)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSWebSocketResponseVariant6? phonemeTimestamps = default;
            if (discriminator?.Type == global::Cartesia.TTSWebSocketResponseDiscriminatorType.PhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSWebSocketResponseVariant6)}");
                phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.TTSWebSocketResponse(
                discriminator?.Type,
                chunk,

                flushDone,

                done,

                timestamps,

                error,

                phonemeTimestamps
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.TTSWebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chunk!, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
            }
            else if (value.IsTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Timestamps!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsPhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhonemeTimestamps!, typeInfo);
            }
        }
    }
}