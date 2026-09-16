
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponseType), TypeInfoPropertyName = "TwilioProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyRegion), TypeInfoPropertyName = "TelephonyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponse), TypeInfoPropertyName = "ProviderAccountResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType), TypeInfoPropertyName = "ProviderAccountResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkProviderResponseType), TypeInfoPropertyName = "SIPTrunkProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkInboundDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkOutboundDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPMediaEncryption), TypeInfoPropertyName = "SIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkTransport), TypeInfoPropertyName = "SIPTrunkTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBody), TypeInfoPropertyName = "CreateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateTwilioProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateSIPProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBodyDiscriminatorType), TypeInfoPropertyName = "CreateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateTwilioProviderBodyType), TypeInfoPropertyName = "CreateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateSIPProviderBodyType), TypeInfoPropertyName = "CreateSIPProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.InboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OutboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBody), TypeInfoPropertyName = "UpdateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateTwilioProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPTrunkProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType), TypeInfoPropertyName = "UpdateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateTwilioProviderBodyType), TypeInfoPropertyName = "UpdateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType), TypeInfoPropertyName = "UpdateSIPTrunkProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateInboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateOutboundSIPTrunkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListCartesiaVersion), TypeInfoPropertyName = "ProvidersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListType), TypeInfoPropertyName = "ProvidersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersCreateCartesiaVersion), TypeInfoPropertyName = "ProvidersCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersGetCartesiaVersion), TypeInfoPropertyName = "ProvidersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersUpdateCartesiaVersion), TypeInfoPropertyName = "ProvidersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersDeleteCartesiaVersion), TypeInfoPropertyName = "ProvidersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ProviderAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponseType?), TypeInfoPropertyName = "NullableTwilioProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyRegion?), TypeInfoPropertyName = "NullableTelephonyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponse?), TypeInfoPropertyName = "NullableProviderAccountResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType?), TypeInfoPropertyName = "NullableProviderAccountResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkProviderResponseType?), TypeInfoPropertyName = "NullableSIPTrunkProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPMediaEncryption?), TypeInfoPropertyName = "NullableSIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkTransport?), TypeInfoPropertyName = "NullableSIPTrunkTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBody?), TypeInfoPropertyName = "NullableCreateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateProviderBodyDiscriminatorType?), TypeInfoPropertyName = "NullableCreateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateTwilioProviderBodyType?), TypeInfoPropertyName = "NullableCreateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateSIPProviderBodyType?), TypeInfoPropertyName = "NullableCreateSIPProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBody?), TypeInfoPropertyName = "NullableUpdateProviderBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateProviderBodyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateTwilioProviderBodyType?), TypeInfoPropertyName = "NullableUpdateTwilioProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType?), TypeInfoPropertyName = "NullableUpdateSIPTrunkProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersListType?), TypeInfoPropertyName = "NullableProvidersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersCreateCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersCreateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersGetCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvidersDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableProvidersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ProviderAccountResponse>))]
    internal sealed partial class ProvidersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvidersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProvidersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProvidersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.ProviderAccountResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.CreateProviderBodyJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.UpdateProviderBodyJsonConverter());
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
                    typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.TelephonyRegion)

                    || typeToConvert == typeof(global::Cartesia.TelephonyRegion?)

                    || typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.SIPMediaEncryption)

                    || typeToConvert == typeof(global::Cartesia.SIPMediaEncryption?)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkTransport)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkTransport?)

                    || typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType)

                    || typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListType)

                    || typeToConvert == typeof(global::Cartesia.ProvidersListType?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.TwilioProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.TwilioProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyRegion))
                {
                    return new global::Cartesia.JsonConverters.TelephonyRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyRegion?))
                {
                    return new global::Cartesia.JsonConverters.TelephonyRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ProviderAccountResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderAccountResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ProviderAccountResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPMediaEncryption))
                {
                    return new global::Cartesia.JsonConverters.SIPMediaEncryptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPMediaEncryption?))
                {
                    return new global::Cartesia.JsonConverters.SIPMediaEncryptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkTransport))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkTransport?))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.CreateProviderBodyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateProviderBodyDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.CreateProviderBodyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.CreateTwilioProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateTwilioProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.CreateTwilioProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.CreateSIPProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CreateSIPProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.CreateSIPProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.UpdateProviderBodyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateProviderBodyDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateProviderBodyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.UpdateTwilioProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateTwilioProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateTwilioProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType))
                {
                    return new global::Cartesia.JsonConverters.UpdateSIPTrunkProviderBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateSIPTrunkProviderBodyType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateSIPTrunkProviderBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListType))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersListType?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersCreateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersCreateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersCreateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.ProvidersDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProvidersDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.ProvidersDeleteCartesiaVersionNullableJsonConverter();
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
                    0 => new ProvidersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}