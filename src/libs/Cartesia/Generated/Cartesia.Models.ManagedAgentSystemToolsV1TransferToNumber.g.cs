
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Configuration for transferring the call. Set to `null` to disable this tool.
    /// </summary>
    public sealed partial class ManagedAgentSystemToolsV1TransferToNumber
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech PreToolSpeech { get; set; }

        /// <summary>
        /// Phone numbers the agent can transfer a call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer> Transfers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1TransferToNumber" /> class.
        /// </summary>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, while `force` asks the agent to speak first.
        /// </param>
        /// <param name="transfers">
        /// Phone numbers the agent can transfer a call to.
        /// </param>
        /// <param name="description">
        /// What the tool does and when the agent should use it. Set to `null` to use the default system-optimized description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentSystemToolsV1TransferToNumber(
            global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberPreToolSpeech preToolSpeech,
            global::System.Collections.Generic.IList<global::Cartesia.ManagedAgentSystemToolsV1TransferToNumberTransfer> transfers,
            string? description)
        {
            this.Description = description;
            this.PreToolSpeech = preToolSpeech;
            this.Transfers = transfers ?? throw new global::System.ArgumentNullException(nameof(transfers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentSystemToolsV1TransferToNumber" /> class.
        /// </summary>
        public ManagedAgentSystemToolsV1TransferToNumber()
        {
        }

    }
}