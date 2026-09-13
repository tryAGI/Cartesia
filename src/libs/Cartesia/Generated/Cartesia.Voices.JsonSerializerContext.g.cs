
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation), TypeInfoPropertyName = "GenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceExpandOptions), TypeInfoPropertyName = "VoiceExpandOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceStatus), TypeInfoPropertyName = "VoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccess), TypeInfoPropertyName = "VoiceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.VoiceAccentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccentsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceVisibility), TypeInfoPropertyName = "VoiceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccent), TypeInfoPropertyName = "VoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListAccentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.Accent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.Accent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataAccess), TypeInfoPropertyName = "VoiceMetadataAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataVisibility), TypeInfoPropertyName = "VoiceMetadataVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>), TypeInfoPropertyName = "OneOfUpdateVoiceRequestAccessEnumUpdateVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnum), TypeInfoPropertyName = "UpdateVoiceRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType), TypeInfoPropertyName = "UpdateVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceAccent), TypeInfoPropertyName = "LocalizeVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>), TypeInfoPropertyName = "OneOfLocalizeVoiceRequestAccessEnumLocalizeVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum), TypeInfoPropertyName = "LocalizeVoiceRequestAccessEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType), TypeInfoPropertyName = "LocalizeVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AddVoiceAccentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AttachVoiceAccent), TypeInfoPropertyName = "AttachVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequestAccess), TypeInfoPropertyName = "VoicesCloneRequestAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesListCartesiaVersion), TypeInfoPropertyName = "VoicesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AccentsListCartesiaVersion), TypeInfoPropertyName = "AccentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneCartesiaVersion), TypeInfoPropertyName = "VoicesCloneCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteCartesiaVersion), TypeInfoPropertyName = "VoicesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesUpdateCartesiaVersion), TypeInfoPropertyName = "VoicesUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesGetCartesiaVersion), TypeInfoPropertyName = "VoicesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesLocalizeCartesiaVersion), TypeInfoPropertyName = "VoicesLocalizeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion), TypeInfoPropertyName = "VoicesAddAccentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion), TypeInfoPropertyName = "VoicesDeleteAccentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GenderPresentation?), TypeInfoPropertyName = "NullableGenderPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceExpandOptions?), TypeInfoPropertyName = "NullableVoiceExpandOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceStatus?), TypeInfoPropertyName = "NullableVoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccess?), TypeInfoPropertyName = "NullableVoiceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceVisibility?), TypeInfoPropertyName = "NullableVoiceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceAccent?), TypeInfoPropertyName = "NullableVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.SupportedLanguage?), TypeInfoPropertyName = "NullableSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataAccess?), TypeInfoPropertyName = "NullableVoiceMetadataAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoiceMetadataVisibility?), TypeInfoPropertyName = "NullableVoiceMetadataVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfUpdateVoiceRequestAccessEnumUpdateVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnum?), TypeInfoPropertyName = "NullableUpdateVoiceRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType?), TypeInfoPropertyName = "NullableUpdateVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceAccent?), TypeInfoPropertyName = "NullableLocalizeVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OneOf<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>?), TypeInfoPropertyName = "NullableOneOfLocalizeVoiceRequestAccessEnumLocalizeVoiceRequestAccessEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum?), TypeInfoPropertyName = "NullableLocalizeVoiceRequestAccessEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType?), TypeInfoPropertyName = "NullableLocalizeVoiceRequestAccessEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AttachVoiceAccent?), TypeInfoPropertyName = "NullableAttachVoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneRequestAccess?), TypeInfoPropertyName = "NullableVoicesCloneRequestAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesListCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AccentsListCartesiaVersion?), TypeInfoPropertyName = "NullableAccentsListCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesCloneCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesCloneCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesDeleteCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesUpdateCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesUpdateCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesGetCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesGetCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesLocalizeCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesLocalizeCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesAddAccentsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion?), TypeInfoPropertyName = "NullableVoicesDeleteAccentCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.VoiceAccentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.Accent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AttachVoiceAccent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.VoiceExpandOptions>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.UpdateVoiceRequestAccessEnum?, global::Cartesia.UpdateVoiceRequestAccessEnum2>());
            options.Converters.Add(new global::Cartesia.JsonConverters.OneOfJsonConverter<global::Cartesia.LocalizeVoiceRequestAccessEnum?, global::Cartesia.LocalizeVoiceRequestAccessEnum2>());
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

                    || typeToConvert == typeof(global::Cartesia.VoiceExpandOptions)

                    || typeToConvert == typeof(global::Cartesia.VoiceExpandOptions?)

                    || typeToConvert == typeof(global::Cartesia.VoiceStatus)

                    || typeToConvert == typeof(global::Cartesia.VoiceStatus?)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccess)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccess?)

                    || typeToConvert == typeof(global::Cartesia.VoiceVisibility)

                    || typeToConvert == typeof(global::Cartesia.VoiceVisibility?)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.VoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.SupportedLanguage)

                    || typeToConvert == typeof(global::Cartesia.SupportedLanguage?)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess?)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility)

                    || typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility?)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType?)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.AttachVoiceAccent)

                    || typeToConvert == typeof(global::Cartesia.AttachVoiceAccent?)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess?)

                    || typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion?);
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

                if (typeToConvert == typeof(global::Cartesia.VoiceExpandOptions))
                {
                    return new global::Cartesia.JsonConverters.VoiceExpandOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceExpandOptions?))
                {
                    return new global::Cartesia.JsonConverters.VoiceExpandOptionsNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Cartesia.SupportedLanguage))
                {
                    return new global::Cartesia.JsonConverters.SupportedLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.SupportedLanguage?))
                {
                    return new global::Cartesia.JsonConverters.SupportedLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataAccess?))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoiceMetadataVisibility?))
                {
                    return new global::Cartesia.JsonConverters.VoiceMetadataVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateVoiceRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnum?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceRequestAccessEnumType?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceRequestAccessEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceAccentJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.LocalizeVoiceAccent?))
                {
                    return new global::Cartesia.JsonConverters.LocalizeVoiceAccentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AttachVoiceAccent))
                {
                    return new global::Cartesia.JsonConverters.AttachVoiceAccentJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AttachVoiceAccent?))
                {
                    return new global::Cartesia.JsonConverters.AttachVoiceAccentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneRequestAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneRequestAccess?))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneRequestAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.AccentsListCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.AccentsListCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.AccentsListCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesCloneCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesCloneCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesUpdateCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesUpdateCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesUpdateCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesGetCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesGetCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesGetCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesLocalizeCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesLocalizeCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesLocalizeCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesAddAccentsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesAddAccentsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesAddAccentsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteAccentCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.VoicesDeleteAccentCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.VoicesDeleteAccentCartesiaVersionNullableJsonConverter();
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
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}