#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class STTExternalVADWebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.STTExternalVADWebSocketResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.STTExternalVADWebSocketResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADWebSocketResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADWebSocketResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTExternalVADWebSocketResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.STTExternalVADTranscriptResponse? transcript = default;
            if (discriminator?.Type == global::Cartesia.STTExternalVADWebSocketResponseDiscriminatorType.Transcript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADTranscriptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADTranscriptResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTExternalVADTranscriptResponse)}");
                transcript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTExternalVADFlushDoneResponse? flushDone = default;
            if (discriminator?.Type == global::Cartesia.STTExternalVADWebSocketResponseDiscriminatorType.FlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADFlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADFlushDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTExternalVADFlushDoneResponse)}");
                flushDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTExternalVADDoneResponse? done = default;
            if (discriminator?.Type == global::Cartesia.STTExternalVADWebSocketResponseDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTExternalVADDoneResponse)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.STTErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.STTExternalVADWebSocketResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.STTErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.STTExternalVADWebSocketResponse(
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
            global::Cartesia.STTExternalVADWebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADTranscriptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADTranscriptResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTExternalVADTranscriptResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Transcript!, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADFlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADFlushDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTExternalVADFlushDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.STTExternalVADDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.STTExternalVADDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.STTExternalVADDoneResponse).Name}");
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