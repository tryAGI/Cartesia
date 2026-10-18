
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigModel
    {
        /// <summary>
        /// Model ID from `GET /v1/agents/models`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Models to fall back to when the primary model fails before it starts responding. `auto` uses Cartesia-managed fallback models. `explicit` uses up to three model IDs from `GET /v1/agents/models`, in order. Set to `null` to disable fallback. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentFallbackStrategyV1JsonConverter))]
        public global::Cartesia.ManagedAgentFallbackStrategyV1? FallbackStrategy { get; set; }

        /// <summary>
        /// Maximum number of tokens the model can generate, from `1` to `4096`. Set to `null` for no limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Controls the randomness of model responses, from `0` to `1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Model ID from `GET /v1/agents/models`.
        /// </param>
        /// <param name="fallbackStrategy">
        /// Models to fall back to when the primary model fails before it starts responding. `auto` uses Cartesia-managed fallback models. `explicit` uses up to three model IDs from `GET /v1/agents/models`, in order. Set to `null` to disable fallback. Defaults to `auto`.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of tokens the model can generate, from `1` to `4096`. Set to `null` for no limit.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of model responses, from `0` to `1`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigModel(
            string? id,
            global::Cartesia.ManagedAgentFallbackStrategyV1? fallbackStrategy,
            int? maxOutputTokens,
            double? temperature)
        {
            this.Id = id;
            this.FallbackStrategy = fallbackStrategy;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigModel" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigModel()
        {
        }

    }
}