
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Example: {"id":"gpt-5.4-mini","fallback_strategy":{"type":"auto"},"temperature":0.5,"max_output_tokens":2048}
    /// </summary>
    public sealed partial class ManagedAgentConfigV1Model
    {
        /// <summary>
        /// Model ID from `GET /v1/agents/models`, or `custom_llm`<br/>
        /// Example: gpt-5.4-mini
        /// </summary>
        /// <example>gpt-5.4-mini</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentFallbackStrategyV1 FallbackStrategy { get; set; }

        /// <summary>
        /// The custom endpoint. Present only when `id` is `custom_llm`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm")]
        public global::Cartesia.ManagedAgentCustomLlmResponseV1? CustomLlm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Model" /> class.
        /// </summary>
        /// <param name="id">
        /// Model ID from `GET /v1/agents/models`, or `custom_llm`<br/>
        /// Example: gpt-5.4-mini
        /// </param>
        /// <param name="fallbackStrategy">
        /// Models to try when the primary fails before responding. `auto` selects Cartesia-managed fallbacks (the default for new managed-model agents); `explicit` tries up to three managed model IDs in order; `null` disables fallback.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of tokens the model can generate, from `1` to `4096`. Set to `null` for no limit.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of model responses, from `0` to `1`.
        /// </param>
        /// <param name="customLlm">
        /// The custom endpoint. Present only when `id` is `custom_llm`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1Model(
            string id,
            global::Cartesia.ManagedAgentFallbackStrategyV1 fallbackStrategy,
            int? maxOutputTokens,
            double? temperature,
            global::Cartesia.ManagedAgentCustomLlmResponseV1? customLlm)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.FallbackStrategy = fallbackStrategy;
            this.CustomLlm = customLlm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Model" /> class.
        /// </summary>
        public ManagedAgentConfigV1Model()
        {
        }

    }
}