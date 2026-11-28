
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigModel
    {
        /// <summary>
        /// Model ID from `GET /v1/agents/models`, or `custom_llm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Models to try when the primary fails before responding. `auto` selects Cartesia-managed fallbacks (the default for new managed-model agents); `explicit` tries up to three managed model IDs in order; `null` disables fallback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentFallbackStrategyV1JsonConverter))]
        public global::Cartesia.ManagedAgentFallbackStrategyV1? FallbackStrategy { get; set; }

        /// <summary>
        /// An OpenAI-compatible Chat Completions endpoint. Requires `model.id` to be `custom_llm`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm")]
        public global::Cartesia.ManagedAgentCustomLlmV1? CustomLlm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Model ID from `GET /v1/agents/models`, or `custom_llm`
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of tokens the model can generate, from `1` to `4096`. Set to `null` for no limit.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of model responses, from `0` to `1`.
        /// </param>
        /// <param name="fallbackStrategy">
        /// Models to try when the primary fails before responding. `auto` selects Cartesia-managed fallbacks (the default for new managed-model agents); `explicit` tries up to three managed model IDs in order; `null` disables fallback.
        /// </param>
        /// <param name="customLlm">
        /// An OpenAI-compatible Chat Completions endpoint. Requires `model.id` to be `custom_llm`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigModel(
            string? id,
            int? maxOutputTokens,
            double? temperature,
            global::Cartesia.ManagedAgentFallbackStrategyV1? fallbackStrategy,
            global::Cartesia.ManagedAgentCustomLlmV1? customLlm)
        {
            this.Id = id;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.FallbackStrategy = fallbackStrategy;
            this.CustomLlm = customLlm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigModel" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigModel()
        {
        }

    }
}