
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSModelID), TypeInfoPropertyName = "TTSModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifier), TypeInfoPropertyName = "TTSRequestVoiceSpecifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Emotion), TypeInfoPropertyName = "Emotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormatContainer), TypeInfoPropertyName = "WAVOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding), TypeInfoPropertyName = "RawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormatContainer), TypeInfoPropertyName = "MP3OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormatContainer), TypeInfoPropertyName = "RawOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSERequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEvent), TypeInfoPropertyName = "TTSSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEventDiscriminatorType), TypeInfoPropertyName = "TTSSSEEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormatContainer), TypeInfoPropertyName = "SSEOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEventType), TypeInfoPropertyName = "TTSSSEChunkEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventType), TypeInfoPropertyName = "TTSSSETimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventWordTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType), TypeInfoPropertyName = "TTSSSEPhonemeTimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventPhonemeTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEventType), TypeInfoPropertyName = "TTSSSEDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEventType), TypeInfoPropertyName = "TTSSSEErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsBytesCartesiaVersion), TypeInfoPropertyName = "TtsBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsSseCartesiaVersion), TypeInfoPropertyName = "TtsSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSModelID?), TypeInfoPropertyName = "NullableTTSModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSRequestVoiceSpecifier?), TypeInfoPropertyName = "NullableTTSRequestVoiceSpecifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutputFormat?), TypeInfoPropertyName = "NullableOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Emotion?), TypeInfoPropertyName = "NullableEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WAVOutputFormatContainer?), TypeInfoPropertyName = "NullableWAVOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawEncoding?), TypeInfoPropertyName = "NullableRawEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.MP3OutputFormatContainer?), TypeInfoPropertyName = "NullableMP3OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.RawOutputFormatContainer?), TypeInfoPropertyName = "NullableRawOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEvent?), TypeInfoPropertyName = "NullableTTSSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEEventDiscriminatorType?), TypeInfoPropertyName = "NullableTTSSSEEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SSEOutputFormatContainer?), TypeInfoPropertyName = "NullableSSEOutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEChunkEventType?), TypeInfoPropertyName = "NullableTTSSSEChunkEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSETimestampsEventType?), TypeInfoPropertyName = "NullableTTSSSETimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType?), TypeInfoPropertyName = "NullableTTSSSEPhonemeTimestampsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEDoneEventType?), TypeInfoPropertyName = "NullableTTSSSEDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TTSSSEErrorEventType?), TypeInfoPropertyName = "NullableTTSSSEErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsBytesCartesiaVersion?), TypeInfoPropertyName = "NullableTtsBytesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TtsSseCartesiaVersion?), TypeInfoPropertyName = "NullableTtsSseCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    internal sealed partial class TtsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TtsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TtsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TtsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.TTSRequestVoiceSpecifierJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.OutputFormatJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.TTSSSEEventJsonConverter());
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
                    typeToConvert == typeof(global::Cartesia.TTSModelID)

                    || typeToConvert == typeof(global::Cartesia.TTSModelID?)

                    || typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.Emotion)

                    || typeToConvert == typeof(global::Cartesia.Emotion?)

                    || typeToConvert == typeof(global::Cartesia.RawEncoding)

                    || typeToConvert == typeof(global::Cartesia.RawEncoding?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer)

                    || typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType?)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType)

                    || typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType?)

                    || typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.TTSModelID))
                {
                    return new global::Cartesia.JsonConverters.TTSModelIDJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSModelID?))
                {
                    return new global::Cartesia.JsonConverters.TTSModelIDNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.WAVOutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WAVOutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.WAVOutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.MP3OutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.MP3OutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.MP3OutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.RawOutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawOutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.RawOutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.Emotion))
                {
                    return new global::Cartesia.JsonConverters.EmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.Emotion?))
                {
                    return new global::Cartesia.JsonConverters.EmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawEncoding))
                {
                    return new global::Cartesia.JsonConverters.RawEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.RawEncoding?))
                {
                    return new global::Cartesia.JsonConverters.RawEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEEventDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer))
                {
                    return new global::Cartesia.JsonConverters.SSEOutputFormatContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SSEOutputFormatContainer?))
                {
                    return new global::Cartesia.JsonConverters.SSEOutputFormatContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEChunkEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEChunkEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEChunkEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSETimestampsEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSETimestampsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEPhonemeTimestampsEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEPhonemeTimestampsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEDoneEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TTSSSEErrorEventType?))
                {
                    return new global::Cartesia.JsonConverters.TTSSSEErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.TtsBytesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsBytesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.TtsBytesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.TtsSseCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TtsSseCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.TtsSseCartesiaVersionNullableJsonConverter();
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
                    0 => new TtsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}