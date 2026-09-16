
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding), TypeInfoPropertyName = "RawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer), TypeInfoPropertyName = "OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEEvent), TypeInfoPropertyName = "VoiceChangerSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEErrorType), TypeInfoPropertyName = "VoiceChangerSSEErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion), TypeInfoPropertyName = "VoiceChangerBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseCartesiaVersion), TypeInfoPropertyName = "VoiceChangerSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding?), TypeInfoPropertyName = "NullableRawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormatContainer?), TypeInfoPropertyName = "NullableOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEEvent?), TypeInfoPropertyName = "NullableVoiceChangerSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSSEErrorType?), TypeInfoPropertyName = "NullableVoiceChangerSSEErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion?), TypeInfoPropertyName = "NullableVoiceChangerBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceChangerSseCartesiaVersion?), TypeInfoPropertyName = "NullableVoiceChangerSseCartesiaVersion2")]
    internal sealed partial class VoiceChangerSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceChangerSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoiceChangerSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoiceChangerSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.VoiceChangerSSEEventJsonConverter());
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
                    typeToConvert == typeof(global::Cartesia.RawEncoding)

                    || typeToConvert == typeof(global::Cartesia.RawEncoding?)

                    || typeToConvert == typeof(global::Cartesia.OutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.OutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType?)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion?);
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

                if (typeToConvert == typeof(global::Cartesia.OutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.OutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.OutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSSEErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSSEErrorType?))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSSEErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerBytesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerBytesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerBytesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSseCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceChangerSseCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoiceChangerSseCartesiaVersionNullableJsonConverter();
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
                    0 => new VoiceChangerSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}