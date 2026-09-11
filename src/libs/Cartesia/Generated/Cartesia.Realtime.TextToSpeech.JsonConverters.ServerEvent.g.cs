#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.TextToSpeech.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.TextToSpeech.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.Realtime.TextToSpeech.ChunkResponse? chunk = default;
            if (discriminator?.Type == global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType.Chunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.ChunkResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.ChunkResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.ChunkResponse)}");
                chunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? flushDone = default;
            if (discriminator?.Type == global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType.FlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse)}");
                flushDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? done = default;
            if (discriminator?.Type == global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? timestamps = default;
            if (discriminator?.Type == global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType.Timestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.TimestampsResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse)}");
                timestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? phonemeTimestamps = default;
            if (discriminator?.Type == global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType.PhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse)}");
                phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.Realtime.TextToSpeech.ServerEvent(
                discriminator?.Type,
                chunk,

                flushDone,

                done,

                timestamps,

                phonemeTimestamps,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.TextToSpeech.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.ChunkResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.ChunkResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.TextToSpeech.ChunkResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chunk!, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
            }
            else if (value.IsTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.TimestampsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Timestamps!, typeInfo);
            }
            else if (value.IsPhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhonemeTimestamps!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}