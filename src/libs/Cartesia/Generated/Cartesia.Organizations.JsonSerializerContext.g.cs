
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PublicErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationUserRole), TypeInfoPropertyName = "OrganizationUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListUsersBadRequestError), TypeInfoPropertyName = "ListUsersBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UnexpectedErrorResponse), TypeInfoPropertyName = "UnexpectedErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetUserNotFoundError), TypeInfoPropertyName = "GetUserNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteRole), TypeInfoPropertyName = "OrganizationInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteStatus), TypeInfoPropertyName = "OrganizationInviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListInvitesBadRequestError), TypeInfoPropertyName = "ListInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateOrganizationInvitesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateInvitesBadRequestError), TypeInfoPropertyName = "CreateInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetInviteNotFoundError), TypeInfoPropertyName = "GetInviteNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsUsersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion), TypeInfoPropertyName = "DeleteOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesStatus), TypeInfoPropertyName = "GetOrganizationsInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion), TypeInfoPropertyName = "PostOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion), TypeInfoPropertyName = "GetOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion), TypeInfoPropertyName = "DeleteOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.OrganizationUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.OrganizationInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationUserRole?), TypeInfoPropertyName = "NullableOrganizationUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListUsersBadRequestError?), TypeInfoPropertyName = "NullableListUsersBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UnexpectedErrorResponse?), TypeInfoPropertyName = "NullableUnexpectedErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetUserNotFoundError?), TypeInfoPropertyName = "NullableGetUserNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteRole?), TypeInfoPropertyName = "NullableOrganizationInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.OrganizationInviteStatus?), TypeInfoPropertyName = "NullableOrganizationInviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListInvitesBadRequestError?), TypeInfoPropertyName = "NullableListInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.CreateInvitesBadRequestError?), TypeInfoPropertyName = "NullableCreateInvitesBadRequestError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetInviteNotFoundError?), TypeInfoPropertyName = "NullableGetInviteNotFoundError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsUsersCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteOrganizationsUsersByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesStatus?), TypeInfoPropertyName = "NullableGetOrganizationsInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion?), TypeInfoPropertyName = "NullablePostOrganizationsInvitesCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteOrganizationsInvitesByIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.OrganizationUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.OrganizationInvite>))]
    internal sealed partial class OrganizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.ListUsersBadRequestErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.UnexpectedErrorResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.GetUserNotFoundErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ListInvitesBadRequestErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.CreateInvitesBadRequestErrorJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.GetInviteNotFoundErrorJsonConverter());
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
                    typeToConvert == typeof(global::Cartesia.OrganizationUserRole)

                    || typeToConvert == typeof(global::Cartesia.OrganizationUserRole?)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteRole)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteRole?)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus)

                    || typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.OrganizationUserRole))
                {
                    return new global::Cartesia.JsonConverters.OrganizationUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationUserRole?))
                {
                    return new global::Cartesia.JsonConverters.OrganizationUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteRole))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteRole?))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.OrganizationInviteStatus?))
                {
                    return new global::Cartesia.JsonConverters.OrganizationInviteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsUsersByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsUsersByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsUsersByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsUsersByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsUsersByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesStatus?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PostOrganizationsInvitesCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostOrganizationsInvitesCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PostOrganizationsInvitesCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetOrganizationsInvitesByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetOrganizationsInvitesByIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsInvitesByIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteOrganizationsInvitesByIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteOrganizationsInvitesByIdCartesiaVersionNullableJsonConverter();
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
                    0 => new OrganizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}