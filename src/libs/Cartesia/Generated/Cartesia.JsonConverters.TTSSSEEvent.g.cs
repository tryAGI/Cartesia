#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class TTSSSEEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.TTSSSEEvent>
    {
        /// <inheritdoc />
        public override global::Cartesia.TTSSSEEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSSSEEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.TTSSSEChunkEvent? chunk = default;
            if (discriminator?.Type == global::Cartesia.TTSSSEEventDiscriminatorType.Chunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSSSEChunkEvent)}");
                chunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSSSETimestampsEvent? timestamps = default;
            if (discriminator?.Type == global::Cartesia.TTSSSEEventDiscriminatorType.Timestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSETimestampsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSETimestampsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSSSETimestampsEvent)}");
                timestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSSSEPhonemeTimestampsEvent? phonemeTimestamps = default;
            if (discriminator?.Type == global::Cartesia.TTSSSEEventDiscriminatorType.PhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEPhonemeTimestampsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSSSEPhonemeTimestampsEvent)}");
                phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSSSEDoneEvent? done = default;
            if (discriminator?.Type == global::Cartesia.TTSSSEEventDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSSSEDoneEvent)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.TTSSSEErrorEvent? error = default;
            if (discriminator?.Type == global::Cartesia.TTSSSEEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TTSSSEErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.TTSSSEEvent(
                discriminator?.Type,
                chunk,

                timestamps,

                phonemeTimestamps,

                done,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.TTSSSEEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEChunkEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSSSEChunkEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chunk!, typeInfo);
            }
            else if (value.IsTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSETimestampsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSETimestampsEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSSSETimestampsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Timestamps!, typeInfo);
            }
            else if (value.IsPhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEPhonemeTimestampsEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSSSEPhonemeTimestampsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhonemeTimestamps!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSSSEDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSSSEErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSSSEErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSSSEErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}