#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class StreamingTranscriptionResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.StreamingTranscriptionResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.StreamingTranscriptionResponse Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? value1 = default;
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? value2 = default;
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? value3 = default;
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? value4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Cartesia.StreamingTranscriptionResponse(
                value1,

                value2,

                value3,

                value4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.StreamingTranscriptionResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!.Value, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!.Value, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!.Value, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!.Value, typeInfo);
            }
        }
    }
}