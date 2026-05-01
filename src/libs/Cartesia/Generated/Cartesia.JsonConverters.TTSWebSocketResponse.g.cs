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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("context_id")) __score0++;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("done")) __score0++;
            if (__jsonProps.Contains("flush_id")) __score0++;
            if (__jsonProps.Contains("status_code")) __score0++;
            if (__jsonProps.Contains("step_time")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("context_id")) __score1++;
            if (__jsonProps.Contains("done")) __score1++;
            if (__jsonProps.Contains("flush_done")) __score1++;
            if (__jsonProps.Contains("flush_id")) __score1++;
            if (__jsonProps.Contains("status_code")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("context_id")) __score2++;
            if (__jsonProps.Contains("done")) __score2++;
            if (__jsonProps.Contains("status_code")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("context_id")) __score3++;
            if (__jsonProps.Contains("done")) __score3++;
            if (__jsonProps.Contains("flush_id")) __score3++;
            if (__jsonProps.Contains("status_code")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("word_timestamps")) __score3++;
            if (__jsonProps.Contains("word_timestamps.end")) __score3++;
            if (__jsonProps.Contains("word_timestamps.start")) __score3++;
            if (__jsonProps.Contains("word_timestamps.words")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("context_id")) __score4++;
            if (__jsonProps.Contains("doc_url")) __score4++;
            if (__jsonProps.Contains("done")) __score4++;
            if (__jsonProps.Contains("error_code")) __score4++;
            if (__jsonProps.Contains("message")) __score4++;
            if (__jsonProps.Contains("request_id")) __score4++;
            if (__jsonProps.Contains("status_code")) __score4++;
            if (__jsonProps.Contains("title")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("context_id")) __score5++;
            if (__jsonProps.Contains("done")) __score5++;
            if (__jsonProps.Contains("flush_id")) __score5++;
            if (__jsonProps.Contains("phoneme_timestamps")) __score5++;
            if (__jsonProps.Contains("phoneme_timestamps.end")) __score5++;
            if (__jsonProps.Contains("phoneme_timestamps.phonemes")) __score5++;
            if (__jsonProps.Contains("phoneme_timestamps.start")) __score5++;
            if (__jsonProps.Contains("status_code")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Cartesia.TTSWebSocketResponseVariant1? chunk = default;
            global::Cartesia.TTSWebSocketResponseVariant2? flushDone = default;
            global::Cartesia.TTSWebSocketResponseVariant3? done = default;
            global::Cartesia.TTSWebSocketResponseVariant4? timestamps = default;
            global::Cartesia.TTSWebSocketResponseVariant5? error = default;
            global::Cartesia.TTSWebSocketResponseVariant6? phonemeTimestamps = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant1).Name}");
                        chunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant2).Name}");
                        flushDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant3).Name}");
                        done = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant4).Name}");
                        timestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant5).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant6).Name}");
                        phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chunk == null && flushDone == null && done == null && timestamps == null && error == null && phonemeTimestamps == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant1).Name}");
                    chunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant2).Name}");
                    flushDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant3).Name}");
                    done = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant4).Name}");
                    timestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant5).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TTSWebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TTSWebSocketResponseVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TTSWebSocketResponseVariant6).Name}");
                    phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Cartesia.TTSWebSocketResponse(
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