
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedPronunciationDicts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictAccess), TypeInfoPropertyName = "PronunciationDictAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictVisibility), TypeInfoPropertyName = "PronunciationDictVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>), TypeInfoPropertyName = "OneOfCreatePronunciationDictRequestAccessEnumCreatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum), TypeInfoPropertyName = "CreatePronunciationDictRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType), TypeInfoPropertyName = "CreatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>), TypeInfoPropertyName = "OneOfUpdatePronunciationDictRequestAccessEnumUpdatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum), TypeInfoPropertyName = "UpdatePronunciationDictRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType), TypeInfoPropertyName = "UpdatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsListCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion), TypeInfoPropertyName = "PronunciationDictsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictAccess?), TypeInfoPropertyName = "NullablePronunciationDictAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictVisibility?), TypeInfoPropertyName = "NullablePronunciationDictVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfCreatePronunciationDictRequestAccessEnumCreatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum?), TypeInfoPropertyName = "NullableCreatePronunciationDictRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType?), TypeInfoPropertyName = "NullableCreatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfUpdatePronunciationDictRequestAccessEnumUpdatePronunciationDictRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum?), TypeInfoPropertyName = "NullableUpdatePronunciationDictRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType?), TypeInfoPropertyName = "NullableUpdatePronunciationDictRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsListCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion?), TypeInfoPropertyName = "NullablePronunciationDictsDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PronunciationDictItem>))]
    internal sealed partial class PronunciationDictsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PronunciationDictsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PronunciationDictsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PronunciationDictsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.CreatePronunciationDictRequestAccessEnum?, global::Cartesia.CreatePronunciationDictRequestAccessEnum2>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdatePronunciationDictRequestAccessEnum?, global::Cartesia.UpdatePronunciationDictRequestAccessEnum2>());
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
                    typeToConvert == typeof(global::Cartesia.PronunciationDictAccess)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictAccess?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility?)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.PronunciationDictAccess))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictAccess?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictVisibility?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreatePronunciationDictRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.CreatePronunciationDictRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePronunciationDictRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.UpdatePronunciationDictRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PronunciationDictsDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PronunciationDictsDeleteCartesiaVersionNullableJsonConverter();
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
                    0 => new PronunciationDictsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}