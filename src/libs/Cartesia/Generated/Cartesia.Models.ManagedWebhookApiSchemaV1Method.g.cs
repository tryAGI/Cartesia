
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The HTTP method.
    /// </summary>
    public enum ManagedWebhookApiSchemaV1Method
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
    public static class ManagedWebhookApiSchemaV1MethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookApiSchemaV1Method value)
        {
            return value switch
            {
                ManagedWebhookApiSchemaV1Method.Delete => "DELETE",
                ManagedWebhookApiSchemaV1Method.Get => "GET",
                ManagedWebhookApiSchemaV1Method.Patch => "PATCH",
                ManagedWebhookApiSchemaV1Method.Post => "POST",
                ManagedWebhookApiSchemaV1Method.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookApiSchemaV1Method? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ManagedWebhookApiSchemaV1Method.Delete,
                "GET" => ManagedWebhookApiSchemaV1Method.Get,
                "PATCH" => ManagedWebhookApiSchemaV1Method.Patch,
                "POST" => ManagedWebhookApiSchemaV1Method.Post,
                "PUT" => ManagedWebhookApiSchemaV1Method.Put,
                _ => null,
            };
        }
    }
}