
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentModelV1
    {
        /// <summary>
        /// Average response latency in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_latency_ms")]
        public long? AverageLatencyMs { get; set; }

        /// <summary>
        /// Description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Display name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Model ID used in agent configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentModelV1Pricing Pricing { get; set; }

        /// <summary>
        /// Company that provides the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentModelV1" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name of the model.
        /// </param>
        /// <param name="id">
        /// Model ID used in agent configuration.
        /// </param>
        /// <param name="pricing"></param>
        /// <param name="provider">
        /// Company that provides the model.
        /// </param>
        /// <param name="averageLatencyMs">
        /// Average response latency in milliseconds.
        /// </param>
        /// <param name="description">
        /// Description of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentModelV1(
            string displayName,
            string id,
            global::Cartesia.ManagedAgentModelV1Pricing pricing,
            string provider,
            long? averageLatencyMs,
            string? description)
        {
            this.AverageLatencyMs = averageLatencyMs;
            this.Description = description;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentModelV1" /> class.
        /// </summary>
        public ManagedAgentModelV1()
        {
        }

    }
}