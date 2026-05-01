#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class VoiceChangerSSEEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.VoiceChangerSSEEvent>
    {
        /// <inheritdoc />
        public override global::Cartesia.VoiceChangerSSEEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("done")) __score0++;
            if (__jsonProps.Contains("sample_rate")) __score0++;
            if (__jsonProps.Contains("status_code")) __score0++;
            if (__jsonProps.Contains("step_time")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("done")) __score1++;
            if (__jsonProps.Contains("status_code")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("doc_url")) __score2++;
            if (__jsonProps.Contains("done")) __score2++;
            if (__jsonProps.Contains("error_code")) __score2++;
            if (__jsonProps.Contains("message")) __score2++;
            if (__jsonProps.Contains("request_id")) __score2++;
            if (__jsonProps.Contains("status_code")) __score2++;
            if (__jsonProps.Contains("title")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Cartesia.VoiceChangerSSEChunk? voiceChangerSSEChunk = default;
            global::Cartesia.VoiceChangerSSEDone? voiceChangerSSEDone = default;
            global::Cartesia.VoiceChangerSSEError? voiceChangerSSEError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEChunk).Name}");
                        voiceChangerSSEChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEDone).Name}");
                        voiceChangerSSEDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEError).Name}");
                        voiceChangerSSEError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (voiceChangerSSEChunk == null && voiceChangerSSEDone == null && voiceChangerSSEError == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEChunk).Name}");
                    voiceChangerSSEChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEDone).Name}");
                    voiceChangerSSEDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEError).Name}");
                    voiceChangerSSEError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Cartesia.VoiceChangerSSEEvent(
                voiceChangerSSEChunk,

                voiceChangerSSEDone,

                voiceChangerSSEError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.VoiceChangerSSEEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVoiceChangerSSEChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceChangerSSEChunk!, typeInfo);
            }
            else if (value.IsVoiceChangerSSEDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceChangerSSEDone!, typeInfo);
            }
            else if (value.IsVoiceChangerSSEError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.VoiceChangerSSEError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.VoiceChangerSSEError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.VoiceChangerSSEError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceChangerSSEError!, typeInfo);
            }
        }
    }
}