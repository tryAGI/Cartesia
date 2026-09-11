#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime.SpeechToText.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.SpeechToText.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.SpeechToText.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? transcript = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType.Transcript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse)}");
                transcript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? flushDone = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType.FlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse)}");
                flushDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToText.STTDoneResponse? done = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTDoneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToText.STTDoneResponse)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.Realtime.SpeechToText.STTErrorResponse? error = default;
            if (discriminator?.Type == global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.Realtime.SpeechToText.STTErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.Realtime.SpeechToText.ServerEvent(
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
            global::Cartesia.Realtime.SpeechToText.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Transcript!, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTDoneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTDoneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToText.STTDoneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.Realtime.SpeechToText.STTErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.Realtime.SpeechToText.STTErrorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.Realtime.SpeechToText.STTErrorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}