
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageInterval), TypeInfoPropertyName = "UsageInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsGroupBy), TypeInfoPropertyName = "UsageCreditsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>), TypeInfoPropertyName = "OneOfUsageCreditsBucketUsageCreditsBreakdownSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsBreakdownSeries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsCartesiaVersion), TypeInfoPropertyName = "UsageCreditsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsCartesiaVersion), TypeInfoPropertyName = "UsageAgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageInterval?), TypeInfoPropertyName = "NullableUsageInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsGroupBy?), TypeInfoPropertyName = "NullableUsageCreditsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>?), TypeInfoPropertyName = "NullableOneOfUsageCreditsBucketUsageCreditsBreakdownSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageCreditsCartesiaVersion?), TypeInfoPropertyName = "NullableUsageCreditsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UsageAgentsCartesiaVersion?), TypeInfoPropertyName = "NullableUsageAgentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.UsageCreditsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.UsageAgentsBucket>))]
    internal sealed partial class UsageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>());
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
                    typeToConvert == typeof(global::Cartesia.UsageInterval)

                    || typeToConvert == typeof(global::Cartesia.UsageInterval?)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy?)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.UsageInterval))
                {
                    return new global::Cartesia.JsonConverters.UsageIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageInterval?))
                {
                    return new global::Cartesia.JsonConverters.UsageIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsGroupBy?))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageCreditsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.UsageCreditsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.UsageAgentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UsageAgentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.UsageAgentsCartesiaVersionNullableJsonConverter();
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
                    0 => new UsageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}