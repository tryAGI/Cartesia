#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class OutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.OutputFormat>
    {
        /// <inheritdoc />
        public override global::Cartesia.OutputFormat Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>? rAWOutputFormat = default;
            global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>? wAVOutputFormat = default;
            global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>? mP3OutputFormat = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>).Name}");
                        rAWOutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>).Name}");
                        wAVOutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>).Name}");
                        mP3OutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (rAWOutputFormat == null && wAVOutputFormat == null && mP3OutputFormat == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>).Name}");
                    rAWOutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>).Name}");
                    wAVOutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>).Name}");
                    mP3OutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Cartesia.OutputFormat(
                rAWOutputFormat,

                wAVOutputFormat,

                mP3OutputFormat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.OutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRAWOutputFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatRAWOutputFormat2, global::Cartesia.RawOutputFormat>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RAWOutputFormat!.Value, typeInfo);
            }
            else if (value.IsWAVOutputFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatWAVOutputFormat2, global::Cartesia.WAVOutputFormat?>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WAVOutputFormat!.Value, typeInfo);
            }
            else if (value.IsMP3OutputFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.AllOf<global::Cartesia.OutputFormatMP3OutputFormat2, global::Cartesia.MP3OutputFormat>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MP3OutputFormat!.Value, typeInfo);
            }
        }
    }
}