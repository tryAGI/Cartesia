
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Complete configuration for the agent's model, language, audio, and tools.
    /// </summary>
    public sealed partial class ManagedAgentConfigV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentConfigV1Audio Audio { get; set; }

        /// <summary>
        /// Message the agent says when the conversation begins. Set to `null` to wait for the user to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_message")]
        public string? InitialMessage { get; set; }

        /// <summary>
        /// Instructions that define the agent's behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentConfigV1Language Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentConfigV1Model Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentSystemToolsV1 SystemTools { get; set; }

        /// <summary>
        /// Tools available to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="instructions">
        /// Instructions that define the agent's behavior.
        /// </param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="systemTools"></param>
        /// <param name="tools">
        /// Tools available to the agent.
        /// </param>
        /// <param name="initialMessage">
        /// Message the agent says when the conversation begins. Set to `null` to wait for the user to speak first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1(
            global::Cartesia.ManagedAgentConfigV1Audio audio,
            string instructions,
            global::Cartesia.ManagedAgentConfigV1Language language,
            global::Cartesia.ManagedAgentConfigV1Model model,
            global::Cartesia.ManagedAgentSystemToolsV1 systemTools,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1> tools,
            string? initialMessage)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.InitialMessage = initialMessage;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemTools = systemTools ?? throw new global::System.ArgumentNullException(nameof(systemTools));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1" /> class.
        /// </summary>
        public ManagedAgentConfigV1()
        {
        }

    }
}