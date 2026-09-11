
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigAudio? Audio { get; set; }

        /// <summary>
        /// Message the agent says when the conversation begins. Set to `null` to wait for the user to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_message")]
        public string? InitialMessage { get; set; }

        /// <summary>
        /// Instructions that define the agent's behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigLanguage? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigModel? Model { get; set; }

        /// <summary>
        /// Built-in tools available to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tools")]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemTools? SystemTools { get; set; }

        /// <summary>
        /// Tools available to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfig" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="initialMessage">
        /// Message the agent says when the conversation begins. Set to `null` to wait for the user to speak first.
        /// </param>
        /// <param name="instructions">
        /// Instructions that define the agent's behavior.
        /// </param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="systemTools">
        /// Built-in tools available to the agent.
        /// </param>
        /// <param name="tools">
        /// Tools available to the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfig(
            global::Cartesia.CreateManagedAgentV1RequestConfigAudio? audio,
            string? initialMessage,
            string? instructions,
            global::Cartesia.CreateManagedAgentV1RequestConfigLanguage? language,
            global::Cartesia.CreateManagedAgentV1RequestConfigModel? model,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemTools? systemTools,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1>? tools)
        {
            this.Audio = audio;
            this.InitialMessage = initialMessage;
            this.Instructions = instructions;
            this.Language = language;
            this.Model = model;
            this.SystemTools = systemTools;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfig" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfig()
        {
        }

    }
}