
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentFallbackStrategyV1Explicit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentFallbackStrategyV1ExplicitTypeJsonConverter))]
        public global::Cartesia.ManagedAgentFallbackStrategyV1ExplicitType Type { get; set; }

        /// <summary>
        /// Model IDs to fall back to, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentFallbackStrategyV1Explicit" /> class.
        /// </summary>
        /// <param name="ids">
        /// Model IDs to fall back to, in order.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentFallbackStrategyV1Explicit(
            global::System.Collections.Generic.IList<string> ids,
            global::Cartesia.ManagedAgentFallbackStrategyV1ExplicitType type)
        {
            this.Type = type;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentFallbackStrategyV1Explicit" /> class.
        /// </summary>
        public ManagedAgentFallbackStrategyV1Explicit()
        {
        }

    }
}