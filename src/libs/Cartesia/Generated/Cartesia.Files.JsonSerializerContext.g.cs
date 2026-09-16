
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilePurpose), TypeInfoPropertyName = "FilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesUploadCartesiaVersion), TypeInfoPropertyName = "FilesUploadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesListCartesiaVersion), TypeInfoPropertyName = "FilesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesGetCartesiaVersion), TypeInfoPropertyName = "FilesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDownloadCartesiaVersion), TypeInfoPropertyName = "FilesDownloadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDeleteCartesiaVersion), TypeInfoPropertyName = "FilesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilePurpose?), TypeInfoPropertyName = "NullableFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesUploadCartesiaVersion?), TypeInfoPropertyName = "NullableFilesUploadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesListCartesiaVersion?), TypeInfoPropertyName = "NullableFilesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesGetCartesiaVersion?), TypeInfoPropertyName = "NullableFilesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDownloadCartesiaVersion?), TypeInfoPropertyName = "NullableFilesDownloadCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FilesDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableFilesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.File>))]
    internal sealed partial class FilesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FilesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FilesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Cartesia.FilePurpose)

                    || typeToConvert == typeof(global::Cartesia.FilePurpose?)

                    || typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.FilePurpose))
                {
                    return new global::Cartesia.JsonConverters.FilePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilePurpose?))
                {
                    return new global::Cartesia.JsonConverters.FilePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesUploadCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesUploadCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesUploadCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesDownloadCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDownloadCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesDownloadCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FilesDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FilesDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FilesDeleteCartesiaVersionNullableJsonConverter();
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
                    0 => new FilesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}