
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMetricsResponse
    {
        /// <summary>
        /// List of metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.Metric> Data { get; set; }

        /// <summary>
        /// Whether there are more pages of metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// An ID that can be passed as `starting_after` or `ending_before` to get the next page of metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetricsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of metrics.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more pages of metrics.
        /// </param>
        /// <param name="nextPage">
        /// An ID that can be passed as `starting_after` or `ending_before` to get the next page of metrics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMetricsResponse(
            global::System.Collections.Generic.IList<global::Cartesia.Metric> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetricsResponse" /> class.
        /// </summary>
        public ListMetricsResponse()
        {
        }

    }
}