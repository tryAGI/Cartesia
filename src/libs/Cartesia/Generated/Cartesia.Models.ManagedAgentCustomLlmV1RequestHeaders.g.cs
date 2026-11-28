
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Headers included in each request, at most 32. Names are case-insensitively unique and use up to 128 letters, digits, hyphens, or underscores. Values are printable ASCII, up to 16 KiB each. `Accept`, `Accept-Encoding`, `Idempotency-Key`, `Host`, `Content-Type`, `Content-Length`, and hop-by-hop headers are reserved, and an `Authorization` header must be a secret. Secret values are never returned.
    /// </summary>
    public sealed partial class ManagedAgentCustomLlmV1RequestHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}