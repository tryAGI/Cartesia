
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentModelV1Pricing
    {
        /// <summary>
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_per_million_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheReadPerMillionTokens { get; set; }

        /// <summary>
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_per_million_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheWritePerMillionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentModelV1PricingCurrencyJsonConverter))]
        public global::Cartesia.ManagedAgentModelV1PricingCurrency Currency { get; set; }

        /// <summary>
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_per_million_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputPerMillionTokens { get; set; }

        /// <summary>
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_per_million_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputPerMillionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentModelV1Pricing" /> class.
        /// </summary>
        /// <param name="cacheReadPerMillionTokens">
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </param>
        /// <param name="cacheWritePerMillionTokens">
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </param>
        /// <param name="inputPerMillionTokens">
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </param>
        /// <param name="outputPerMillionTokens">
        /// Price in USD per one million tokens, represented as a decimal string.
        /// </param>
        /// <param name="currency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentModelV1Pricing(
            string cacheReadPerMillionTokens,
            string cacheWritePerMillionTokens,
            string inputPerMillionTokens,
            string outputPerMillionTokens,
            global::Cartesia.ManagedAgentModelV1PricingCurrency currency)
        {
            this.CacheReadPerMillionTokens = cacheReadPerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(cacheReadPerMillionTokens));
            this.CacheWritePerMillionTokens = cacheWritePerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(cacheWritePerMillionTokens));
            this.Currency = currency;
            this.InputPerMillionTokens = inputPerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(inputPerMillionTokens));
            this.OutputPerMillionTokens = outputPerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(outputPerMillionTokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentModelV1Pricing" /> class.
        /// </summary>
        public ManagedAgentModelV1Pricing()
        {
        }

    }
}