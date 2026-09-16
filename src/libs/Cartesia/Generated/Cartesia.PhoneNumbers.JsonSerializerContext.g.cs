
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberResponse), TypeInfoPropertyName = "PhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponse), TypeInfoPropertyName = "ProviderResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberBaseResponseAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CartesiaProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkEmbeddedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponseDiscriminatorType), TypeInfoPropertyName = "ProviderResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponseType), TypeInfoPropertyName = "TwilioProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyRegion), TypeInfoPropertyName = "TelephonyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CartesiaProviderResponseType), TypeInfoPropertyName = "CartesiaProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkEmbeddedResponseType), TypeInfoPropertyName = "SIPTrunkEmbeddedResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>), TypeInfoPropertyName = "OneOfImportPhoneNumberBodyProviderByIdImportPhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType), TypeInfoPropertyName = "ImportPhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvisionPhoneNumberBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvisionPhoneNumberResponse), TypeInfoPropertyName = "ProvisionPhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>), TypeInfoPropertyName = "OneOfUpdatePhoneNumberBodyProviderByIdUpdatePhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType), TypeInfoPropertyName = "UpdatePhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListType), TypeInfoPropertyName = "PhoneNumbersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersImportCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion), TypeInfoPropertyName = "PhoneNumbersProvisionCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.PhoneNumberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumberResponse?), TypeInfoPropertyName = "NullablePhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponse?), TypeInfoPropertyName = "NullableProviderResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProviderResponseDiscriminatorType?), TypeInfoPropertyName = "NullableProviderResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TwilioProviderResponseType?), TypeInfoPropertyName = "NullableTwilioProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.TelephonyRegion?), TypeInfoPropertyName = "NullableTelephonyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CartesiaProviderResponseType?), TypeInfoPropertyName = "NullableCartesiaProviderResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SIPTrunkEmbeddedResponseType?), TypeInfoPropertyName = "NullableSIPTrunkEmbeddedResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>?), TypeInfoPropertyName = "NullableOneOfImportPhoneNumberBodyProviderByIdImportPhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType?), TypeInfoPropertyName = "NullableImportPhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ProvisionPhoneNumberResponse?), TypeInfoPropertyName = "NullableProvisionPhoneNumberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>?), TypeInfoPropertyName = "NullableOneOfUpdatePhoneNumberBodyProviderByIdUpdatePhoneNumberBodyProviderByTwilioAccount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType?), TypeInfoPropertyName = "NullableUpdatePhoneNumberBodyProviderByTwilioAccountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersListType?), TypeInfoPropertyName = "NullablePhoneNumbersListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersImportCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion?), TypeInfoPropertyName = "NullablePhoneNumbersProvisionCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.PhoneNumberResponse>))]
    internal sealed partial class PhoneNumbersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneNumbersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PhoneNumbersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PhoneNumbersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.PhoneNumberResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ProviderResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ProvisionPhoneNumberResponseJsonConverter());
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
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.ImportPhoneNumberBodyProviderById, global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccount>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdatePhoneNumberBodyProviderById, global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccount>());
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
                    typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType)

                    || typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType?)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType)

                    || typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType?)

                    || typeToConvert == typeof(global::Cartesia.TelephonyRegion)

                    || typeToConvert == typeof(global::Cartesia.TelephonyRegion?)

                    || typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType)

                    || typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType?)

                    || typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType)

                    || typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListType)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersListType?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ProviderResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ProviderResponseDiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ProviderResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.TwilioProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TwilioProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.TwilioProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType))
                {
                    return new global::Cartesia.JsonConverters.CartesiaProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.CartesiaProviderResponseType?))
                {
                    return new global::Cartesia.JsonConverters.CartesiaProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkEmbeddedResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SIPTrunkEmbeddedResponseType?))
                {
                    return new global::Cartesia.JsonConverters.SIPTrunkEmbeddedResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyRegion))
                {
                    return new global::Cartesia.JsonConverters.TelephonyRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.TelephonyRegion?))
                {
                    return new global::Cartesia.JsonConverters.TelephonyRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType))
                {
                    return new global::Cartesia.JsonConverters.ImportPhoneNumberBodyProviderByTwilioAccountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ImportPhoneNumberBodyProviderByTwilioAccountType?))
                {
                    return new global::Cartesia.JsonConverters.ImportPhoneNumberBodyProviderByTwilioAccountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType))
                {
                    return new global::Cartesia.JsonConverters.UpdatePhoneNumberBodyProviderByTwilioAccountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdatePhoneNumberBodyProviderByTwilioAccountType?))
                {
                    return new global::Cartesia.JsonConverters.UpdatePhoneNumberBodyProviderByTwilioAccountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListType))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersListType?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersImportCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersImportCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersImportCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersProvisionCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PhoneNumbersProvisionCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PhoneNumbersProvisionCartesiaVersionNullableJsonConverter();
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
                    0 => new PhoneNumbersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}