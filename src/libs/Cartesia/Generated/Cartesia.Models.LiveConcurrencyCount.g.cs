
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveConcurrencyCount
    {
        /// <summary>
        /// How many are open now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Active { get; set; }

        /// <summary>
        /// The limit `active` counts against. Null when no limit applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveConcurrencyCount" /> class.
        /// </summary>
        /// <param name="active">
        /// How many are open now.
        /// </param>
        /// <param name="limit">
        /// The limit `active` counts against. Null when no limit applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveConcurrencyCount(
            int active,
            int? limit)
        {
            this.Active = active;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveConcurrencyCount" /> class.
        /// </summary>
        public LiveConcurrencyCount()
        {
        }

    }
}