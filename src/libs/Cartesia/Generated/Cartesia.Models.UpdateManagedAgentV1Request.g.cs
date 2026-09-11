
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedAgentV1Request
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Cartesia.UpdateManagedAgentV1RequestConfig? Config { get; set; }

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
        /// Description to attach to the new configuration version. Allowed only when this request changes `config`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1Request" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="description">
        /// Description of the agent.
        /// </param>
        /// <param name="name">
        /// Name shown for the agent. It does not need to be unique.
        /// </param>
        /// <param name="versionDescription">
        /// Description to attach to the new configuration version. Allowed only when this request changes `config`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1Request(
            global::Cartesia.UpdateManagedAgentV1RequestConfig? config,
            string? description,
            string? name,
            string? versionDescription)
        {
            this.Config = config;
            this.Description = description;
            this.Name = name;
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1Request" /> class.
        /// </summary>
        public UpdateManagedAgentV1Request()
        {
        }

    }
}