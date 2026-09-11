
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedAgentConfigV1Model
    {
        /// <summary>
        /// Model ID from `GET /v1/agents/models`.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Model" /> class.
        /// </summary>
        /// <param name="id">
        /// Model ID from `GET /v1/agents/models`.<br/>
        /// Example: gpt-5.4-mini
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
        public ManagedAgentConfigV1Model(
            string id,
            int? maxOutputTokens,
            double? temperature)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1Model" /> class.
        /// </summary>
        public ManagedAgentConfigV1Model()
        {
        }

    }
}