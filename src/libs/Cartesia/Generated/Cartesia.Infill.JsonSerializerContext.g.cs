
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding), TypeInfoPropertyName = "RawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer), TypeInfoPropertyName = "OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequestModelId), TypeInfoPropertyName = "InfillBytesRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesCartesiaVersion), TypeInfoPropertyName = "InfillBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding?), TypeInfoPropertyName = "NullableRawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage?), TypeInfoPropertyName = "NullableSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer?), TypeInfoPropertyName = "NullableOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesRequestModelId?), TypeInfoPropertyName = "NullableInfillBytesRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InfillBytesCartesiaVersion?), TypeInfoPropertyName = "NullableInfillBytesCartesiaVersion2")]
    internal sealed partial class InfillSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfillSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InfillSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InfillSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Cartesia.RawEncoding)

                    || typeToConvert == typeof(global::Cartesia.RawEncoding?)

                    || typeToConvert == typeof(global::Cartesia.SupportedLanguage)

                    || typeToConvert == typeof(global::Cartesia.SupportedLanguage?)

                    || typeToConvert == typeof(global::Cartesia.OutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.OutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId?)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.RawEncoding))
                {
                    return new global::Cartesia.JsonConverters.RawEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawEncoding?))
                {
                    return new global::Cartesia.JsonConverters.RawEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SupportedLanguage))
                {
                    return new global::Cartesia.JsonConverters.SupportedLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SupportedLanguage?))
                {
                    return new global::Cartesia.JsonConverters.SupportedLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.OutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.OutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesRequestModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesRequestModelId?))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesRequestModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.InfillBytesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.InfillBytesCartesiaVersionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new InfillSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}