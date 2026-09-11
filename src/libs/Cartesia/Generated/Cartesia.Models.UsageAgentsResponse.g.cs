
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageAgentsResponse
    {
        /// <summary>
        /// Agent usage buckets in chronological order. Buckets with no recorded activity are returned with zero values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Agent usage buckets in chronological order. Buckets with no recorded activity are returned with zero values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageAgentsResponse(
            global::System.Collections.Generic.IList<global::Cartesia.UsageAgentsBucket> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentsResponse" /> class.
        /// </summary>
        public UsageAgentsResponse()
        {
        }

    }
}