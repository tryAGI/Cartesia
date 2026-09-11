
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigModel
    {
        /// <summary>
        /// Model ID from `GET /v1/agents/models`.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Model ID from `GET /v1/agents/models`.
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
        public UpdateManagedAgentV1RequestConfigModel(
            string? id,
            int? maxOutputTokens,
            double? temperature)
        {
            this.Id = id;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigModel" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigModel()
        {
        }

    }
}