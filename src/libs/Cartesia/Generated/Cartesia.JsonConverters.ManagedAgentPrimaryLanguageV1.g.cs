#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class ManagedAgentPrimaryLanguageV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedAgentPrimaryLanguageV1>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedAgentPrimaryLanguageV1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Cartesia.LanguageOrLocale? orLocale = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LanguageOrLocale), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LanguageOrLocale> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LanguageOrLocale).Name}");
                orLocale = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var __value = new global::Cartesia.ManagedAgentPrimaryLanguageV1(
                orLocale
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedAgentPrimaryLanguageV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsOrLocale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.LanguageOrLocale), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.LanguageOrLocale> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.LanguageOrLocale).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickOrLocale(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}