
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageConcurrencyHistoryResponse
    {
        /// <summary>
        /// Buckets in chronological order. Buckets with no recorded concurrency are left out, not returned as zeros.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.UsageConcurrencyHistoryPoint> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageConcurrencyHistoryResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Buckets in chronological order. Buckets with no recorded concurrency are left out, not returned as zeros.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageConcurrencyHistoryResponse(
            global::System.Collections.Generic.IList<global::Cartesia.UsageConcurrencyHistoryPoint> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageConcurrencyHistoryResponse" /> class.
        /// </summary>
        public UsageConcurrencyHistoryResponse()
        {
        }

    }
}