
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A single bucket of agent usage within a time window.
    /// </summary>
    public sealed partial class UsageAgentsBucket
    {
        /// <summary>
        /// RFC 3339 timestamp for the start of the usage bucket.<br/>
        /// Example: 2026-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2026-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTs { get; set; }

        /// <summary>
        /// RFC 3339 timestamp for the end of the usage bucket.<br/>
        /// Example: 2026-01-02T00:00:00.000Z
        /// </summary>
        /// <example>2026-01-02T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTs { get; set; }

        /// <summary>
        /// Total cost in US cents accrued within the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cents { get; set; }

        /// <summary>
        /// Total minutes of agent runtime within the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Minutes { get; set; }

        /// <summary>
        /// Number of agent calls that started within the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentsBucket" /> class.
        /// </summary>
        /// <param name="startTs">
        /// RFC 3339 timestamp for the start of the usage bucket.<br/>
        /// Example: 2026-01-01T00:00:00.000Z
        /// </param>
        /// <param name="endTs">
        /// RFC 3339 timestamp for the end of the usage bucket.<br/>
        /// Example: 2026-01-02T00:00:00.000Z
        /// </param>
        /// <param name="cents">
        /// Total cost in US cents accrued within the bucket.
        /// </param>
        /// <param name="minutes">
        /// Total minutes of agent runtime within the bucket.
        /// </param>
        /// <param name="calls">
        /// Number of agent calls that started within the bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageAgentsBucket(
            global::System.DateTime startTs,
            global::System.DateTime endTs,
            int cents,
            double minutes,
            int calls)
        {
            this.StartTs = startTs;
            this.EndTs = endTs;
            this.Cents = cents;
            this.Minutes = minutes;
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentsBucket" /> class.
        /// </summary>
        public UsageAgentsBucket()
        {
        }

    }
}