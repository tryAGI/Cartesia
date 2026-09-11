
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Credit usage for one value of the requested group-by dimension.
    /// </summary>
    public sealed partial class UsageCreditsBreakdownSeries
    {
        /// <summary>
        /// Identifier for the dimension value (capability id, model id, voice id, or API key id / sentinel such as `playground` or `unnamed_key`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label when available (voice name, API key description, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Daily credit buckets for this dimension value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket> Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCreditsBreakdownSeries" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the dimension value (capability id, model id, voice id, or API key id / sentinel such as `playground` or `unnamed_key`).
        /// </param>
        /// <param name="buckets">
        /// Daily credit buckets for this dimension value.
        /// </param>
        /// <param name="label">
        /// Human-readable label when available (voice name, API key description, etc.).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCreditsBreakdownSeries(
            string id,
            global::System.Collections.Generic.IList<global::Cartesia.UsageCreditsBucket> buckets,
            string? label)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label;
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCreditsBreakdownSeries" /> class.
        /// </summary>
        public UsageCreditsBreakdownSeries()
        {
        }

    }
}