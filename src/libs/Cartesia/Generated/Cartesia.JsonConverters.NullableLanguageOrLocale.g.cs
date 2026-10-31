#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class NullableLanguageOrLocaleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.NullableLanguageOrLocale>
    {
        /// <inheritdoc />
        public override global::Cartesia.NullableLanguageOrLocale Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LanguageOrLocale), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.NullableLanguageOrLocaleEnum), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Cartesia.LanguageOrLocale? languageOrLocale = default;
            global::Cartesia.NullableLanguageOrLocaleEnum? @null = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LanguageOrLocale), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LanguageOrLocale> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LanguageOrLocale).Name}");
                        languageOrLocale = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.NullableLanguageOrLocaleEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.NullableLanguageOrLocaleEnum> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.NullableLanguageOrLocaleEnum).Name}");
                        @null = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (languageOrLocale == null && @null == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LanguageOrLocale), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LanguageOrLocale> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LanguageOrLocale).Name}");
                    languageOrLocale = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (languageOrLocale == null && @null == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.NullableLanguageOrLocaleEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.NullableLanguageOrLocaleEnum> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.NullableLanguageOrLocaleEnum).Name}");
                    @null = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Cartesia.NullableLanguageOrLocale(
                languageOrLocale,

                @null
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.NullableLanguageOrLocale value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLanguageOrLocale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LanguageOrLocale), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LanguageOrLocale> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LanguageOrLocale).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLanguageOrLocale(), typeInfo);
            }
            else if (value.IsNull)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.NullableLanguageOrLocaleEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.NullableLanguageOrLocaleEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.NullableLanguageOrLocaleEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNull(), typeInfo);
            }
        }
    }
}