
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedAgentSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PublicErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1), TypeInfoPropertyName = "ManagedToolDefinitionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1), TypeInfoPropertyName = "ManagedToolV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1DiscriminatorType), TypeInfoPropertyName = "ManagedToolV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType), TypeInfoPropertyName = "ManagedToolDefinitionV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode), TypeInfoPropertyName = "ManagedWebhookToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech), TypeInfoPropertyName = "ManagedWebhookToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1Type), TypeInfoPropertyName = "ManagedWebhookToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1ExecutionMode), TypeInfoPropertyName = "ManagedClientToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolParametersV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech), TypeInfoPropertyName = "ManagedClientToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1Type), TypeInfoPropertyName = "ManagedClientToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode), TypeInfoPropertyName = "ManagedWebhookToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech), TypeInfoPropertyName = "ManagedWebhookToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type), TypeInfoPropertyName = "ManagedWebhookToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode), TypeInfoPropertyName = "ManagedClientToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech), TypeInfoPropertyName = "ManagedClientToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1Type), TypeInfoPropertyName = "ManagedClientToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponse), TypeInfoPropertyName = "WebhookAuthenticationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod), TypeInfoPropertyName = "ManagedWebhookApiSchemaV1ResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookPathParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookPathParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQuerySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookBodyParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse>), TypeInfoPropertyName = "AnyOfStringWebhookSecretResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.ClientToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolParametersV1Type), TypeInfoPropertyName = "ManagedClientToolParametersV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthentication), TypeInfoPropertyName = "WebhookAuthentication2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method), TypeInfoPropertyName = "ManagedWebhookApiSchemaV1Method2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret>), TypeInfoPropertyName = "AnyOfStringWebhookSecret2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode), TypeInfoPropertyName = "WebhookAuthenticationResponseVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode), TypeInfoPropertyName = "WebhookAuthenticationResponseVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, double?, bool?>), TypeInfoPropertyName = "AnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.AnyOf<string, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookPathParamType), TypeInfoPropertyName = "WebhookPathParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookQueryParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.WebhookBodyParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookBodyParamType), TypeInfoPropertyName = "WebhookBodyParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretResponseType), TypeInfoPropertyName = "WebhookSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamItemsType), TypeInfoPropertyName = "ClientToolParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamType), TypeInfoPropertyName = "ClientToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant1Mode), TypeInfoPropertyName = "WebhookAuthenticationVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant2Mode), TypeInfoPropertyName = "WebhookAuthenticationVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretType), TypeInfoPropertyName = "WebhookSecretType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamItemsType), TypeInfoPropertyName = "WebhookQueryParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamType), TypeInfoPropertyName = "WebhookQueryParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ListManagedToolsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.ManagedToolV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1Request), TypeInfoPropertyName = "UpdateManagedToolV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod), TypeInfoPropertyName = "UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode), TypeInfoPropertyName = "UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech), TypeInfoPropertyName = "UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode), TypeInfoPropertyName = "UpdateManagedToolV1RequestClientToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech), TypeInfoPropertyName = "UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion), TypeInfoPropertyName = "PostV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsType), TypeInfoPropertyName = "GetV1AgentsToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem), TypeInfoPropertyName = "GetV1AgentsToolsByToolIdExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion), TypeInfoPropertyName = "GetV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion), TypeInfoPropertyName = "PatchV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion), TypeInfoPropertyName = "DeleteV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1?), TypeInfoPropertyName = "NullableManagedToolDefinitionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1?), TypeInfoPropertyName = "NullableManagedToolV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolV1DiscriminatorType?), TypeInfoPropertyName = "NullableManagedToolV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType?), TypeInfoPropertyName = "NullableManagedToolDefinitionV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedWebhookToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedWebhookToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolV1Type?), TypeInfoPropertyName = "NullableManagedWebhookToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedClientToolV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedClientToolV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolV1Type?), TypeInfoPropertyName = "NullableManagedClientToolV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedWebhookToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedWebhookToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type?), TypeInfoPropertyName = "NullableManagedWebhookToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode?), TypeInfoPropertyName = "NullableManagedClientToolDefinitionV1ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?), TypeInfoPropertyName = "NullableManagedClientToolDefinitionV1PreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolDefinitionV1Type?), TypeInfoPropertyName = "NullableManagedClientToolDefinitionV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponse?), TypeInfoPropertyName = "NullableWebhookAuthenticationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod?), TypeInfoPropertyName = "NullableManagedWebhookApiSchemaV1ResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecretResponse>?), TypeInfoPropertyName = "NullableAnyOfStringWebhookSecretResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedClientToolParametersV1Type?), TypeInfoPropertyName = "NullableManagedClientToolParametersV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthentication?), TypeInfoPropertyName = "NullableWebhookAuthentication2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method?), TypeInfoPropertyName = "NullableManagedWebhookApiSchemaV1Method2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, global::Cartesia.WebhookSecret>?), TypeInfoPropertyName = "NullableAnyOfStringWebhookSecret2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationResponseVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationResponseVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.AnyOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookPathParamType?), TypeInfoPropertyName = "NullableWebhookPathParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookBodyParamType?), TypeInfoPropertyName = "NullableWebhookBodyParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretResponseType?), TypeInfoPropertyName = "NullableWebhookSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamItemsType?), TypeInfoPropertyName = "NullableClientToolParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.ClientToolParamType?), TypeInfoPropertyName = "NullableClientToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant1Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookAuthenticationVariant2Mode?), TypeInfoPropertyName = "NullableWebhookAuthenticationVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookSecretType?), TypeInfoPropertyName = "NullableWebhookSecretType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamItemsType?), TypeInfoPropertyName = "NullableWebhookQueryParamItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.WebhookQueryParamType?), TypeInfoPropertyName = "NullableWebhookQueryParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1Request?), TypeInfoPropertyName = "NullableUpdateManagedToolV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestWebhookToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestClientToolUpdateExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?), TypeInfoPropertyName = "NullableUpdateManagedToolV1RequestClientToolUpdatePreToolSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion?), TypeInfoPropertyName = "NullablePostV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsType?), TypeInfoPropertyName = "NullableGetV1AgentsToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsToolsCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem?), TypeInfoPropertyName = "NullableGetV1AgentsToolsByToolIdExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion?), TypeInfoPropertyName = "NullableGetV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion?), TypeInfoPropertyName = "NullablePatchV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion?), TypeInfoPropertyName = "NullableDeleteV1AgentsToolsByToolIdCartesiaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedAgentSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.AnyOf<string, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.ManagedToolV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cartesia.GetV1AgentsToolsByToolIdExpandItem>))]
    internal sealed partial class AgentToolsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentToolsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentToolsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Cartesia.JsonConverters.ManagedToolV1JsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.ManagedToolDefinitionV1JsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.WebhookAuthenticationResponseJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.WebhookAuthenticationJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestJsonConverter());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, global::Cartesia.WebhookSecretResponse>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, global::Cartesia.WebhookSecret>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Cartesia.JsonConverters.AnyOfJsonConverter<string, global::Cartesia.WebhookSecret>());
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
                    typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType)

                    || typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod?)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type)

                    || typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type?)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method)

                    || typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookPathParamType)

                    || typeToConvert == typeof(global::Cartesia.WebhookPathParamType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookBodyParamType)

                    || typeToConvert == typeof(global::Cartesia.WebhookBodyParamType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType?)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType?)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamType)

                    || typeToConvert == typeof(global::Cartesia.ClientToolParamType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode)

                    || typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode?)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretType)

                    || typeToConvert == typeof(global::Cartesia.WebhookSecretType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType?)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamType)

                    || typeToConvert == typeof(global::Cartesia.WebhookQueryParamType?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode?)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech)

                    || typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?)

                    || typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem?)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion?)

                    || typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion)

                    || typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolV1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolV1DiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolV1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolDefinitionV1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedToolDefinitionV1DiscriminatorType?))
                {
                    return new global::Cartesia.JsonConverters.ManagedToolDefinitionV1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookToolDefinitionV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookToolDefinitionV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1ExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1PreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1PreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolDefinitionV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolDefinitionV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1ResponseMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1ResponseMethod?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1ResponseMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolParametersV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedClientToolParametersV1Type?))
                {
                    return new global::Cartesia.JsonConverters.ManagedClientToolParametersV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1MethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ManagedWebhookApiSchemaV1Method?))
                {
                    return new global::Cartesia.JsonConverters.ManagedWebhookApiSchemaV1MethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant1Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationResponseVariant2Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationResponseVariant2ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookPathParamType))
                {
                    return new global::Cartesia.JsonConverters.WebhookPathParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookPathParamType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookPathParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookBodyParamType))
                {
                    return new global::Cartesia.JsonConverters.WebhookBodyParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookBodyParamType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookBodyParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretResponseType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamItemsType?))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamType))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.ClientToolParamType?))
                {
                    return new global::Cartesia.JsonConverters.ClientToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant1Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookAuthenticationVariant2Mode?))
                {
                    return new global::Cartesia.JsonConverters.WebhookAuthenticationVariant2ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretType))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookSecretType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookSecretTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamItemsType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamType))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.WebhookQueryParamType?))
                {
                    return new global::Cartesia.JsonConverters.WebhookQueryParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdateExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestWebhookToolUpdatePreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdateExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdateExecutionMode?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdateExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?))
                {
                    return new global::Cartesia.JsonConverters.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PostV1AgentsToolsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PostV1AgentsToolsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PostV1AgentsToolsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsType?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdExpandItem?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.GetV1AgentsToolsByToolIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.GetV1AgentsToolsByToolIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.PatchV1AgentsToolsByToolIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.PatchV1AgentsToolsByToolIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.PatchV1AgentsToolsByToolIdCartesiaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion))
                {
                    return new global::Cartesia.JsonConverters.DeleteV1AgentsToolsByToolIdCartesiaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion?))
                {
                    return new global::Cartesia.JsonConverters.DeleteV1AgentsToolsByToolIdCartesiaVersionNullableJsonConverter();
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
                    0 => new AgentToolsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}