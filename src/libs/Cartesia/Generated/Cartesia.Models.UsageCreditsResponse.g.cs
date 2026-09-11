
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageCreditsResponse
    {
        /// <summary>
        /// Dimension to break credit usage down by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UsageCreditsGroupByJsonConverter))]
        public global::Cartesia.UsageCreditsGroupBy? GroupBy { get; set; }

        /// <summary>
        /// Without `group_by`, flat credit usage buckets in chronological order. With `group_by`, one entry per dimension value; each item includes `id`, optional `label`, and nested daily `buckets`. Empty usage periods are returned with `credits: 0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCreditsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Without `group_by`, flat credit usage buckets in chronological order. With `group_by`, one entry per dimension value; each item includes `id`, optional `label`, and nested daily `buckets`. Empty usage periods are returned with `credits: 0`.
        /// </param>
        /// <param name="groupBy">
        /// Dimension to break credit usage down by.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCreditsResponse(
            global::System.Collections.Generic.IList<global::Cartesia.OneOf<global::Cartesia.UsageCreditsBucket, global::Cartesia.UsageCreditsBreakdownSeries>> data,
            global::Cartesia.UsageCreditsGroupBy? groupBy)
        {
            this.GroupBy = groupBy;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCreditsResponse" /> class.
        /// </summary>
        public UsageCreditsResponse()
        {
        }

    }
}