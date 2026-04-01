#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class LocalizeDialectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.LocalizeDialect>
    {
        /// <inheritdoc />
        public override global::Cartesia.LocalizeDialect Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeEnglishDialect), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeSpanishDialect), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizePortugueseDialect), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeFrenchDialect), options);
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

            global::Cartesia.LocalizeEnglishDialect? localizeEnglishDialect = default;
            global::Cartesia.LocalizeSpanishDialect? localizeSpanishDialect = default;
            global::Cartesia.LocalizePortugueseDialect? localizePortugueseDialect = default;
            global::Cartesia.LocalizeFrenchDialect? localizeFrenchDialect = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeEnglishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeEnglishDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeEnglishDialect).Name}");
                        localizeEnglishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeSpanishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeSpanishDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeSpanishDialect).Name}");
                        localizeSpanishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizePortugueseDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizePortugueseDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizePortugueseDialect).Name}");
                        localizePortugueseDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeFrenchDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeFrenchDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeFrenchDialect).Name}");
                        localizeFrenchDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (localizeEnglishDialect == null && localizeSpanishDialect == null && localizePortugueseDialect == null && localizeFrenchDialect == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeEnglishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeEnglishDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeEnglishDialect).Name}");
                    localizeEnglishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeSpanishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeSpanishDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeSpanishDialect).Name}");
                    localizeSpanishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizePortugueseDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizePortugueseDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizePortugueseDialect).Name}");
                    localizePortugueseDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeFrenchDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeFrenchDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeFrenchDialect).Name}");
                    localizeFrenchDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Cartesia.LocalizeDialect(
                localizeEnglishDialect,

                localizeSpanishDialect,

                localizePortugueseDialect,

                localizeFrenchDialect
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.LocalizeDialect value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLocalizeEnglishDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeEnglishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeEnglishDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeEnglishDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizeEnglishDialect!.Value, typeInfo);
            }
            else if (value.IsLocalizeSpanishDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeSpanishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeSpanishDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeSpanishDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizeSpanishDialect!.Value, typeInfo);
            }
            else if (value.IsLocalizePortugueseDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizePortugueseDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizePortugueseDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizePortugueseDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizePortugueseDialect!.Value, typeInfo);
            }
            else if (value.IsLocalizeFrenchDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LocalizeFrenchDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LocalizeFrenchDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LocalizeFrenchDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizeFrenchDialect!.Value, typeInfo);
            }
        }
    }
}