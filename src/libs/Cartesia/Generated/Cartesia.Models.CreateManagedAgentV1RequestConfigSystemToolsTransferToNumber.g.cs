
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Configuration for transferring the call. Omit or set to `null` to disable this tool.
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber
    {
        /// <summary>
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeechJsonConverter))]
        public global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? PreToolSpeech { get; set; }

        /// <summary>
        /// Phone numbers the agent can transfer a call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer> Transfers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber" /> class.
        /// </summary>
        /// <param name="transfers">
        /// Phone numbers the agent can transfer a call to.
        /// </param>
        /// <param name="description">
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber(
            global::System.Collections.Generic.IList<global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer> transfers,
            string? description,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberPreToolSpeech? preToolSpeech)
        {
            this.Description = description;
            this.PreToolSpeech = preToolSpeech;
            this.Transfers = transfers ?? throw new global::System.ArgumentNullException(nameof(transfers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigSystemToolsTransferToNumber()
        {
        }

    }
}