
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The HTTP method.
    /// </summary>
    public enum ManagedWebhookApiSchemaV1ResponseMethod
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Get,
        /// <summary>
        ///
        /// </summary>
        Patch,
        /// <summary>
        ///
        /// </summary>
        Post,
        /// <summary>
        ///
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedWebhookApiSchemaV1ResponseMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookApiSchemaV1ResponseMethod value)
        {
            return value switch
            {
                ManagedWebhookApiSchemaV1ResponseMethod.Delete => "DELETE",
                ManagedWebhookApiSchemaV1ResponseMethod.Get => "GET",
                ManagedWebhookApiSchemaV1ResponseMethod.Patch => "PATCH",
                ManagedWebhookApiSchemaV1ResponseMethod.Post => "POST",
                ManagedWebhookApiSchemaV1ResponseMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookApiSchemaV1ResponseMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ManagedWebhookApiSchemaV1ResponseMethod.Delete,
                "GET" => ManagedWebhookApiSchemaV1ResponseMethod.Get,
                "PATCH" => ManagedWebhookApiSchemaV1ResponseMethod.Patch,
                "POST" => ManagedWebhookApiSchemaV1ResponseMethod.Post,
                "PUT" => ManagedWebhookApiSchemaV1ResponseMethod.Put,
                _ => null,
            };
        }
    }
}