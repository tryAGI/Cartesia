
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A single bucket of credit usage within a time window.
    /// </summary>
    public sealed partial class UsageCreditsBucket
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
        /// Total credits consumed within the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCreditsBucket" /> class.
        /// </summary>
        /// <param name="startTs">
        /// RFC 3339 timestamp for the start of the usage bucket.<br/>
        /// Example: 2026-01-01T00:00:00.000Z
        /// </param>
        /// <param name="endTs">
        /// RFC 3339 timestamp for the end of the usage bucket.<br/>
        /// Example: 2026-01-02T00:00:00.000Z
        /// </param>
        /// <param name="credits">
        /// Total credits consumed within the bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCreditsBucket(
            global::System.DateTime startTs,
            global::System.DateTime endTs,
            int credits)
        {
            this.StartTs = startTs;
            this.EndTs = endTs;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCreditsBucket" /> class.
        /// </summary>
        public UsageCreditsBucket()
        {
        }

    }
}