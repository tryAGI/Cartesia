
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The HTTP method.
    /// </summary>
    public enum UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod
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
    public static class UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod value)
        {
            return value switch
            {
                UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Delete => "DELETE",
                UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Get => "GET",
                UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Patch => "PATCH",
                UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Post => "POST",
                UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Delete,
                "GET" => UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Get,
                "PATCH" => UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Patch,
                "POST" => UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Post,
                "PUT" => UpdateManagedToolV1RequestWebhookToolUpdateApiSchemaMethod.Put,
                _ => null,
            };
        }
    }
}