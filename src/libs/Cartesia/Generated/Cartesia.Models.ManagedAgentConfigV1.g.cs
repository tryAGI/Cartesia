
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
        /// Sample values for Playground test calls. Production calls never use them.<br/>
        /// Replaces saved samples on update. Omit to keep them, or send `{}` to clear them.<br/>
        /// Variable names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. Start with a letter or underscore; `system__` and `secret__` prefixes are reserved. Limited to 16 KiB of UTF-8 JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable_placeholders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentDynamicVariablePlaceholdersV1 DynamicVariablePlaceholders { get; set; }

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
        /// IANA time zone for `{{system__time}}`. Defaults to `UTC`.<br/>
        /// Example: America/Los_Angeles
        /// </summary>
        /// <example>America/Los_Angeles</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Tools available to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentConfigV1Turn Turn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="dynamicVariablePlaceholders">
        /// Sample values for Playground test calls. Production calls never use them.<br/>
        /// Replaces saved samples on update. Omit to keep them, or send `{}` to clear them.<br/>
        /// Variable names are case-sensitive, up to 64 characters, and use letters, digits, or underscores. Start with a letter or underscore; `system__` and `secret__` prefixes are reserved. Limited to 16 KiB of UTF-8 JSON.
        /// </param>
        /// <param name="instructions">
        /// Instructions that define the agent's behavior.
        /// </param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="systemTools"></param>
        /// <param name="timezone">
        /// IANA time zone for `{{system__time}}`. Defaults to `UTC`.<br/>
        /// Example: America/Los_Angeles
        /// </param>
        /// <param name="tools">
        /// Tools available to the agent.
        /// </param>
        /// <param name="turn"></param>
        /// <param name="initialMessage">
        /// Message the agent says when the conversation begins. Set to `null` to wait for the user to speak first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1(
            global::Cartesia.ManagedAgentConfigV1Audio audio,
            global::Cartesia.ManagedAgentDynamicVariablePlaceholdersV1 dynamicVariablePlaceholders,
            string instructions,
            global::Cartesia.ManagedAgentConfigV1Language language,
            global::Cartesia.ManagedAgentConfigV1Model model,
            global::Cartesia.ManagedAgentSystemToolsV1 systemTools,
            string timezone,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentToolReferenceV1> tools,
            global::Cartesia.ManagedAgentConfigV1Turn turn,
            string? initialMessage)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.DynamicVariablePlaceholders = dynamicVariablePlaceholders ?? throw new global::System.ArgumentNullException(nameof(dynamicVariablePlaceholders));
            this.InitialMessage = initialMessage;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemTools = systemTools ?? throw new global::System.ArgumentNullException(nameof(systemTools));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Turn = turn ?? throw new global::System.ArgumentNullException(nameof(turn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1" /> class.
        /// </summary>
        public ManagedAgentConfigV1()
        {
        }

    }
}