
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation), TypeInfoPropertyName = "GenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceStatus), TypeInfoPropertyName = "VoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccess), TypeInfoPropertyName = "VoiceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccentsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceVisibility), TypeInfoPropertyName = "VoiceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccent), TypeInfoPropertyName = "VoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedFineTunes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.FineTune>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTune))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneStatus), TypeInfoPropertyName = "FineTuneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.FineTuneUserError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneUserError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateFineTuneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PaginatedVoices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListCartesiaVersion), TypeInfoPropertyName = "FineTunesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesCreateCartesiaVersion), TypeInfoPropertyName = "FineTunesCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesGetCartesiaVersion), TypeInfoPropertyName = "FineTunesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesDeleteCartesiaVersion), TypeInfoPropertyName = "FineTunesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion), TypeInfoPropertyName = "FineTunesListVoicesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation?), TypeInfoPropertyName = "NullableGenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceStatus?), TypeInfoPropertyName = "NullableVoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccess?), TypeInfoPropertyName = "NullableVoiceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceVisibility?), TypeInfoPropertyName = "NullableVoiceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccent?), TypeInfoPropertyName = "NullableVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTuneStatus?), TypeInfoPropertyName = "NullableFineTuneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesCreateCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesGetCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion?), TypeInfoPropertyName = "NullableFineTunesListVoicesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.VoiceAccentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.FineTune>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.FineTuneUserError>))]
    internal sealed partial class FineTunesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FineTunesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FineTunesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FineTunesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Cartesia.GenderPresentation)

                    || typeToConvert == typeof(global::Cartesia.GenderPresentation?)

                    || typeToConvert == typeof(global::Cartesia.VoiceStatus)

                    || typeToConvert == typeof(global::Cartesia.VoiceStatus?)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccess)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccess?)

                    || typeToConvert == typeof(global::Cartesia.VoiceVisibility)

                    || typeToConvert == typeof(global::Cartesia.VoiceVisibility?)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.FineTuneStatus)

                    || typeToConvert == typeof(global::Cartesia.FineTuneStatus?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.GenderPresentation))
                {
                    return new global::Cartesia.JsonConverters.GenderPresentationJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GenderPresentation?))
                {
                    return new global::Cartesia.JsonConverters.GenderPresentationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceStatus))
                {
                    return new global::Cartesia.JsonConverters.VoiceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceStatus?))
                {
                    return new global::Cartesia.JsonConverters.VoiceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccess))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccess?))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceVisibility))
                {
                    return new global::Cartesia.JsonConverters.VoiceVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceVisibility?))
                {
                    return new global::Cartesia.JsonConverters.VoiceVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccent))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccentJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceAccent?))
                {
                    return new global::Cartesia.JsonConverters.VoiceAccentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTuneStatus))
                {
                    return new global::Cartesia.JsonConverters.FineTuneStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTuneStatus?))
                {
                    return new global::Cartesia.JsonConverters.FineTuneStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListVoicesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.FineTunesListVoicesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.FineTunesListVoicesCartesiaVersionNullableJsonConverter();
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
                    0 => new FineTunesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}