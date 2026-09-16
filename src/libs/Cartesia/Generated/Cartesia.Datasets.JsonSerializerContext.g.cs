
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedDatasetFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListCartesiaVersion), TypeInfoPropertyName = "DatasetsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsCreateCartesiaVersion), TypeInfoPropertyName = "DatasetsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsGetCartesiaVersion), TypeInfoPropertyName = "DatasetsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUpdateCartesiaVersion), TypeInfoPropertyName = "DatasetsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteCartesiaVersion), TypeInfoPropertyName = "DatasetsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListFilesCartesiaVersion), TypeInfoPropertyName = "DatasetsListFilesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion), TypeInfoPropertyName = "DatasetsUploadFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion), TypeInfoPropertyName = "DatasetsDeleteFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsCreateCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsGetCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsListFilesCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsListFilesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsUploadFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion?), TypeInfoPropertyName = "NullableDatasetsDeleteFileCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.DatasetFile>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListFilesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsListFilesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsListFilesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUploadFileCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsUploadFileCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsUploadFileCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteFileCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DatasetsDeleteFileCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DatasetsDeleteFileCartesiaVersionNullableJsonConverter();
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
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}