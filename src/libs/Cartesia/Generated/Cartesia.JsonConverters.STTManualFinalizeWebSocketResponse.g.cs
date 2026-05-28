#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class STTManualFinalizeWebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.STTManualFinalizeWebSocketResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.STTManualFinalizeWebSocketResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.STTManualFinalizeTranscriptResponse? transcript = default;
            if (discriminator?.Type == global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType.Transcript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeTranscriptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeTranscriptResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTManualFinalizeTranscriptResponse)}");
                transcript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTManualFinalizeFlushDoneResponse? flushDone = default;
            if (discriminator?.Type == global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType.FlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeFlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeFlushDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTManualFinalizeFlushDoneResponse)}");
                flushDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTManualFinalizeDoneResponse? done = default;
            if (discriminator?.Type == global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTManualFinalizeDoneResponse)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.STTManualFinalizeWebSocketResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.STTManualFinalizeWebSocketResponse(
                discriminator?.Type,
                transcript,

                flushDone,

                done,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.STTManualFinalizeWebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeTranscriptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeTranscriptResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTManualFinalizeTranscriptResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Transcript!, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeFlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeFlushDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTManualFinalizeFlushDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTManualFinalizeDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTManualFinalizeDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTManualFinalizeDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
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