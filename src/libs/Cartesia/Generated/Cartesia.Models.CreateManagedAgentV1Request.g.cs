
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1Request
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Cartesia.CreateManagedAgentV1RequestConfig? Config { get; set; }

        /// <summary>
        /// Description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name shown for the agent. It does not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1Request" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="description">
        /// Description of the agent.
        /// </param>
        /// <param name="name">
        /// Name shown for the agent. It does not need to be unique.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1Request(
            global::Cartesia.CreateManagedAgentV1RequestConfig? config,
            string? description,
            string? name)
        {
            this.Config = config;
            this.Description = description;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1Request" /> class.
        /// </summary>
        public CreateManagedAgentV1Request()
        {
        }

    }
}